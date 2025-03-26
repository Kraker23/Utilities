using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using UtilitiesNet.Extensiones;

namespace UtilitiesNet.Objetos.Correo
{
    public class GestorCorreo
    {
        private string De;
        private string Password;
        private string Para;
        private string CC;
        private string CCO;
        private string Asunto=string.Empty;
        private string Mensaje=string.Empty;
        private bool MensajeHtml;
        private MailPriority prioridad;
        private TipoServidor servidor;
        private bool clienteMail = false;
        private bool clienteSMTP= false;
        private List<string> adjuntos;

        public enum TipoServidor
        {
            Gmail,
            Otro
        }

        private SmtpClient smtp;//= new SmtpClient();

        private MailMessage email;//= new MailMessage();



        private GestorCorreo()
        {
            smtp = new SmtpClient();
            email = new MailMessage();
        }

       

        /// <summary>Configuracion de quien envia el correo </summary>
        /// <param name="QuienEnvia">Correo de la persona que enviara el correo</param>
        /// <param name="Password">Contraseña del correo </param>
        /// <param name="serv"></param>
        public GestorCorreo(string QuienEnvia,string Password, TipoServidor serv)
        {
            smtp = new SmtpClient();
            email = new MailMessage();
            if (QuienEnvia.FormatoCorreoValido())
            {
                this.Credenciales(QuienEnvia, Password, serv);
            }
            else
            {
                new Exception("Error en el formato de correo");
            }

        }

        /// <summary>Configuracion de quien envia el correo </summary>
        /// <param name="QuienEnvia">Correo de la persona que enviara el correo</param>
        /// <param name="Password">Contraseña del correo </param>
        /// <param name="serv"></param>
        public void Credenciales(string QuienEnvia, string Password, TipoServidor serv)
        {
            this.De = QuienEnvia;
            this.Password = Password;
            this.servidor = serv;

            CrearClienteSMTP();
        }



        /// <summary>Datos del Mensaje que contiene el correo</summary>
        /// <param name="Para"></param>
        /// <param name="Asunto"></param>
        /// <param name="mensaje"></param>
        /// <param name="mensajeHtml"></param>
        /// <param name="adjuntos"></param>
        /// <param name="prioridad"></param>
        public void NuevoCorreo(string Para,string Asunto, string mensaje,bool mensajeHtml, List<string> adjuntos = null, MailPriority prioridad= MailPriority.Normal)
        {
            List<string> listAuxPara= new List<string>();
            listAuxPara.Add(Para);

            this.NuevoCorreo(listAuxPara, null, null, Asunto, mensaje, mensajeHtml, adjuntos, prioridad);
        }

        /// <summary>Datos del Mensaje que contiene el correo</summary>
        /// <param name="Para"></param>
        /// <param name="Asunto"></param>
        /// <param name="mensaje"></param>
        /// <param name="mensajeHtml"></param>
        /// <param name="adjuntos"></param>
        /// <param name="prioridad"></param>
        public void NuevoCorreo(List<string> Para, string Asunto, string mensaje, bool mensajeHtml, List<string> adjuntos = null, MailPriority prioridad = MailPriority.Normal)
        {
            this.NuevoCorreo(Para, null, null, Asunto, mensaje, mensajeHtml, adjuntos, prioridad);
        }
       

        /// <summary>Datos del Mensaje que contiene el correo Completo</summary>
        /// <param name="Para"></param>
        /// <param name="CC">correo con Copia</param>
        /// <param name="CCO">Correo con Copia Oculta</param>
        /// <param name="Asunto"></param>
        /// <param name="mensaje"></param>
        /// <param name="mensajeHtml"></param>
        /// <param name="prioridad"></param>
        public void NuevoCorreo(List<string> Para, List<string> CC, List<string> CCO, string Asunto, string mensaje, bool mensajeHtml, List<string> adjuntos = null, MailPriority prioridad = MailPriority.Normal)
        {
            bool ErrorFormatoPara = true;
            bool ErrorFormatoCC = false;
            bool ErrorFormatoCCO = false;

            if (Para.HasContent())
            {
                foreach (string item in Para)
                {
                    if (!item.FormatoCorreoValido())
                    {
                        ErrorFormatoPara = true;
                        return;
                    }
                }
                ErrorFormatoPara= false;
            }
            if (CC.HasContent())
            {
                foreach (string item in CC)
                {
                    if (!item.FormatoCorreoValido())
                    {
                        ErrorFormatoCC = true;
                        return;
                    }
                }
            }
            if (CCO.HasContent())
            {
                foreach (string item in CCO)
                {
                    if (!item.FormatoCorreoValido())
                    {
                        ErrorFormatoCCO = true;
                        return;
                    }
                }
            }

            if (!ErrorFormatoPara && !ErrorFormatoCC && !ErrorFormatoCCO)
            {
                this.Para = Para.getListaToString(",");
                this.CC = CC.getListaToString(",");
                this.CCO = CCO.getListaToString(",");
                this.Asunto = Asunto;
                this.Mensaje = mensaje;
                this.MensajeHtml = mensajeHtml;
                this.prioridad = prioridad;
                this.adjuntos = adjuntos;

                CrearClienteMailAddress();
            }
            else
            {
                if (ErrorFormatoPara)
                {
                    new Exception("Existe un Error en el formato del Correo Para");
                }
                if (ErrorFormatoCC)
                {
                    new Exception("Existe un Error en el formato del Correo CC");
                }
                if (ErrorFormatoCCO)
                {
                    new Exception("Existe un Error en el formato del Correo CCO");
                }
            }
        }


