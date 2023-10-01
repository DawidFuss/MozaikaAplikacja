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
        private List<Miniaturka> listaMiniaturek;
        public ListaMiniaturek() { 
            listaMiniaturek = new List<Miniaturka>();     
        }

        public void Wczytaj(string sciezka)
        {
            try
            {
                DirectoryInfo folder = new DirectoryInfo(sciezka);
                if (!folder.Exists)
                {
                    return;
                }

                string[] rozszezenia = new string[] { "*.jpg", "*.png", "*.bmp" };

                foreach (string rozszezenie in rozszezenia)
                {
                    var images = folder.GetFiles(rozszezenie, SearchOption.AllDirectories);
                    foreach (var image in images)
                    {
                        listaMiniaturek.Add(new Miniaturka(image.FullName, 80, 60));
                    }
                }




                /*
                if (folder.Exists && (folder.GetFiles("*.jpg", SearchOption.AllDirectories).Length > 0
                    || folder.GetFiles("*.png", SearchOption.AllDirectories).Length > 0))
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
                        Wczytaj(d.FullName);
                    }
                }
                else
                {
                    Console.WriteLine("Folder nie istnieje lub nie zawiera plików");
                }*/
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Wystąpił błąd: {ex.Message}");
            }

        }

        public Miniaturka WybierzMiniaturke(Color kolor)
        {
            Miniaturka wybranaMiniaturka = null;
            int najmniejszaOdleglosc = int.MaxValue;

            foreach (Miniaturka miniatura in listaMiniaturek)
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
