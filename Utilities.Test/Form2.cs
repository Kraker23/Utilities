using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities.Controls.HerramientaTextos;
using Utilities.Controls.IntroducirTexto;

namespace Utilities.Test
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //SeparadorTexto st = new SeparadorTexto();
            //st.Dock = DockStyle.Fill;
            ////this.Controls.Add(st);

            cEncriptarDesencriptarTexto st = new cEncriptarDesencriptarTexto();
            st.Dock = DockStyle.Fill;
            this.Controls.Add(st);
        }
    }
}
