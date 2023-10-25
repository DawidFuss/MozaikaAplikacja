using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mozaika_Logic;
using Mozaika_GUI;
using System.Configuration;
using System.Windows.Forms;
using Controllers;

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
            Form1 form  = new Form1();
            MyController myController = new MyController();
            Application.Run(form);
            
        }
    }
}
