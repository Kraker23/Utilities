using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Utilities.Controls.HerramientaTextos
{
    /// <summary>Formulario de Buscar y remplazar  </summary>
    public partial class frmBuscarRemplazar : Form
    {
        /// <summary>Funcion que te devuelve el valor del texto a buscar </summary>
        public string TextoBuscar { get { return txtBuscar.Text; } }

        /// <summary>Funcion que te devuelve el valor del texto a remplazar </summary>
        public string TextoRemplazar { get { return txtRemplazar.Text; } }
        
        /// <summary>Evento creado para comunicarse ente Formularios y pasar informacion </summary>
        public event EventHandler BuscarRemplazar;


        public frmBuscarRemplazar()
        {
            InitializeComponent();
        }

        /// <summary>Evento al pulsar el boton "Remplazar Todo", que ejecuta el evento si alguien esta subscrito </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btRemplazarTodo_Click(object sender, EventArgs e)
        {
            if (BuscarRemplazar != null)
            {
                BuscarRemplazar(this, EventArgs.Empty);
            }
        }

    }
}
