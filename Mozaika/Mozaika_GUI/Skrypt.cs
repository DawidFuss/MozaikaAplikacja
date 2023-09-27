using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mozaika_GUI
{
    internal class Skrypt
    {

        public void ChangeExtension(string extension)
        {
            DirectoryInfo f = new DirectoryInfo(extension);
            if (f.Exists)
            {

                 
                var jpgFiles = f.GetFiles("*jpg.", SearchOption.AllDirectories);
                foreach (var files in jpgFiles)
                {

                    if (Path.GetExtension(files.Name) != ".jpg")
                    {

                        string newFileName = Path.ChangeExtension(files.FullName, ".jpg");
                        File.Move(files.FullName, newFileName);

                    }

                }

            }
            else
            {
                return;
            }


        }

    }
}
