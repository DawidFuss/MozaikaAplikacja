using System;
using System.Collections.Generic;
using System.Drawing;

namespace Mozaika_GUI
{
    class Miniaturki
    {
        private Bitmap obraz;
        private Color color;
        public Bitmap Obraz { get { return obraz; } }   
        public Color Color { get { return color; } }
        
        public Miniaturki(string sciezka, int szerokosc, int wysokosc)

        {
            

            try
            {
           
                obraz = new Bitmap(Image.FromFile(sciezka), szerokosc, wysokosc);
                color = ObliczSredniKolorr();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Wystąpił błąd podczas wczytywania obrazu " + ex.Message);
                obraz = null;

            }

        }

        private Color ObliczSredniKolorr()
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
            int sredniRed = (int) ((double) sumaRed / iloscPikseli + 0.5);
            int sredniGreen = (int) ()sumaGreen / iloscPikseli;
            int sredniBluee = sumaBlue / iloscPikseli;
            return Color.FromArgb(sredniRed, sredniGreen, sumaBlue);
        }
    }
}
