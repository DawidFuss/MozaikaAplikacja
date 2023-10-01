using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mozaika_GUI
{
    internal class FragmentObrazu
    {
        private Bitmap obraz;
        private int szerokosc;
        private int wysokosc;
        private int poczatekX;
        private int poczatekY;

        public FragmentObrazu(Bitmap obraz, int szerokosc, int wysokosc, int poczatekX, int poczatekY)
        {
            this.obraz = obraz;
            this.szerokosc = szerokosc;
            this.wysokosc = wysokosc;
            this.poczatekX = poczatekX;
            this.poczatekY = poczatekY;
        }

        public Color SredniKolor
        {
            get
            {
                if (obraz == null)
                {
                    return Color.Empty;
                }

                int sumaRed = 0;
                int sumaGreen = 0;
                int sumaBlue = 0;
                for (int y = 0; y < wysokosc; y++)
                {
                    for (int x = 0; x < szerokosc; x++)
                    {
                        Color pixelColor = obraz.GetPixel(poczatekX + x, poczatekY + y);
                        sumaRed += pixelColor.R;
                        sumaGreen += pixelColor.G;
                        sumaBlue += pixelColor.B;
                    }
                }

                int iloscPikseli = wysokosc*szerokosc;
                int sredniRed = (int)((double)sumaRed / iloscPikseli + 0.5);
                int sredniGreen = (int)((double)sumaGreen / iloscPikseli + 0.5);
                int sredniBlue = (int)((double)sumaBlue / iloscPikseli + 0.5);

                return Color.FromArgb(sredniRed, sredniGreen, sredniBlue);
            }
        }

        public Bitmap Fragment
        {
            set
            {
                if(wysokosc!=value.Height || szerokosc!=value.Width)
                {
                    throw new Exception("proba wstawienia fragmentu o nie pasujacym rozmiarze");
                }

                for (int y = 0; y < wysokosc; y++)
                {
                    for (int x = 0; x < szerokosc; x++)
                    {
                        Color kolor = value.GetPixel(x, y);
                        obraz.SetPixel(poczatekX + x, poczatekY + y, kolor);
                    }
                }

            }
        }


    }

    
}
