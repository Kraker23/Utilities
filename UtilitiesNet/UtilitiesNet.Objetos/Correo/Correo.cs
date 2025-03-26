using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UtilitiesNet.Objetos.Correo
{
    public class Correo
    {

        /// <summary>
        /// para enviar correos desde la cuenta del outlook instalada en tu ordinador
        /// </summary>
        /// <param name="mailDirection"> el destino del correo </param>
        /// <param name="mailSubject"> el asunto del correo </param>
        /// <param name="mailContent">el contenido del correo </param>
        public string sendMail(string mailDirection, string mailSubject, string mailContent)
        {
            try
            {
                var oApp = new Microsoft.Office.Interop.Outlook.Application();

                Microsoft.Office.Interop.Outlook.NameSpace ns = oApp.GetNamespace("MAPI");
                var f = ns.GetDefaultFolder(Microsoft.Office.Interop.Outlook.OlDefaultFolders.olFolderInbox);

                System.Threading.Thread.Sleep(1000);

                var mailItem = (Microsoft.Office.Interop.Outlook.MailItem)oApp.CreateItem(Microsoft.Office.Interop.Outlook.OlItemType.olMailItem);
                mailItem.Subject = mailSubject;
                mailItem.HTMLBody = mailContent;
                mailItem.To = mailDirection;
                mailItem.Send();
                return string.Empty;

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);

                return ex.Message;
            }
        }


        /// <summary>
        /// para enviar correos desde la cuenta del outlook instalada en tu ordinador
        /// </summary>
        /// <param name="mailDirection"> el destino del correo </param>
        /// <param name="cc">el contenido del correo </param>
        /// <param name="cco">el contenido del correo </param>
        /// <param name="mailSubject"> el asunto del correo </param>
        /// <param name="mailContent">el contenido del correo </param>
        //public string sendMail(string mailDirection,string cc,string cco, string mailSubject, string mailContent,List<Microsoft.Office.Interop.Outlook.Attachment> adjuntos)
        public string sendMail(string mailDirection,string cc,string cco, string mailSubject, string mailContent)
        {
            try
            {
                var oApp = new Microsoft.Office.Interop.Outlook.Application();

                Microsoft.Office.Interop.Outlook.NameSpace ns = oApp.GetNamespace("MAPI");
                var f = ns.GetDefaultFolder(Microsoft.Office.Interop.Outlook.OlDefaultFolders.olFolderInbox);

                System.Threading.Thread.Sleep(1000);

                var mailItem = (Microsoft.Office.Interop.Outlook.MailItem)oApp.CreateItem(Microsoft.Office.Interop.Outlook.OlItemType.olMailItem);
                mailItem.Subject = mailSubject;
                mailItem.HTMLBody = mailContent;
                mailItem.To = mailDirection;
                mailItem.CC = cc;
                mailItem.BCC = cco;

                //if (adjuntos!=null && adjuntos.Count()>0)
                //{
                //    foreach (Microsoft.Office.Interop.Outlook.Attachment item in adjuntos)
                //    {
                //        mailItem.Attachments.Add(item);
                //    }
                //}

                mailItem.Send();
                return string.Empty;

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);

                return ex.Message;
            }
        }

       
        /// <summary>
        /// para enviar correos desde la cuenta del outlook instalada en tu ordinador
        /// </summary>
        /// <param name="mailDirection"> el destino del correo </param>
        /// <param name="cc">el cc del correo </param>
        /// <param name="cco">el cco del correo </param>
        /// <param name="mailSubject"> el asunto del correo </param>
        /// <param name="mailContent">el contenido del correo </param>
        /// <param name="adjuntos">los archivos adjutnos del correo </param>
        public string sendMail(string mailDirection, string cc, string cco, string mailSubject, string mailContent, List<string> adjuntos)
        {
            try
            {
                var oApp = new Microsoft.Office.Interop.Outlook.Application();

                Microsoft.Office.Interop.Outlook.NameSpace ns = oApp.GetNamespace("MAPI");
                var f = ns.GetDefaultFolder(Microsoft.Office.Interop.Outlook.OlDefaultFolders.olFolderInbox);

                System.Threading.Thread.Sleep(1000);

                var mailItem = (Microsoft.Office.Interop.Outlook.MailItem)oApp.CreateItem(Microsoft.Office.Interop.Outlook.OlItemType.olMailItem);
                mailItem.Subject = mailSubject;
                mailItem.HTMLBody = mailContent;
                mailItem.To = mailDirection;
                mailItem.CC = cc;
                mailItem.BCC = cco;

                if (adjuntos != null && adjuntos.Count() > 0)
                {
                    foreach (string adj in adjuntos)
                    {
                        mailItem.Attachments.Add(adj);
                    }
                }

                mailItem.Send();
                return string.Empty;

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);

                return ex.Message;
            }
        }

        /// <summary>
        /// para enviar correos desde la cuenta del outlook instalada en tu ordinador
        /// </summary>
        /// <param name="mailDirection"> el destino del correo </param>
        /// <param name="cc">el cc del correo </param>
        /// <param name="cco">el cco del correo </param>
        /// <param name="mailSubject"> el asunto del correo </param>
        /// <param name="mailContent">el contenido del correo </param>
        /// <param name="adjuntos">los archivos adjutnos del correo </param>
        //public string sendMail(string mailDirection, string cc, string cco, string mailSubject, string mailContent, List<Microsoft.Office.Interop.Outlook.Attachment> adjuntos)
        //{
        //    try
        //    {
        //        var oApp = new Microsoft.Office.Interop.Outlook.Application();

        //        Microsoft.Office.Interop.Outlook.NameSpace ns = oApp.GetNamespace("MAPI");
        //        var f = ns.GetDefaultFolder(Microsoft.Office.Interop.Outlook.OlDefaultFolders.olFolderInbox);

        //        System.Threading.Thread.Sleep(1000);

        //        var mailItem = (Microsoft.Office.Interop.Outlook.MailItem)oApp.CreateItem(Microsoft.Office.Interop.Outlook.OlItemType.olMailItem);
        //        mailItem.Subject = mailSubject;
        //        mailItem.HTMLBody = mailContent;
        //        mailItem.To = mailDirection;
        //        mailItem.CC = cc;
        //        mailItem.BCC = cco;

        //        if (adjuntos != null && adjuntos.Count() > 0)
        //        {
        //            foreach (Microsoft.Office.Interop.Outlook.Attachment item in adjuntos)
        //            {
        //                mailItem.Attachments.Add(item);
        //            }
        //        }

        //        mailItem.Send();
        //        return string.Empty;

        //    }
        //    catch (Exception ex)
        //    {
        //        //MessageBox.Show(ex.Message);

        //        return ex.Message;
        //    }
        //}


        public bool correoValido(string email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
