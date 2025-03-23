using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Utilities.AppTraza
{

    /// <summary>
    /// Apariencia de una traza
    /// </summary>
    public class TrazaApariencia
    {
        private Color foreColor = Color.Empty;
        private Color backColor = Color.Empty;
        private int? imageIndex = null;


        /// <summary> Color de fondo </summary>
        public Color BackColor
        {
            get { return backColor; }
            set { backColor = value; }
        }


        /// <summary> Color de la letra </summary>
        public Color ForeColor
        {
            get { return foreColor; }
            set { foreColor = value; }
        }


        /// <summary> Index de la imagen para el nodo de la traza </summary>
        public int? ImageIndex
        {
            get { return imageIndex; }
            set { imageIndex = value; }
        }

    }


    /// <summary> Conjunto de apariencias para los diferentes tipos de trazas </summary>
    public class VieweTrazaApariencias
    {
        // Apariencia
        internal ImageList tappImgList = null;
        internal TrazaApariencia tappAplicacion = new TrazaApariencia();
        internal TrazaApariencia tappFuncion = new TrazaApariencia();
        internal TrazaApariencia tappLinea = new TrazaApariencia();
        internal TrazaApariencia tappMensaje = new TrazaApariencia();
        internal TrazaApariencia tappError = new TrazaApariencia();
        internal TrazaApariencia tappWebService = new TrazaApariencia();
        internal TrazaApariencia tappSql = new TrazaApariencia();


        #region · Propiedades

            /// <summary> ImageList para las imagenes de los nodos </summary>
            public ImageList ViewerImgList
            {
                get { return tappImgList; }
                set { tappImgList = value; }
            }


            /// <summary> Apariencia para la traza de tipo Aplicación </summary>
            public TrazaApariencia ViewerTrazaAplicacion
            {
                get { return tappAplicacion; }
            }


            /// <summary> Apariencia para la traza de tipo Funcion </summary>
            public TrazaApariencia ViewerTrazaFuncion
            {
                get { return tappFuncion; }
            }


            /// <summary> Apariencia para la traza de tipo Linea </summary>
            public TrazaApariencia ViewerTrazaLinea
            {
                get { return tappLinea; }
            }


            /// <summary> Apariencia para la traza de tipo Mensaje </summary>
            public TrazaApariencia ViewerTrazaMensaje
            {
                get { return tappMensaje; }
            }


            /// <summary> Apariencia para la traza de tipo Error </summary>
            public TrazaApariencia ViewerTrazaError
            {
                get { return tappError; }
            }


            /// <summary> Apariencia para la traza de tipo WebService </summary>
            public TrazaApariencia ViewerTrazaWebService
            {
                get { return tappWebService; }
            }


            /// <summary>Apariencia para la traza de tipo SQL  </summary>
            public TrazaApariencia ViewerTrazaSql
            {
                get { return tappSql; }
            }

        #endregion

    }

}
