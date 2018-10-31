using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities.Clases.MessageTemporal;
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
            crearDD();
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

        
    }
}
