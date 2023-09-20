using System;
using System.Collections.Generic;
using System.Drawing;

namespace Mozaika_GUI
{
    class Miniaturka
    {
        private Bitmap obraz;
        private Color sredniKolor;
        public Miniaturka(string sciezka, int szerokosc, int wysokosc)
        {
            try
            {
                obraz = new Bitmap(Image.FromFile(sciezka, szerokosc, wysokosc));
                sredniKolor = ObliczSredniKolor()
            }
            catch (Exception ex)
            {
                Console.WriteLine("Wystąpił błąd podczas wczytywania obrazu " + ex.Message);
                Obraz = null;
            }
        }


        public Bitmap Obraz { get { return obraz; } }

        public int Odleglosc(Color kolor)
        {
            int odlegloscRed = Math.Abs(sredniKolor.R - kolor.R);
            int odlegloscGreen = Math.Abs(sredniKolor.G - kolor.G);
            int odlegloscBlue = Math.Abs(sredniKolor.B - kolor.B);
            return Math.Max(Math.Max(odlegloscRed, odlegloscGreen), odlegloscBlue);
        }

        private Color ObliczSredniKolor()
        {
            if (obraz == null)
            {
                return Color.Empty;
            }

            int sumaRed = 0;
            int sumaGreen = 0;
            int sumaBlue = 0;
            for (int i = 0; i < obraz.Width; i++)
            {
                for(int j = 0; j < obraz.Height; j++)
                {
                    Color color = obraz.GetPixel(i,j);
                    sumaRed += color.R;
                    sumaGreen += color.G;
                    sumaBlue += color.B;
                }
            }

            int iloscPikseli = obraz.Width * obraz.Height;
            int sredniRed = (int)(((double)sumaRed / iloscPikseli)+0.5);
            int sredniGreen = (int)(((double)sumaGreen / iloscPikseli) + 0.5);
            int sredniBluee = (int)(((double)sumaBlue / iloscPikseli) + 0.5);
            return Color.FromArgb(sredniRed, sredniGreen, sumaBlue);
        }
    }
}
