using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utilities.Clases.BuscarFicheros
{
    public static class BuscarArchivos
    {
        public static string[] SeleccionarArchivo(bool devolverRutaCompleta=true,
                                            string rutaBase= "c:\\",
                                            string filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*",
                                            int FilterIndex=2,
                                            bool multiSelect = true,
                                            bool ShowReadOnly = false)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = rutaBase;
                openFileDialog.Filter = filter;
                openFileDialog.FilterIndex = FilterIndex;
                openFileDialog.RestoreDirectory = true;
                openFileDialog.ShowReadOnly = ShowReadOnly;
                openFileDialog.Multiselect = multiSelect;
                //if (openFileDialog.ShowDialog() == DialogResult.OK)
                //{
                //    //Get the path of specified file
                //    // filePath = openFileDialog.FileName;//para un unico archivo
                //    //filePath = openFileDialog.FileNames.ToArray();
                    
                //}
                //else
                if (openFileDialog.ShowDialog() != DialogResult.OK)
                {
                    MessageBox.Show("Sin Seleccionar ningun archivo");
                    return null;
                }
                if (devolverRutaCompleta)
                {
                    var filePath = openFileDialog.FileNames.ToArray();

                    return filePath;
                }
                else
                {
                    var filePath = openFileDialog.SafeFileNames.ToArray();

                    return filePath;
                }
            }
        }


        public static string[] SeleccionarMultiCarpeta(string rutaBase = "c:\\", bool multiSelect=true,bool IsFolderPicker=true)
        {
            CommonOpenFileDialog openFolder = new CommonOpenFileDialog();
            openFolder.InitialDirectory = rutaBase;
            openFolder.AllowNonFileSystemItems = true;
            openFolder.Multiselect = multiSelect;
            openFolder.IsFolderPicker = IsFolderPicker;
            openFolder.Title = "Seleccion carpetas";

            if (openFolder.ShowDialog() != CommonFileDialogResult.Ok)
            {
                MessageBox.Show("Sin Seleccionar carpetas");
                //return;
            }

            // get all the directories in selected dirctory
            var dirs = openFolder.FileNames.ToArray();

            return dirs;
        }

        public static string SeleccionarCarpetaClassico()
        {
            string folderName = string.Empty;
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                DialogResult result = folderBrowserDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    folderName = folderBrowserDialog.SelectedPath;
                }
            }
            //MessageBox.Show(folderName, "File Content at path: " + folderName, MessageBoxButtons.OK);
            return folderName;
        }
    }
}
