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
using Utilities.Clases.MessageTemporal;
using Utilities.Controls.Correo;
using static Utilities.Controls.Leyenda.DropDownLeyenda;
using static Utilities.Controls.Leyenda.Menu;

namespace Utilities.Test
{
    public partial class Form1 : Form
    {
        public Timer timer;

        [System.Runtime.InteropServices.DllImport("USER32.DLL")]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern Int32 SendMessageA(IntPtr hWnd, Int32 wMsg, Int32 wParam, string lParam);
        private const int WM_CLOSE = 0x10;


        public Form1()
        {
            InitializeComponent();
            cNewCorreo correo = new cNewCorreo("c.ramirez@eskape.es", "Eskpe1234");
            correo.Dock = DockStyle.Fill;
            this.Controls.Clear();
            this.Controls.Add(correo);
            // crearDD();
        }

        private void crearDD()
        {

            LeyendaDropDown sel = new LeyendaDropDown(new Point(250, 15));
            
            DropDownItem item = new DropDownItem("hola",Color.Red);
            DropDownItem item2 = new DropDownItem("r",Color.Green);
            DropDownItem item3 = new DropDownItem("d",Color.Yellow);
            DropDownItem item4 = new DropDownItem("v",Color.Blue);
            DropDownItem item5 = new DropDownItem("j",Color.Orange);
           

            

            sel.Items.Add(item);
            sel.Items.Add(item2);
            sel.Items.Add(item3);
            sel.Items.Add(item4);
            sel.Items.Add(item5);

            this.Controls.Add(sel);


            MenuButton bt = new MenuButton();
            //bt.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            bt.Name = "toolStripDropDownButton1";
            bt.Size = new System.Drawing.Size(29, 22);
            bt.Text = "toolStripDropDownButton1";

            ContextMenuStrip menu = new ContextMenuStrip();

            menu.Items.Add("Hola", Utilities.Controls.Leyenda.Menu.GetImagen(Color.Red));

            bt.Menu = menu;

            this.Controls.Add(bt);

            //ToolStripDropDownButton bt = new ToolStripDropDownButton();
            //bt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            ////bt.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));

            //bt.ImageTransparentColor = System.Drawing.Color.Magenta;
            //bt.Name = "toolStripDropDownButton1";
            //bt.Size = new System.Drawing.Size(29, 22);
            //bt.Text = "toolStripDropDownButton1";

            //this.Controls.Add(bt);
            //ContextMenuStrip menu = new ContextMenuStrip();

            //Bitmap imagen = new Bitmap(16, 16);
            //using (Graphics g = Graphics.FromImage(imagen))
            //{
            //    using (Brush b = new SolidBrush(Color.Red))
            //    {
            //        g.DrawRectangle(Pens.White, 0, 0, imagen.Width, imagen.Height);
            //        g.FillRectangle(b, 1, 1, imagen.Width - 1, imagen.Height - 1);
            //    }
            //}

            //menu.Items.Add("Hola", imagen);

            //MenuButton bt = new MenuButton();
            //bt.Menu = menu;

            //this.Controls.Add(bt);
        }

       
    

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBoxTemporal.Show("Mensaje de prueba para karmany.NET", "Título", 5, false);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            cProgressBackground.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            cProgressBackground.End();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < contextMenuStrip1.Items.Count; i++)
            {
                if (contextMenuStrip1.Items[i].Text=="")
                {

                }
            }

            ToolStripMenuItem item, submenu;

            submenu = new ToolStripMenuItem();
            submenu.Text = "Sub-menu 1";

            item = new ToolStripMenuItem();
            item.Text = "Sub-item 1";
            submenu.DropDownItems.Add(item);

            item = new ToolStripMenuItem();
            item.Text = "Sub-item 2";
            submenu.DropDownItems.Add(item);

            contextMenuStrip1.Items.Add(submenu);

            ToolStripMenuItem item2;

            //contextMenuStrip1.Items[i]

            item2 = new ToolStripMenuItem();
            item2.Text = "Sub-item 1";
            ((ToolStripMenuItem)contextMenuStrip1.Items[0]).DropDownItems.Add(item2);

            item2 = new ToolStripMenuItem();
            item2.Text = "Sub-item 2";
            ((ToolStripMenuItem)contextMenuStrip1.Items[0]).DropDownItems.Add(item2);

            contextMenuStrip1.Items.Add(submenu);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string archivoLog = "LogActualizacacion.txt";
            string RutaLocal = System.IO.Directory.GetCurrentDirectory();

            if (!System.IO.File.Exists(Path.Combine(RutaLocal, archivoLog)))
            {
                System.IO.File.Create(Path.Combine(RutaLocal, archivoLog));
            }

            //string txt = null;
            //using (StreamReader file = new StreamReader(Path.Combine(RutaLocal, archivoLog)))
            //{

            //    txt = file.ReadToEnd();
            //}
           //using (System.IO.StreamWriter file =new System.IO.StreamWriter(@"C:\Users\Public\TestFolder\WriteLines2.txt"))
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(Path.Combine(RutaLocal, archivoLog),true))
            {
                //file.WriteLine(txt + file.NewLine+"Fourth line");
                file.WriteLine("five  line");
            }
        }
    }
}
