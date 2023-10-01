using Mozaika_Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mozaika_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void przycisk_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
            //this.przycisk.Text = textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Skrypt.ChangeExtension(@"C:\Users\dawid\OneDrive\Desktop\zdjecia");
            ListaMiniaturek miniaturki = new ListaMiniaturek();
            miniaturki.Wczytaj(@"C:\Users\dawid\OneDrive\Desktop\zdjecia");
            Obraz obraz = new Obraz(@"C:\Users\dawid\OneDrive\Desktop\Mozaiki\images(8).jpg", miniaturki);
            obraz.ZrobMozaike();
            Class1 x = new Class1();

        }
    }
}
