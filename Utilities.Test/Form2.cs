using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities.Clases.AccesoCarpeta;
using Utilities.Controls.HerramientaTextos;
using Utilities.Controls.IntroducirTexto;
using Utilities.Extensions;

namespace Utilities.Test
{
    public partial class Form2 : Form
    {
        public string salida;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //SeparadorTexto st = new SeparadorTexto();
            //st.Dock = DockStyle.Fill;
            //this.Controls.Add(st);

            //cEncriptarDesencriptarTexto st = new cEncriptarDesencriptarTexto();
            //st.Dock = DockStyle.Fill;
            //this.Controls.Add(st);


            //Acceso a = new Acceso("C:\\Program Files (x86)\\GroupM\\Adplanning");
            //a.TienePermisosLectura();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            List<Info> lista = new List<Info>();

            //string Ruta = @"\\madappp01113\Aplicaciones\GRM\AdPlanning\Produccion\Accesos\Access.txt";
            string Ruta = @"\\madappp01113\Aplicaciones\GRM\AdPlanning\Produccion\Accesos";
            //forma1(lista, Ruta);
            forma2(lista, Ruta);
        }

        private void forma1(List<Info> lista, string Ruta)
        {
            try
            {
                if (System.IO.Directory.Exists(Ruta))
                {
                    List<string> archivos = getArchivos(Ruta);
                    foreach (string item in archivos.OrderBy(x => x))
                    {
                        getDatos(lista, Path.Combine(Ruta, item));
                    }

                    CrearInsert(lista);
                    MessageBox.Show("Finalizado!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! -> " + ex.Message);
            }
        }


        private static void getDatos(List<Info> lista, string Ruta)
        {
            //if (System.IO.File.Exists(Ruta)/* & System.IO.File.GetLastWriteTime(Ruta).Date<DateTime.Now.Date*/)
            if (System.IO.File.Exists(Ruta))
            {
                string[] lines = System.IO.File.ReadAllLines(Ruta);
                if (lines.Count() > 0)
                {
                    foreach (string linea in lines)
                    {
                        if (!string.IsNullOrEmpty(linea) && !linea.Contains("****"))
                        {
                            string[] split = linea.Split(" -> ");
                            if (split.Count() > 0)
                            {
                                try
                                {
                                    Info i = new Info();
                                    foreach (string item in split)
                                    {
                                        item.TrimEnd();
                                        if (item.Contains("Dia :"))
                                        {
                                            i.fecha = DateTime.Parse(item.Substring(item.IndexOf(":") + 1).Trim());
                                        }
                                        else if (item.Contains("Persona :"))
                                        {
                                            i.person = item.Substring(item.IndexOf(":") + 1).Trim();
                                        }
                                        else if (item.Contains("Maquina :"))
                                        {
                                            i.maquina = item.Substring(item.IndexOf(":") + 1).Trim();
                                        }
                                        else if (item.Contains("Existe :"))
                                        {
                                            i.existe = item.Substring(item.IndexOf(":") + 1).Trim() == "Si" ? true : false;
                                        }
                                        else if (item.Contains("Lectura :"))
                                        {
                                            i.lectura = item.Substring(item.IndexOf(":") + 1).Trim() == "Si" ? true : false;
                                        }
                                        else if (item.Contains("Escritura :"))
                                        {
                                            i.escritura = item.Substring(item.IndexOf(":") + 1).Trim() == "Si" ? true : false;
                                        }
                                        else if (item.Contains("Error :"))
                                        {
                                            i.error = item.Substring(item.IndexOf(":") + 1).Trim();
                                        }
                                    }

                                    lista.Add(i);
                                }
                                catch (Exception)
                                {

                                }
                            }
                        }
                    }
                }
            }
        }


        static List<string> lineasTotales = new List<string>();
        private void forma2(List<Info> lista, string Ruta)
        {
            try
            {
                if (System.IO.Directory.Exists(Ruta))
                {
                    lblInfo.Text = "Empezando";
                    CheckForIllegalCrossThreadCalls = false;
                    Task.Factory.StartNew(() =>
                    {
                        List<string> archivos = getArchivos(Ruta);
                        int i = 0;
                        foreach (string item in archivos.OrderBy(x => x))
                        {
                            if (item !="Access.txt")
                            {
                                getLineas(Path.Combine(Ruta, item));
                                lblInfo.Text = "Archivo " + i + " de " + archivos.Count();
                                i++;
                            }
                        }
                    }).ContinueWith((t) =>
                    {
                        procesarDatos(lista);

                    }).ContinueWith((t) =>
                    {
                        lblInfo.Text = "CrearInsert";
                        CrearInsert(lista);
                        lblInfo.Text = "Finalizado!";
                        MessageBox.Show("Finalizado!");
                        CheckForIllegalCrossThreadCalls = true;
                    }, TaskScheduler.FromCurrentSynchronizationContext());
                }
                else
                {
                    lblInfo.Text = "Problema con la Ruta";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! -> " + ex.Message);
            }
        }

        private static void getLineas(string Ruta)
        {
            //if (System.IO.File.Exists(Ruta)/* & System.IO.File.GetLastWriteTime(Ruta).Date<DateTime.Now.Date*/)
            if (System.IO.File.Exists(Ruta))
            {
                string[] lines = System.IO.File.ReadAllLines(Ruta);
                if (lines.Count() > 0)
                {
                    lineasTotales.AddRange(lines.Where(x => !string.IsNullOrEmpty(x) && !x.Contains("****")).ToList());
                }

            }
        }

        private void procesarDatos(List<Info> lista)
        {
            if (lineasTotales.Count() > 0)
            {
                foreach (string linea in lineasTotales.Where(x=> !string.IsNullOrEmpty(x) &&  !x.Contains("****") ))
                {
                    string[] split = linea.Split(" -> ");
                    if (split.Count() > 0)
                    {
                        try
                        {
                            Info i = new Info();
                            
                            if (split[0].Contains("Dia :"))
                            {
                                i.fecha = DateTime.Parse(split[0].Substring(split[0].IndexOf(":") + 1).Trim());
                            }
                            if (split[1].Contains("Persona :"))
                            {
                                i.person = split[1].Substring(split[1].IndexOf(":") + 1).Trim();
                            }
                            if (split[2].Contains("Maquina :"))
                            {
                                i.maquina = split[2].Substring(split[2].IndexOf(":") + 1).Trim();
                            }
                            if (split[3].Contains("Existe :"))
                            {
                                i.existe = split[3].Substring(split[3].IndexOf(":") + 1).Trim() == "Si" ? true : false;
                            }
                            if (split[4].Contains("Lectura :"))
                            {
                                i.lectura = split[4].Substring(split[4].IndexOf(":") + 1).Trim() == "Si" ? true : false;
                            }
                            if (split[5].Contains("Escritura :"))
                            {
                                i.escritura = split[5].Substring(split[5].IndexOf(":") + 1).Trim() == "Si" ? true : false;
                            }
                            if (split[6].Contains("Error :"))
                            {
                                i.error = split[6].Substring(split[6].IndexOf(":") + 1).Trim();
                            }
                            

                            lista.Add(i);
                        }
                        catch (Exception)
                        {

                        }
                    }
                    
                }
            }
        }



        private List<string> getArchivos(string ruta)
        {
            List<string> archivos = new List<string>();

            if (System.IO.Directory.Exists(ruta))
            {
                foreach (string pathArchivo in System.IO.Directory.GetFiles(ruta))
                {
                    if (System.IO.File.Exists(pathArchivo))
                    {
                        archivos.Add(System.IO.Path.GetFileName(pathArchivo));
                    }
                }
            }

            return archivos;
        }
        
        private void CrearInsert(List<Info> lista)
        {
            string createTable = "	create TABLE #tabla (fecha varchar(100),persona varchar(100),maquina varchar(100),existe bit,lectura bit,escritura bit,error varchar(max))";
            string insert = "Insert into #tabla values ";

            string Resultado = string.Empty;
            int i = 0;
            int iTotal = 0;
            string valores = string.Empty;
            try
            {

                
                foreach (Info item in lista)
                {
                    if (!string.IsNullOrEmpty(item.error) && item.error.Contains('\''))
                    {
                        item.error = item.error.Replace('\'', '\"');
                    }
                    valores = valores + Environment.NewLine +
                        string.Format("('{0}','{1}','{2}',{3},{4},{5},'{6}'),",
                        !string.IsNullOrEmpty(item.fecha.ToString()) ? item.fecha.ToString() : "",
                        !string.IsNullOrEmpty(item.person) ? item.person : "",
                        !string.IsNullOrEmpty(item.maquina) ? item.maquina: "",
                        item.existe == true ? 1 : 0,
                        item.lectura == true ? 1 : 0,
                        item.escritura == true ? 1 : 0,
                        !string.IsNullOrEmpty(item.error) ? item.error : ""
                        );
                    i++;
                    if (i==999)
                    {
                        iTotal = iTotal + i;
                        valores = valores.Substring(0, valores.Length - 1);
                        valores = valores + Environment.NewLine+ insert + Environment.NewLine ;
                        i = 0;
                    }
                }
                if (lista.Count() > 0)
                {
                    valores = valores.Substring(0, valores.Length - 1);
                }
            }
            catch   (Exception ex)
            {

            }

            string drop = "--drop table #tabla ";

            string select = "select* from #tabla " + Environment.NewLine +
                "" +
                "select  'Personas ',persona,maquina,existe,lectura,escritura,error ,count(*)Contador" + Environment.NewLine +
                "from #tabla " + Environment.NewLine +
                "group by persona,maquina,existe,lectura,escritura,error " + Environment.NewLine +
                 "" +
                "select 'Con Errores',count(*)  from #tabla where error <>''" + Environment.NewLine +
                 "" +
                "select 'Sin Errores',count(*) from #tabla where error ='' " + Environment.NewLine +
                "select 'No pueden Escribir',count(*)  from #tabla where escritura=0" + Environment.NewLine +

                Environment.NewLine +
                Environment.NewLine +

                "select t.persona,t.maquina ,case when s.usuariont is null then 0 else 1 end utilizaADP" + Environment.NewLine +
                "from #tabla  t" + Environment.NewLine +
                "left join [SS_Ultima_Conexion_UsuarioADP_NT] s on t.persona = s.usuariont" + Environment.NewLine +
                "where escritura = 0" + Environment.NewLine +
                "group by persona,maquina,s.usuariont" + Environment.NewLine +
                "order by persona, maquina" + Environment.NewLine 
                ;


            Resultado = createTable + Environment.NewLine + insert + Environment.NewLine + valores + Environment.NewLine + select + Environment.NewLine + drop;
            salida = Resultado;
            Clipboard.SetText(Resultado);
        }
    }

    public class Info
    {
        public DateTime fecha { get; set; }
        public string person { get; set; }
        public string maquina { get; set; }
        public bool existe { get; set; }
        public bool lectura { get; set; }
        public bool escritura { get; set; }
        public string error { get; set; }
    }
}
