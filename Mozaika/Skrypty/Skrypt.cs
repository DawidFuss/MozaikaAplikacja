using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mozaika_GUI
{
    public class Skrypt
    {

        public static void ChangeExtension(string extension)
        {
            DirectoryInfo f = new DirectoryInfo(extension);

            if (!f.Exists)
            {
                return;
            }

            var jpgFiles = f.GetFiles();
/*
            string test1 = jpgFiles.Length+" cos "+ f.Name;
            string test2 = string.Format("{0} cos {2}!",jpgFiles.Length,f.Name);
            string test3 = $"{jpgFiles.Length} cos {f.Name}!";
            string test4 = "enter: \n, tabulator: \t ukosnik \\";
            string test5 = @"F:\Korepetycje\Baza\Baza\Baza\bin\Release";
*/
            Directory.CreateDirectory(extension + @"/gotowe");

            foreach (var file in jpgFiles)
            {
                string destination = extension + @"\gotowe\" + file.Name;
                destination = destination.Replace(".jpg", ".png");
                File.Copy(file.FullName, destination);
            }
            
                //Path.GetExtension(file.Name) != "*.jpg")
                //ng newFileName = Path.ChangeExtension(files.FullName, "*.jpg");
            

        }

    }
}
