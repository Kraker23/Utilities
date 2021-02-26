using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities.Clases.UtilidadesInterfaz
{
    public class GestorRecursos
    {
        #region · Variables

        private bool autoSave = true;
        private bool allowSave = true;
        private bool needSave = false;

        private string fichero;
        private string defIdioma;

        /// <summary>
        /// Fichero donde se localizan los recursos
        /// </summary>
        public string Fichero
        {
            get { return fichero; }
            set
            {
                fichero = value;
                LoadFichero();
            }
        }


        private RecursoCollection resColl;


        /// <summary>
        /// Recursos cargados
        /// </summary>
        public List<Recurso> Recursos { get { return resColl.Recursos; } }


        /// <summary>
        /// Especifica si puede guardar los recursos de manera automática
        /// </summary>
        public bool AutoSave
        {
            get { return autoSave; }
            set { autoSave = value; }
        }


        /// <summary>
        /// Especifica si puede ejecutar el guardado de datos
        /// </summary>
        public bool AllowSave
        {
            get { return allowSave; }
            set { allowSave = value; }
        }


        /// <summary>
        /// Obtiene o establece el idioma por defecto para las búsquedas de recursos
        /// </summary>
        public string IdiomaDefault
        {
            get { return defIdioma; }
            set { defIdioma = value; }
        }

        #endregion


        #region · Contructores

        /// <summary>
        /// Gestor de recursos para el idioma por defecto
        /// </summary>
        /// <param name="IdiomaDefault">string: idioma por defecto para las busquedas</param>
        private GestorRecursos(string IdiomaDefault)
        {
            defIdioma = IdiomaDefault;
            fichero = "recursos.xml";
            resColl = new RecursoCollection();
            //recursos = new List<Recurso>();
        }


        /// <summary>
        /// Gestor de recursos
        /// </summary>
        /// <param name="IdiomaDefault">strihg: idioma por defecto para las busquedas</param>
        /// <param name="pathFichero">string: ruta del fichero</param>
        public GestorRecursos(string IdiomaDefault, string pathFichero)
        {
            defIdioma = IdiomaDefault;
            Fichero = pathFichero;
        }

        #endregion


        #region · Eventos



        #endregion


        #region · Funciones

        /// <summary>
        /// Carga el archivo de recursos
        /// </summary>
        private void LoadFichero()
        {
            if (File.Exists(fichero))
            {
                string xml = File.ReadAllText(fichero);

                resColl = (RecursoCollection)XML.SerializerXML.getObjectDeserialized(new RecursoCollection(), xml);

                if (resColl == null)
                {
                    resColl = new RecursoCollection();
                }
            }
            else
            {
                resColl = new RecursoCollection();
            }
        }


        /// <summary>
        /// Guarda los recursos en el fichero
        /// </summary>
        private void SaveData()
        {
            if (allowSave)
            {
                string xml = XML.SerializerXML.getObjectSerialized(resColl);
                int last = fichero.LastIndexOf(@"\");

                if (last > 0)
                {
                    string folder = fichero.Substring(0, last);

                    if (!Directory.Exists(folder)) { Directory.CreateDirectory(folder); }
                }

                File.WriteAllText(fichero, xml);
                needSave = false;
            }
            else
            {
                needSave = true;
            }
        }


        /// <summary>
        /// Guarda los cambios pendientes en el fichero
        /// </summary>
        public void SaveChanges()
        {
            if (needSave) { SaveData(); }
        }


        /// <summary>
        /// Guarda los recursos en un archivo diferente al propio
        /// </summary>
        /// <param name="pathFile">string: ruta del archivo</param>
        public void SaveChanges(string pathFile)
        {
            string xml = XML.SerializerXML.getObjectSerialized(resColl);
            File.WriteAllText(fichero, xml);
        }


        /// <summary>
        /// Recupera el texto del recurso para la key especificada o la key si no se encuentra el recurso
        /// </summary>
        /// <param name="key">string: clave del recuros</param>
        /// <returns></returns>
        public string GetText(string key)
        {
            return GetText(key, key, defIdioma);
        }


        /// <summary>
        /// Recupera el texto del recurso para la key especificada o la key si no se encuentra el recurso
        /// </summary>
        /// <param name="key">string: clave del recuros</param>
        /// <param name="defText">string</param>
        /// <returns>string</returns>
        public string GetText(string key, string defText)
        {
            return GetText(key, defText, defIdioma);
        }


        /// <summary>
        /// Recupera el texto del recurso para la key especificada o la key si no se encuentra el recurso
        /// </summary>
        /// <param name="key">string: clave del recuros</param>
        /// <param name="defText">string</param>
        /// <param name="idioma">string: idioma para recuperar el recurso</param>
        /// <returns>string</returns>
        public string GetText(string key, string defText, string idioma)
        {
            Recurso r = resColl.Recursos.Find(x => x.Key == key && x.Idioma == idioma);

            if (r == null)
            {
                resColl.Recursos.Add(new Recurso() { Idioma = idioma, Key = key, Texto = defText });

                // auto save data
                if (autoSave) { SaveData(); }

                return defText;
            }
            else
            {
                return r.Texto;
            }
        }

        #endregion
    }
}
