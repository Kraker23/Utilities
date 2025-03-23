using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities.Funciones
{
    public class FileRename
    {
        public static void RenameFilesInFolderWithDatateTime(string folder, string stringFormat = "yyyyMMdd_HHmmss")
        {
            foreach (string file in System.IO.Directory.GetFiles(folder, "*", System.IO.SearchOption.AllDirectories))
            {
                RenameFileWithDatateTime(file, stringFormat);
            }
        }

        public static void RenameFileWithDatateTime(string file, string stringFormat = "yyyyMMdd_HHmmss")
        {
            if (System.IO.File.Exists(file))
            {
                DateTime creatTime = System.IO.File.GetLastWriteTime(file);
                string ext = System.IO.Path.GetExtension(file);
                string folder = System.IO.Path.GetDirectoryName(file);
                string newFile = folder + @"\" + creatTime.ToString(stringFormat) + ext;
                int rep = 1;

                while (System.IO.File.Exists(newFile))
                {
                    rep++;
                    newFile = folder + @"\" + creatTime.ToString(stringFormat) + "_" + rep + ext;
                }

                System.IO.File.Move(file, newFile);
            }
        }
    }
}
