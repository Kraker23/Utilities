using UtilitiesNet.Objetos.MergeObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace UtilitiesNet.Controls.MergeObjects
{
    public partial class cProperty : UserControl
    {

        public delegate void CheckEvento(); 
        public event CheckEvento CheckXEvento;
        public event CheckEvento CheckYEvento;


        private bool gestionarChecks { get; set; }
                
        [DefaultValue(typeof(PropMerge))]
        public PropMerge propMerge { get; set; }
        public enum MarcaColor
        {
            Default,
            Correct,
            Warning,
            Error
        }


        public cProperty()
        {
            InitializeComponent();
        }

        public cProperty(PropMerge propMerge):this()
        {
            setProperty( propMerge);
        }

        public void setProperty(PropMerge propMerge )
        {
            this.propMerge = propMerge;
            
            lblNombre.Text = propMerge.PropertyInfo.Name;
            txtX.Text = propMerge.ValueX?.ToString();
            txtY.Text = propMerge.ValueY?.ToString();

            if (propMerge.Selection == PropMergeSelection.X)
            {
                chkX.Checked = true;
            }
            else if (propMerge.Selection == PropMergeSelection.Y)
            {
                chkY.Checked = true;
            }

            
            if (propMerge.Equals())
            {
                Marcar(MarcaColor.Correct);
            }
            else
            {
                Marcar(MarcaColor.Default);
            }
        }

        private void chkX_CheckedChanged(object sender, EventArgs e)
        {
            if (!gestionarChecks)
            {
                ActualizarCheck(PropMergeSelection.X);
                CheckXEvento?.Invoke();
            }
        }

        private void chkY_CheckedChanged(object sender, EventArgs e)
        {
            if (!gestionarChecks)
            {               
                ActualizarCheck(PropMergeSelection.Y);
                CheckYEvento?.Invoke();
            }
        }

        public void ActualizarCheck(PropMergeSelection selection)
        {
            if (!gestionarChecks)
            {
                propMerge.Selection = selection;
                gestionarChecks = true;
                if (propMerge.Selection == PropMergeSelection.X)
                {
                    chkX.Checked = true;
                    chkY.Checked = false;
                }
                else if (propMerge.Selection == PropMergeSelection.Y)
                {
                    chkX.Checked = false;
                    chkY.Checked = true;
                }
                MarcarSelecion();
                gestionarChecks = false;
            }
        }

        public void Marcar(bool Error = true)
        {
            if (Error)
            {
                Marcar(MarcaColor.Error);
            }
        }
        private void Marcar(MarcaColor marcaColor)
        {
            this.BackColor = getColorBackground(marcaColor);
        }

        private void MarcarSelecion()
        {
            if (chkX.Checked)
            {
                this.scX.BackColor = getColorBackground(MarcaColor.Correct);
                this.scY.BackColor = getColorBackground(MarcaColor.Default);
                this.BackColor = getColorBackground(MarcaColor.Default);
            }
            else if (chkY.Checked)
            {
                this.scX.BackColor = getColorBackground(MarcaColor.Default);
                this.scY.BackColor = getColorBackground(MarcaColor.Correct);
                this.BackColor = getColorBackground(MarcaColor.Default);
            }
            else
            {
                this.scX.BackColor = getColorBackground(MarcaColor.Default);
                this.scY.BackColor = getColorBackground(MarcaColor.Default);
                this.BackColor = getColorBackground(MarcaColor.Default);
            }

        }
        private Color getColorBackground(MarcaColor marcaColor)
        {
            switch (marcaColor)
            {
                case MarcaColor.Default:
                    return System.Drawing.SystemColors.Control;
                    break;
                case MarcaColor.Warning:
                    return System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
                    break;
                case MarcaColor.Correct:
                    return System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
                    break;
                case MarcaColor.Error:
                    return System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
                    break;
                default:
                    return System.Drawing.SystemColors.Control;
                    break;
            }
        }
    }
}
