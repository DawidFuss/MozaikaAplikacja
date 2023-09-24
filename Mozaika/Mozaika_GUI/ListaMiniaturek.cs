using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mozaika_GUI
   
{
    internal class ListaMiniaturek
    {
        private List<Miniaturki> Lista_Miniaturek;
        public ListaMiniaturek() { 
            Lista_Miniaturek = new List<Miniaturki>();
       
        }
        
        void WczytajMiniaturke (string sciezka) {
            try
            {
                DirectoryInfo folder = new DirectoryInfo(sciezka);
                if (folder.Exists && (folder.GetFiles("*.jpg", SearchOption.TopDirectoryOnly).Length > 0 || folder.GetFiles("*.png", SearchOption.TopDirectoryOnly).Length > 0))
                {

                    List<FileInfo> listaPlikow = new List<FileInfo>();
                    var pliki = folder.GetFiles();
                    foreach (FileInfo fi in pliki)
                    {
                        listaPlikow.Add(fi);

                    }

                    List<DirectoryInfo> foldery = new List<DirectoryInfo>();
                    var fold = folder.GetDirectories();
                    foreach (DirectoryInfo d in fold)
                    {
                        WczytajMiniaturke(d.FullName);
                    }
                }
                else
                {
                    Console.WriteLine("Folder nie istnieje lub nie zawiera plików");
                }
            }
            catch(Exception ex) 
            {
                Console.WriteLine($"Wystąpił błąd: {ex.Message}");
            }

        }

        public Miniaturki WybierzMiniaturke(Color kolor)
        {
            Miniaturki wybranaMiniaturka = null;
            int najmniejszaOdleglosc = int.MaxValue;

            foreach (Miniaturki miniatura in Lista_Miniaturek)
            {
                int odleglosc = miniatura.Odleglosc(kolor);
                if (odleglosc < najmniejszaOdleglosc)
                {
                    najmniejszaOdleglosc = odleglosc;
                    wybranaMiniaturka = miniatura;
                }
            }

            return wybranaMiniaturka;
        }






    }
}
