using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utilities.Clases.MessageBoxPerso
{
    public class uMessageBox
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="text">string</param>
        public static void ShowAlert(string text, string title = "Atención")
        {
            System.Windows.Forms.MessageBox.Show(text, title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public static void ShowError(string text, string title = "Error")
        {
            System.Windows.Forms.MessageBox.Show(text, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ShowInfo(string text, string title = "Información")
        {
            System.Windows.Forms.MessageBox.Show(text, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
