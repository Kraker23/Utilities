using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UtilitiesNet.Controls.ComboBoxCustom
{
    /*
     * 
                cbLeyenda.Items.Add(new ComboBoxItem("texto","valor", Color.Red));
                /
     */


    public class ComboBoxCustom : ComboBox
    {
        public ComboBoxCustom()
        {
            this.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            base.OnDrawItem(e);
            e.DrawBackground();
            ComboBoxItem item = (ComboBoxItem)this.Items[e.Index];
            //Brush brush = new SolidBrush(item.ForeColor);
            //Esto seria para poder configurar el color de los cuadraditos al lado del texto ( el texto va en negro mas abajo se ve)
            Brush brush;
            switch (item.Value.ToString())
            {
                case "1":// "Sin Enviar":
                    brush = Brushes.Gray;
                    break;
                case "2":// "Esperando Recepcion":
                    brush = Brushes.OrangeRed;
                    break;
                case "3"://"Enviado":
                    brush = Brushes.Green;
                    break;
                case "4"://"Enviado con Errores":
                    brush = Brushes.Yellow;
                    break;
                case "5"://"Enviado a MBS":
                    brush = Brushes.Purple;
                    break;
                case "6"://"Adjudicado":
                    brush = Brushes.Blue;
                    break;
                case "7"://"Anulada Adjudicacion":
                    brush = Brushes.Orange;
                    break;
                case "8"://"Cerrado":
                    //e.Appearance.BackColor = Color.Green;
                    brush = Brushes.Coral;
                    break;
                default:
                    brush = Brushes.Black;
                    break;
            }

            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            { brush = Brushes.Yellow; }
            //e.Graphics.DrawString(item.Text, this.Font, System.Drawing.Brushes.Black, e.Bounds.X, e.Bounds.Y);
            float size = 0;
            System.Drawing.Font myFont;
            FontFamily family = null;

            System.Drawing.Color animalColor = new System.Drawing.Color();

            animalColor = System.Drawing.Color.Red;
            family = FontFamily.GenericSansSerif;
            size = 8;
            // Create a square filled with the animals color. Vary the size
            // of the rectangle based on the length of the animals name.
            Rectangle rectangle = new Rectangle(2, e.Bounds.Top + 2,
                    e.Bounds.Height, e.Bounds.Height - 4);
            e.Graphics.FillRectangle(brush, rectangle);

            // Draw each string in the array, using a different size, color,
            // and font for each item.
            myFont = new Font(family, size, FontStyle.Regular);
            e.Graphics.DrawString(item.Text, myFont, System.Drawing.Brushes.Black, new RectangleF(e.Bounds.X + rectangle.Width, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));

        }
    }

    public class ComboBoxItem
    {
        public ComboBoxItem() { }

        public ComboBoxItem(string pText, object pValue)
        {
            text = pText; val = pValue;
        }

        public ComboBoxItem(string pText, object pValue, Color pColor)
        {
            text = pText; val = pValue; foreColor = pColor;
        }

        string text = "";
        public string Text
        {
            get { return text; }
            set { text = value; }
        }

        object val;
        public object Value
        {
            get { return val; }
            set { val = value; }
        }

        Color foreColor = Color.Black;
        public Color ForeColor
        {
            get { return foreColor; }
            set { foreColor = value; }
        }

        public override string ToString()
        {
            return text;
        }
    }
}
