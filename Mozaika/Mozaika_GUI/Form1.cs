using Mozaika_Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Drawing.Text;
using System.Threading.Tasks;

namespace Mozaika_GUI
{
    public partial class Form1 : Form
    {
        private ListaMiniaturek miniaturki;
        private Obraz obraz;

        public Form1()
        {
            
            InitializeComponent();
            Lista.View = View.Details;
            Lista.Columns.Add("Nazwa zbioru", 100);
            Lista.Columns.Add("Ilość Elementów", 100);
            Lista.Columns.Add("Opis", 100);
            Lista.Columns.Add("Ścieżka", 150);

            string[] elementy_Rozmiar_Mozaiki = { "A0: 841mm x 1189mm", "A1: 594mm x 841mm", "A2: 420mm x 594mm",
                "A3: 297mm x 420mm","A4: 210mm x 297mm"};
            MosaicSize.Items.AddRange(elementy_Rozmiar_Mozaiki);

            miniaturki = new ListaMiniaturek();
            obraz = new Obraz(@"C:\Users\dawid\OneDrive\Desktop\Mozaiki\images(8).jpg", miniaturki);
            TimeProgessBar.Start();
        }

        private void przycisk_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
            //this.przycisk.Text = textBox1.Text;
        }




        private void button1_Click_1(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg) | *.jpg | All.files (*.*)|*.*";
            openFileDialog.Title = "Wybierz plik";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxImageName.Text = openFileDialog.FileName;
            }

        }



        private async void button1_Click_2(object sender, EventArgs e)
        {
            CreateMosaic.Enabled = false;
            
            miniaturki.Wczytaj(@"C:\Users\dawid\OneDrive\Desktop\zdjecia");
            
            this.progressBar1.Maximum = obraz.Steps;
            this.progressBar1.Step = obraz.Steps/2;
            //Thread thread = new Thread(obraz.ZrobMozaike);
            
            //thread.Start();

            //CreateMosaic.Enabled = true;
        }

      
      

        private void TimeProgessBar_Tick_1(object sender, EventArgs e)
        {
            this.progressBar1.Step = obraz.Step;
        }
    }
}
