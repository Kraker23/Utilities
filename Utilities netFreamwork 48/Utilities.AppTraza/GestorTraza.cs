using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Utilities.AppTraza
{
    /// <summary> Clase encargada de la gestion de las traza </summary>
    public class GestorTraza
    {

        #region · Variables

            private bool activo;
            private List<Traza> trazas;
            private TrazaViwer viewer;
            private int lastIdTraza;
            private VieweTrazaApariencias apariencias;

        #endregion


        #region · Propiedades

            /// <summary> Indica si el registro de las trazas esta activo y estas se almacenan en la colección global </summary>
            public bool Activo
            {
                get { return activo; }
            }


            /// <summary> Listado de traza global </summary>
            public List<Traza> Trazas
            {
                get { return trazas; }
            }


            /// <summary> Apariencia para los diferentes tipos de traza </summary>
            public VieweTrazaApariencias Apariencias
            {
                get { return apariencias; }
            }

        #endregion
        

        #region · Constructores

            /// <summary> Creación de la traza </summary>
            public GestorTraza()
            {
                lastIdTraza = 0;
                activo = false;
                trazas = new List<Traza>();
                viewer = null;

                apariencias = new VieweTrazaApariencias();
            }

        #endregion


        #region · Eventos trazas

            internal delegate void AddTrazaHandler(Traza sender,Traza parent);
            internal event AddTrazaHandler AnyadirTraza;


            internal delegate void CambioEnTrazaHandler(Traza sender);
            internal event CambioEnTrazaHandler CambioEnTraza;


            /// <summary> Función que lanza el evento RegreshTraza del objeto TrazaViewer </summary>
            private void traza_CambioEnTraza(Traza sender)
            {
                if(viewer != null)
                {
                    if (!viewer.IsDisposed) { viewer.RefreshTraza(sender); }
                }
            }

        #endregion


        #region · Funciones

            /// <summary> Activa el registro de las trazas </summary>
            public void Activar()
            {
                activo = true;

                if (viewer != null)
                {
                    if (!viewer.IsDisposed)
                    {
                        viewer.RefreshActiveState();
                    }
                }
            }


            /// <summary> Desactiva el registro de las trazas </summary>
            public void Desactivar()
            {
                activo = false;

                if (viewer != null)
                {
                    if (!viewer.IsDisposed)
                    {
                        viewer.RefreshActiveState();
                    }
                }
            }


            /// <summary> Muestra el formulario donde se muestran las trazas </summary>
            public void ShowViewer(bool dialog)
            {
                if (viewer != null)
                {
                    if (viewer.IsDisposed)
                    {
                        viewer = new TrazaViwer(this);

                        if (dialog) { viewer.ShowDialog(); }
                        else { viewer.Show(); }
                    }
                    else
                    {
                        viewer.Visible = true;
                        viewer.BringToFront();
                    }
                }
                else
                {
                    viewer = new TrazaViwer(this);

                    if (dialog) { viewer.ShowDialog(); }
                    else { viewer.Show(); }
                }
            }


            /// <summary> Agrega una traza a la colección </summary>
            /// <param name="traza">Traza a añadir</param>
            /// <returns>Traza</returns>
            public Traza AddTraza(Traza traza)
            {
                if (activo)
                {
                    if (!trazas.Contains(traza))
                    {
                        lastIdTraza++;

                        traza.idTraza = lastIdTraza;
                        traza.CambioEnTraza += traza_CambioEnTraza;

                        trazas.Add(traza);

                        traza_CambioEnTraza(traza);
                        //return traza;
                    }                    
                }

                return traza;
            }


            /// <summary> Agrega una traza a la colección </summary>
            /// <param name="tipo">Tipo de traza a agregar</param>
            /// <param name="mensaje">Texto de la traza</param>
            /// <returns>Traza</returns>
            public Traza AddTraza(TipoTraza tipo, string mensaje)
            {
                return AddTraza(new Traza(tipo, mensaje));
            }


            /// <summary> Agrega una traza a la colección dentro de otra </summary>
            /// <param name="traza">Traza a añadir</param>
            /// <param name="trazaPadre">Traza padre donde añadir la traza</param>
            /// <returns>Traza</returns>
            public Traza AddTraza(Traza traza, Traza trazaPadre)
            {
                if (activo)
                {
                    if (!trazas.Contains(traza))
                    {
                        trazaPadre.subTrazas.Add(traza);
                        traza.trazaPadre = trazaPadre;

                        traza = AddTraza(traza);
                        //return traza;
                    }
                }

                return traza;
            }


            /// <summary> Agrega una traza a la colección dentro de otra </summary>
            /// <param name="tipo">Tipo de traza a agregar</param>
            /// <param name="mensaje">Texto de la traza</param>
            /// <param name="trazaPadre">Traza padre donde añadir la traza</param>
            /// <returns>Traza</returns>
            public Traza AddTraza(TipoTraza tipo, string mensaje, Traza trazaPadre)
            {
                return AddTraza(new Traza(tipo, mensaje), trazaPadre);
            }


            /// <summary> Limpia la colección de las trazas </summary>
            public void LimpiarTraza()
            {
                trazas.Clear();
            }

        #endregion

    }
}
