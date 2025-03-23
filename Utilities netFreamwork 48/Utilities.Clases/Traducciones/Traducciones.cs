using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Utilities.Clases.Traducciones
{

    /// <summary>
    /// Componente para la traducción de textos
    /// </summary>
    public partial class Traducciones : Component
    {

        public Traducciones()
        {
            //Textos = new Dictionary<string, string>();
            InitializeComponent();

            Textos = new TextoLocalizable[] { };
        }


        public Traducciones(IContainer container)
        {
            //Textos = new Dictionary<string, string>();
            container.Add(this);

            InitializeComponent();

            Textos = new TextoLocalizable[] {};
        }


        /// <summary>
        /// Listado de textos
        /// </summary>
        [Browsable(true)]
        public TextoLocalizable[] Textos { get; set; }


        public override string ToString()
        {
            return Textos.Count().ToString();
        }


        /*[Localizable(true)]
        public class TextoLocalizable
        {
            [Browsable(true)]
            public string Key { get; set; }

            [Browsable(true)]
            [Localizable(true)]
            public string Text { get; set; }

            public override string ToString()
            {
                return string.Format("{0}; {1}",Key,Text);
            }
        }*/


        /// <summary>
        /// Obtiene el texto asociado a la key, o null si no se encuentra la key
        /// </summary>
        /// <param name="key">string</param>
        /// <returns>string</returns>
        public string GetTextForKey(string key)
        {
            TextoLocalizable txt = Textos.Where(x => x.Key == key).FirstOrDefault();

            if (txt != null)
            {
                return null;
            }
            else
            {
                return txt.Texto;
            }
        }

    }
}
