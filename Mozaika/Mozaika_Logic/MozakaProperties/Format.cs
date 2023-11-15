using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mozaika_Logic
{
    class Format
    {
        private int szerokosc;
        private int wysokosc;

        string nazwa;

        public Format(string nazwa, int szerokosc, int wysokosc)
        {
            this.szerokosc = szerokosc;
            this.wysokosc = wysokosc;
            this.nazwa = nazwa;
        }

        public int Szerokosc => szerokosc;
        public int Wysokosc => wysokosc;

        public string Nazwa => nazwa;

        public override string ToString()
        {
            return $"{nazwa} wysokość: {wysokosc} x szerokość: {szerokosc}";
        }




    }
}
