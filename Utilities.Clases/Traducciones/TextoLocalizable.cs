using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;


namespace Utilities.Clases.Traducciones
{
    //[Designer(typeof(TextoLocalizableDesigner))]
    [DesignTimeVisible(false)]
    [ToolboxItem(false)]
    public partial class TextoLocalizable : Component
    {
        
        public TextoLocalizable()
        {
            InitializeComponent();
        }


        public TextoLocalizable(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }


        public string Key { get; set; }


        [Localizable(true), Browsable(true)]
        public string Texto { get; set; }
        
    }
}
