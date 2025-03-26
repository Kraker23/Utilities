using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UtilitiesNet.Controls.GroupBoxPerso
{
    public partial class cGroupBoxExpandable : UserControl
    {

        int height = 200;
        int width = 0;

        public cGroupBoxExpandable()
        {
            InitializeComponent();
            chk.Text = "Activar";
        }

        public cGroupBoxExpandable(string NombreChek="Activar")
        {
            InitializeComponent();
            chk.Text = NombreChek;
        }

        private void cGroupBoxExpandable_Load(object sender, EventArgs e)
        {
            ManageExpandableLoad();

            ManageCheckGroupBox(chk, group);
        }

        private void ManageExpandableLoad()
        {
            panel1.Height = btExpandable.Height;
            btExpandable.Text = "-";
            if (panel1.Dock == DockStyle.Fill)
            {
                width = panel1.Width;
                height = panel1.Height;
                panel1.Dock = DockStyle.None;
                panel1.Width = width;
                panel1.Height = height;
            }
        }

        private void ManageCheckGroupBox(CheckBox chk, GroupBox grp)
        {
            // Make sure the CheckBox isn't in the GroupBox.
            // This will only happen the first time.
            if (chk.Parent == grp)
            {
                // Reparent the CheckBox so it's not in the GroupBox.
                grp.Parent.Controls.Add(chk);

                // Adjust the CheckBox's location.
                chk.Location = new Point(
                    chk.Left + grp.Left,
                    chk.Top + grp.Top);

                // Move the CheckBox to the top of the stacking order.
                chk.BringToFront();
            }

            // Enable or disable the GroupBox.
            //grp.Enabled = chk.Checked;//Habilitar todo/Nada, pero esto tambien deshabilita el boton Expandible y con el foreach eso lo excluyo
            foreach (Control c in grp.Controls)
            {
                if (c.Tag != "btExpandable")
                {
                    c.Enabled = chk.Checked;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (panel1.Height == height)
            {
                panel1.Height = btExpandable.Height;
                btExpandable.Text = "+";
            }
            else
            {
                panel1.Height = height;// Convert.ToInt32(panel1.Tag.ToString());
                btExpandable.Text = "-";
            }
        }

        private void panel1_SizeChanged(object sender, EventArgs e)
        {
            if (panel1.Height > btExpandable.Height)
            {
                height = panel1.Height;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            ManageCheckGroupBox(chk, group);
        }

        private void group_SizeChanged(object sender, EventArgs e)
        {

        }

        public void GroupFill()
        {
            group.Dock = DockStyle.Fill;
            panel1.Dock = DockStyle.Fill;
        }

        private void group_DockChanged(object sender, EventArgs e)
        {
            group.Dock = DockStyle.Fill;
            panel1.Dock = DockStyle.Fill;
        }
    }
}
