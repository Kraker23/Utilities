using Utilities.Clases.MergeObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace Utilities.Controls.MergeObjects
{
    public partial class frmMergeObjects : Form
    {
        IObjectMerger objectMerger;
        private List<PropMerge> propMerges;
        public object objResultado { get => objectMerger.MergeObjects(); }

        public frmMergeObjects(string nombreObjetoX, string nombreObjetoY)
        {
            InitializeComponent();
            cPropertyName.txtX.Text = nombreObjetoX;
            cPropertyName.txtY.Text = nombreObjetoY;

            Type tipo = typeof(string);
            PropertyInfo prop = tipo.GetProperties().First();
            PropMerge propMergeAux = new PropMerge(prop, nombreObjetoX, nombreObjetoY);

            cPropertyName.setProperty(propMergeAux);
        }

        public void MergeObjects<T>(T x, T y) where T : new()
        {
            if (x == null)
                throw new NullReferenceException("El objeto X es nulo");
            if (y == null)
                throw new NullReferenceException("El objeto Y es nulo");

            objectMerger = new ObjectMerger<T>(x, y);
            
            propMerges = objectMerger.Compare();
            CrearControlesComparador();
        }
        public void MergeObjects<T>(T x, T y, MergeOptions mergeOptions) where T : new()
        {
            objectMerger.mergeOptions = mergeOptions;
            MergeObjects(x, y);
        }

        private void CrearControlesComparador()
        {
            foreach (PropMerge prop in propMerges)
            {
                if (prop.Equals())
                {
                    AddSamePropiety(prop);
                }
                else
                {
                    AddDiferentPropiety(prop);
                }
            }
        }

        private void AddDiferentPropiety(PropMerge prop)
        {
            cProperty cAux = new cProperty(prop);
            cAux.Dock = DockStyle.Top;
            pDiferents.Controls.Add(cAux);
        }


        private void AddSamePropiety(PropMerge prop)
        {
            cProperty cAux = new cProperty(prop);
            cAux.Enabled = false;
            cAux.Dock = DockStyle.Top;
            pSame.Controls.Add(cAux);
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            bool ok = true;
            foreach (cProperty cProp in pDiferents.Controls.Find("cProperty", false))
            {
                if (cProp.propMerge.Selection == PropMergeSelection.None)
                {
                    cProp.Marcar();
                    ok = false;
                }
            }

            if (ok)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();

        }

        private void cProperty1_Load(object sender, EventArgs e)
        {

        }

        private void cPropertyName_CheckXEvento()
        {
            foreach (cProperty cProp in pDiferents.Controls.Find("cProperty", false))
            {
                cProp.ActualizarCheck(PropMergeSelection.X);
            }
        }

        private void cPropertyName_CheckYEvento()
        {
            foreach (cProperty cProp in pDiferents.Controls.Find("cProperty", false))
            {
                cProp.ActualizarCheck(PropMergeSelection.Y);
            }
        }
    }
}
