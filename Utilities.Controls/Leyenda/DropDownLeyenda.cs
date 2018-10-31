using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Drawing;

namespace Utilities.Controls.Leyenda
{
    public class DropDownLeyenda
    {
        /*
        Ejemplo :

         LeyendaDropDown sel = new LeyendaDropDown(new Point(250, 15));
            
            //los items que tendra el dropdown

            DropDownItem item = new DropDownItem("hola",Color.Red);
            DropDownItem item2 = new DropDownItem("r",Color.Green);
            DropDownItem item3 = new DropDownItem("d",Color.Yellow);
            DropDownItem item4 = new DropDownItem("v",Color.Blue);
            DropDownItem item5 = new DropDownItem("j",Color.Orange);
                       
            //añadir los items al dropdown
            sel.Items.Add(item);
            sel.Items.Add(item2);
            sel.Items.Add(item3);
            sel.Items.Add(item4);
            sel.Items.Add(item5);

            //Donde se quiere añadir el control
            this.Controls.Add(sel);
             */

        public sealed class LeyendaDropDown : ComboBox
        {
            public LeyendaDropDown()
            {
                DrawMode = DrawMode.OwnerDrawFixed;
                DropDownStyle = ComboBoxStyle.DropDownList;
            }

            public LeyendaDropDown(Point sitio)
            {
                this.Location = sitio;
                DrawMode = DrawMode.OwnerDrawFixed;
                DropDownStyle = ComboBoxStyle.DropDownList;
            }

            public void setLocation(Point sitio)
            {
                this.Location = sitio;
            }

            public void AgregarListaItems(List<DropDownItem> lista)
            {
                for (int i = 0; i < lista.Count(); i++)
                {
                    this.Items.Add(lista[i]);
                }
            }

            protected override void OnDrawItem(DrawItemEventArgs e)
            {
                e.DrawBackground();

                e.DrawFocusRectangle();

                if (e.Index >= 0 && e.Index < Items.Count)
                {
                    DropDownItem item = (DropDownItem)Items[e.Index];

                    e.Graphics.DrawImage(item.Image, e.Bounds.Left, e.Bounds.Top);

                    e.Graphics.DrawString(item.Value, e.Font, new SolidBrush(e.ForeColor), e.Bounds.Left + item.Image.Width, e.Bounds.Top + 2);
                }

                base.OnDrawItem(e);
            }
        }

        public sealed class DropDownItem
        {
            public string Value { get; set; }

            public Image Image { get; set; }

            public DropDownItem()
                : this("", Color.Empty)
            { }

            public DropDownItem(string val, Color color)
            {
                Value = val;
                Image = new Bitmap(16, 16);
                using (Graphics g = Graphics.FromImage(Image))
                {
                    using (Brush b = new SolidBrush(color))
                    {
                        g.DrawRectangle(Pens.White, 0, 0, Image.Width, Image.Height);
                        g.FillRectangle(b, 1, 1, Image.Width - 1, Image.Height - 1);
                    }
                }
            }

            public override string ToString()
            {
                return Value;
            }
        }
    }
}
