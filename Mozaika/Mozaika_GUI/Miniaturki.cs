using System;
using System.Collections.Generic;
using System.Drawing;

namespace Mozaika_GUI
{
    class Miniaturki
    {
        public Image Obraz;
        public static List <Image> listaObrazkow = new List<Image> ();
        public Miniaturki(string sciezka, int szerokosc, int wysokosc)

        {

            try
            {
                Obraz = Image.FromFile(sciezka);
                Obraz = skalujObraz(Obraz, szerokosc, wysokosc);
                listaObrazkow.Add (Obraz);
               

            }
            catch (Exception ex)
            {
                Console.WriteLine("Wystąpił błąd podczas wczytywania obrazu " + ex.Message);
                Obraz = null;

            }

        }

        private Image skalujObraz(Image obrazek, int szerokosc, int wysokosc)
        {
            if (obrazek == null)
            {
                return null;
            }

            Bitmap przeskalowanyObraz = new Bitmap(szerokosc, wysokosc);

            using (Graphics g = Graphics.FromImage(przeskalowanyObraz))
            {

                g.DrawImage(obrazek, 0, 0, szerokosc, wysokosc);
            }

            return przeskalowanyObraz;

        }

        private Color obliczSredniKolor(Image obraz)
        {
            if (obraz == null)
            {
                return Color.Empty;
            }

            Bitmap bitmap = new Bitmap(obraz);
            int sumaRed = 0;
            int sumaGreen = 0;
            int sumaBlue = 0;
            for (int i = 0; i < obraz.Width; i++)
            {
                for(int j = 0; j < obraz.Height; j++)
                {
                    Color color = bitmap.GetPixel(i,j);
                    sumaRed += color.R;
                    sumaGreen += color.G;
                    sumaBlue += color.B;

                }

            }

            int iloscPikseli = obraz.Width * obraz.Height;
            int sredniRed = sumaRed / iloscPikseli;
            int sredniGreen = sumaGreen / iloscPikseli;
            int sredniBluee = sumaBlue / iloscPikseli;
            return Color.FromArgb(sredniRed, sredniGreen, sumaBlue);
        }
    }
}
