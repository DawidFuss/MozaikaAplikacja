using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mozaika_Logic.MozakaProperties
{
    public class Properties
    {
        List<Format> formatyMozaik;
        List<Format> formatyMiniatur;
        List<int> dpi;

        Format selectedFormatyMozaik;
        Format selectedFormatyMiniatur;
        int? selectedDpi;


        private static Properties instance;

        public static Properties GetInstance()
        {
            if(instance == null)
            {
                instance = new Properties();
            }
            return instance;
        }

        private Properties()
        {
            formatyMozaik = new List<Format>();
            formatyMiniatur = new List<Format>();
            dpi = new List<int>();

            formatyMozaik.Add(new Format("A1", 1230, 1231));


            selectedFormatyMozaik = null;
            selectedFormatyMiniatur = null;
            selectedDpi = null;
        }

        public int SelectedIndexFormatMozaik 
        {
            set
            {
                if(value>0 && value< formatyMozaik.Count)
                {
                    selectedFormatyMozaik = formatyMozaik[value];
                }
            }
        }
        public int SelectedIndexFormatMiniatury
        {
            set
            {
                if(value>0 && value< formatyMiniatur.Count)
                {
                    selectedFormatyMiniatur = formatyMiniatur[value];
                }
            }   
        }
        public int SelectedIndexDpi
        {
            set
            {
                if (value > 0 && value < dpi.Count)
                {
                    selectedDpi = dpi[value];
                }
            }
        }
        const double MM_NA_CAL = 25.4;

        public string[] FormatyMozaikNames
        {
            get
            {
                string[] names = new string[formatyMozaik.Count];
                for(int i = 0; i < names.Length; i++)
                {
                    names[i] = formatyMozaik[i].ToString();
                }
                return names;
            }
        }

        public string[] FormatyMiniaturNames
        {
            get
            {
                string[] names = new string[formatyMiniatur.Count];
                for (int i = 0; i < names.Length; i++)
                {
                    names[i] = formatyMiniatur[i].ToString();
                }
                return names;
            }
        }

        public string[] DpiNames
        {
            get
            {
                string[] names = new string[dpi.Count];
                for (int i = 0; i < names.Length; i++)
                {
                    names[i] = dpi[i].ToString();
                }
                return names;
            }
        }

        public Size MiniatureSize
        {
            get
            {
                if (!selectedDpi.HasValue || selectedFormatyMiniatur == null)
                {
                    return new Size(0, 0);
                }

                double iloscPikseliNa1mm = selectedDpi.Value / MM_NA_CAL;
                int width = (int)((iloscPikseliNa1mm * selectedFormatyMiniatur.Szerokosc) + 0.5);
                int height = (int)((iloscPikseliNa1mm * selectedFormatyMiniatur.Wysokosc) + 0.5);
                return new Size(width, height);
            }
        }
        public Size MozaikSize
        {
            get
            {
                if(!selectedDpi.HasValue || selectedFormatyMozaik == null || selectedFormatyMiniatur == null)
                {
                    return new Size(0,0);
                }

                double iloscPikseliNa1mm = selectedDpi.Value / MM_NA_CAL;
                int width = (int)((iloscPikseliNa1mm * selectedFormatyMozaik.Szerokosc)+0.5);
                int height = (int)((iloscPikseliNa1mm * selectedFormatyMozaik.Wysokosc) + 0.5);
                Size miniatureSize = this.MiniatureSize;

                int countMiniaturesWidth = (int)(((double)width / miniatureSize.Width) + 0.5);
                int countMiniaturesHeight = (int)(((double)height / miniatureSize.Height) + 0.5);

                width = countMiniaturesWidth * miniatureSize.Width;
                height = countMiniaturesWidth * miniatureSize.Height;
                return new Size(width, height);
            }
        }

        

    }
}
