using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mozaika_Logic;
using Mozaika_GUI;
using System.Configuration;
using System.Windows.Forms;



namespace Mozaika_GUI
{
     public class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
