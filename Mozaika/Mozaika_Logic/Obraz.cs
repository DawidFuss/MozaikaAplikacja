using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Mozaika_GUI
{
    public class Obraz
    {
        private Bitmap obraz {  get; set; }
        private Bitmap saveImage { get; set; }
        ListaMiniaturek miniaturki;
        private int szerokosc;
        private int wysokosc;
        private int iloscWPoziomie;
        private int iloscWPionie;
        private int maxNumberOfSteps;
        private int step = 0;
        public delegate void MosaicFinishedEventHandler(object sender, EventArgs e);
        public event MosaicFinishedEventHandler MosaicFinished;
        public event EventHandler<int> ProgressUpdated;
        


        private SemaphoreSlim semaphoreSlim = new SemaphoreSlim(1, 1);

        public Obraz(string sciezka, ListaMiniaturek miniaturki)
        {
            this.miniaturki =  miniaturki;
            //wysokosc i szerokosc trzeba bedzie wyznaczyc na podstawie
            //- rozdzielczosci dpi
            //- wybranym formacie A0, B0 itp
            //- nalezy dostosowac tak, aby miescila cie calkowita ilosc miniatur
            szerokosc =8000; 
            wysokosc=6000;

            iloscWPoziomie = 100;
            iloscWPionie = 100;

            obraz = new Bitmap(Image.FromFile(sciezka), szerokosc, wysokosc);
            
            
            maxNumberOfSteps = iloscWPionie * iloscWPoziomie;
        }
        
        public void ZrobMozaike()
        {
            FragmentObrazu[,] fragmenty = new FragmentObrazu[iloscWPoziomie, iloscWPionie];
            step = 0;
            for(int y=0; y<iloscWPionie; y++)
            {
                for(int x=0; x<iloscWPoziomie; x++)
                {
                    fragmenty[x,y] = new FragmentObrazu(obraz, 80,60,x*80,y*60);
                    Color sredniKolor = fragmenty[x, y].SredniKolor;
                    Miniaturka miniaturka = miniaturki.WybierzMiniaturke(sredniKolor);
                    fragmenty[x, y].Fragment = miniaturka.Obraz;
                    semaphoreSlim.Wait();
                    step++;
                    ProgressUpdated?.Invoke(this, step);
                    semaphoreSlim.Release();
                    
                }
            }
            
           // obraz.Save("wynik.bmp");//bin debug
            
        
            OnMosaicFinished(EventArgs.Empty);
        }
        
        public int Steps
        {
            get
            {
                return maxNumberOfSteps;
            }
        }
        public int Step
        {
            get
            {
                int setpValue;
                semaphoreSlim.Wait();
                setpValue = step;
                semaphoreSlim.Release();
                return setpValue;
            }
        }

        public virtual void OnMosaicFinished(EventArgs e)
        {
            MosaicFinished?.Invoke(this, e);
        }
    }
}
