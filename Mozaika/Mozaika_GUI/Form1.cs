using Mozaika_Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Mozaika_GUI
{
    public partial class Form1 : Form
    {
    
        public Form1()
        {
           
            InitializeComponent();
            ListView1.View = View.Details;
            ListView1.Columns.Add("Nazwa zbioru", 100);
            ListView1.Columns.Add("Ilość Elementów", 100);
            ListView1.Columns.Add("Opis", 100);
            ListView1.Columns.Add("Ścieżka", 150);
            
            string[] elementy_Rozmiar_Mozaiki = { "A0: 841mm x 1189mm", "A1: 594mm x 841mm", "A2: 420mm x 594mm",
                "A3: 297mm x 420mm","A4: 210mm x 297mm"};
            comboBox1.Items.AddRange(elementy_Rozmiar_Mozaiki);



        }

        private void przycisk_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
            //this.przycisk.Text = textBox1.Text;
        }


        

        private void button1_Click_1(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.jpg) | *.jpg | All.files (*.*)|*.*";
            openFileDialog.Title = "Wybierz plik";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxImageName.Text = openFileDialog.FileName;
            }

        }

       

        private void button1_Click_2(object sender, EventArgs e)
        {
            ListaMiniaturek miniaturki = new ListaMiniaturek();
            miniaturki.Wczytaj(@"C:\Users\dawid\OneDrive\Desktop\zdjecia");
            Obraz obraz = new Obraz(@"C:\Users\dawid\OneDrive\Desktop\Mozaiki\images(8).jpg", miniaturki);
            obraz.ZrobMozaike();
        }

       
    }
}
