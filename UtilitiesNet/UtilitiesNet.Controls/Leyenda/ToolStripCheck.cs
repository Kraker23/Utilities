using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UtilitiesNet.Controls.Leyenda
{

    public class ToolStripCheck : ToolStripMenuItem
    {
        /*
         * EJEMPLO 
         *  menu.Items.Add(new ToolStripCheck("Asociada", UtilitiesNet.Objetos.Leyenda.Menu.GetImagen(Color.LawnGreen), element2_Click));
         *  texto que se vera 
         *  imagen que tendra ala izquierda
         *  evento que se ejecutara cuando se haga click, es un evento que tiene que existir en el formulario donde esta el control para que haga la funcion que se quiera
         * */

        public ToolStripCheck() { }
        public ToolStripCheck(string text, Image image) : base(text, image) { }
        public ToolStripCheck(string text, Image image,bool allButtonSelect) : base(text, image) { this.allButtonSelect = allButtonSelect; }
        public ToolStripCheck(string text) : base(text) { }
        public ToolStripCheck(Image image) : base(image) { }
        public ToolStripCheck(string text, Image image, EventHandler onClick) : base(text, image, onClick) { }
        public ToolStripCheck(string text, Image image, int id) : base(text, image) { this.ID = id; }
        public ToolStripCheck(string text, Image image, int id, EventHandler onClick) : base(text, image, onClick) { this.ID = id; }
        public ToolStripCheck(string text, Image image, int id, EventHandler onClick ,bool estadoInicial) : base(text, image, onClick) { this.ID = id; this.Checked = estadoInicial; }

        private bool allButtonSelect = true;
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            
            if (base.Checked == false)
            {
                Rectangle rect = new Rectangle(this.Width - 20, 1, 20, 20);
                e.Graphics.DrawImage(global::UtilitiesNet.Controls.Properties.Resources.error, rect);//imagen del checkeo a la derecha

            }
            else
            {
                Rectangle rect = new Rectangle(this.Width - 20, 1, 20, 20);
                e.Graphics.DrawImage(global::UtilitiesNet.Controls.Properties.Resources.check2, rect);
            }
        }
        int ID { get; set; }
        bool StarClicked { get; set; }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            //Esto si se quiere que al pulsar a partir de un lado concreto checkee sino se quiere solo poner : (2 lineas siguientes)
            //this.Checked = this.Checked == true ? false : true;
            //base.OnMouseDown(e);
            //Hasta aqui
            if (allButtonSelect)
            {
                base.Checked = base.Checked == true ? false : true;
                base.OnMouseDown(e); //base.OnClick(e);
            }
            else
            {
                StarClicked = e.X > (this.Width - 20);
                if (StarClicked)
                {
                    base.Checked = base.Checked == true ? false : true;
                }
                else
                {
                    base.OnClick(e);
                }
            }
            base.OnMouseDown(e);
        }

       
    }
}