        /// <summary>Funcion que crea el cliente SMTP para enviar Correos</summary>
        private void CrearClienteSMTP()
        {
            /*
            Host: El servidor anfrition que enviara el correo electrónico.
            Port: El numero de puerto de salida del correo electrónico(por defecto es el puerto 25).
            EnableSsl: Indicador si esta habilitado el certificado SSL.
            UseDefaultCredentials: Indicador si se utilizaran los credenciales predeterminados.
            Credentials: Credenciales a utilizar para enviar el correo electrónico por medio del protocolo SMTP, este atributo recibe un objeto de la clase NetworkCredential.
                */
            NetworkCredential nc = new NetworkCredential();
            if (!string.IsNullOrEmpty(De) && De.FormatoCorreoValido() && !string.IsNullOrEmpty(Password))
            {
                nc.UserName = De;
                nc.Password = Password;
            }

            //Configuracion de Puerto y Servidor de quien enviar el correo
            string Dominio = De.getDominioCorreo();
            switch (servidor)
            {
                case TipoServidor.Gmail:
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 587;
                    smtp.EnableSsl = true;
                    break;
                case TipoServidor.Otro:
                    smtp.Host = string.Format("smtp.{0}", Dominio);
                    if (smtp.Host.Contains("gmail"))
                    {
                        smtp.Port = 587;
                    }
                    else
                    {
                        smtp.Port = 25;
                    }
                    smtp.EnableSsl = true;
                    ServicePointManager.ServerCertificateValidationCallback =
                            delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { return true; };
                    break;
                default:
                    break;
            }

            smtp.UseDefaultCredentials = false;

            smtp.Credentials = nc;
            clienteSMTP = true;
        }

        /// <summary> Funcion que crea el correo para enviarlo</summary>
        private void CrearClienteMailAddress()
        {
            /*
            To: Dirección de corre electrónico donde enviaremos el correo electrónico, podemos utilizar el metodo "add" para incluirlo.
            From: Dirección de correo electrónico desde donde se enviara el correo electrónico.
            Subject: Define el título del correo electrónico.
            Body: Define el cuerpo del correo electrónico.
            IsBodyHtml: Indica si el cuerpo del correo electrónico esta es formato HTML.
            Priority: Definir la prioridad del correo electrónico(esto es ignorado por casi todos los servidores de correo electrónico).
            */
            
           
            email.To.Add(Para);

            if (!string.IsNullOrEmpty(CC))
            {
                email.CC.Add(CC);
            }

            if (!string.IsNullOrEmpty(CCO))
            {
                email.Bcc.Add(CCO);
            }

            email.From = new MailAddress(De);

            email.Subject = Asunto;

            email.Body = Mensaje;

            email.IsBodyHtml = MensajeHtml;

            email.Priority = prioridad;
            

            if (adjuntos.HasContent())
            {
                foreach (string adj in adjuntos)
                {
                    Attachment att = new Attachment(adj);
                    email.Attachments.Add(att);
                }
            }


            clienteMail = true;
        }

        /// <summary>funcion para enviar el correo </summary>
        /// <returns>Informacion si se ha enviado correctamente el correo o tiene algun fallo de envio</returns>
        public string EnviarCorreo()
        {
            string output = null;
            if (clienteMail && clienteSMTP)
            {
                try
                {
                    smtp.Send(email);
                    email.Dispose();
                    output = "Corre electrónico fue enviado satisfactoriamente.";
                }
                catch (Exception ex)
                {
                    output = "Error enviando correo electrónico: " + ex.Message + ". " + Environment.NewLine + ex.InnerException.ToString();
                }
            }
            else
            {
                if (!clienteSMTP)
                {
                    output= "Error: Falta crear el constructor del SMTP, porfavor utilize el constructor Completo o utilize la funcion Credenciales.";
                }
                if (!clienteMail)
                {
                    output= "Error: Falta informacion sobre el correo. Utilizar la funcion NuevoCorreo.";
                }
            }

            return output;
        }

    }
}
