using Mozaika_GUI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Mozaika_Logic
{
    public class MosaicService
    {
        private Obraz obraz;
        public event EventHandler MosaicFinished;
        private ListaMiniaturek miniaturki;
        public int Steps => obraz?.Steps ?? 0;
        public int Step => obraz?.Step ?? 0;

        private static MosaicService instance;

        public static MosaicService Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new MosaicService();
                }
                return instance;
            }
        }


        private MosaicService()
        {
            miniaturki = new ListaMiniaturek();
        }

        public void MakeMosaic()
        {
            if (obraz != null)
            {
                miniaturki.Wczytaj(@"C:\Users\dawid\OneDrive\Desktop\zdjecia");
                Thread thread = new Thread(obraz.ZrobMozaike);
                thread.Start();

            }
            
        }

        public void LoadImage(string pathToImage)
        {
            obraz = new Obraz(pathToImage,miniaturki);
            obraz.MosaicFinished += (s, e) => MosaicFinished?.Invoke(s, e);
        }

        public void SaveImage(string pathToImage)
        {
            
            //obraz.save(pathToImage);
            
        }
    }
}
