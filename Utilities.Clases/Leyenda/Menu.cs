using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utilities.Clases.Leyenda
{
    public class Menu
    {
        /*
         * EJEMPLO: ->
         * 
          MenuButton bt = new MenuButton();
            bt.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            bt.Name = "toolStripDropDownButton1";
            bt.Size = new System.Drawing.Size(29, 22);
            bt.Text = "toolStripDropDownButton1";
            bt.TextImageRelation = TextImageRelation.ImageBeforeText;// "Leyenda Adplanning";
            bt.Dock = DockStyle.Right;


            ContextMenuStrip menu = new ContextMenuStrip();

            menu.Items.Add("Hola", Utilities.Clases.Leyenda.Menu.GetImagen(Color.Red));

            bt.Menu = menu;

            this.Controls.Add(bt);
         **/
        public class MenuButton : Button
        {
            [DefaultValue(null)]
            public ContextMenuStrip Menu { get; set; }

            [DefaultValue(false)]
            public bool ShowMenuUnderCursor { get; set; }

            protected override void OnMouseDown(MouseEventArgs mevent)
            {
                base.OnMouseDown(mevent);

                if (Menu != null && mevent.Button == MouseButtons.Left)
                {
                    Point menuLocation;

                    if (ShowMenuUnderCursor)
                    {
                        menuLocation = mevent.Location;
                    }
                    else
                    {
                        menuLocation = new Point(0, Height);
                    }

                    Menu.Show(this, menuLocation);
                }
            }

            protected override void OnPaint(PaintEventArgs pevent)
            {
                base.OnPaint(pevent);

                if (Menu != null)
                {
                    int arrowX = ClientRectangle.Width - 14;
                    int arrowY = ClientRectangle.Height / 2 - 1;

                    Brush brush = Enabled ? SystemBrushes.ControlText : SystemBrushes.ButtonShadow;
                    Point[] arrows = new Point[] { new Point(arrowX, arrowY), new Point(arrowX + 7, arrowY), new Point(arrowX + 3, arrowY + 4) };
                    pevent.Graphics.FillPolygon(brush, arrows);
                }
            }

            
        }

        public static Bitmap GetImagen(Color color)
        {
            Bitmap Image = new Bitmap(16, 16);
            using (Graphics g = Graphics.FromImage(Image))
            {
                using (Brush b = new SolidBrush(color))
                {
                    g.DrawRectangle(Pens.White, 0, 0, Image.Width, Image.Height);
                    g.FillRectangle(b, 1, 1, Image.Width - 1, Image.Height - 1);
                }
            }
            return Image;
        }

    }
}
