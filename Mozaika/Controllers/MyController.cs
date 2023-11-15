using Mozaika_GUI;
using Mozaika_Logic;
using Mozaika_Logic.MozakaProperties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Controllers   

{   
    public class MyController
    {
    
        private string path;
        private bool isImageLoaded;
        private bool isImageCreated;
        private IView view;
        private MosaicService m_service;
        private System.Windows.Forms.Button createMosaic;
        private System.Windows.Forms.ProgressBar progressBar;
        public event EventHandler<int> ProgressBarValueChanged;
     


        public MyController() { }
        
        public MyController(IView view, System.Windows.Forms.Button createMosaic, System.Windows.Forms.ProgressBar progressBar)
        {
            this.createMosaic = createMosaic;
            this.progressBar = progressBar;
            this.view = view;
            m_service = MosaicService.Instance;
            m_service.ProgressUpdated += ProgressUpdatedHandler;
            view.SelectButtonClick += SelectButtonClickHandler;
            view.CreateMosaicClick += CreateMosaicClickHandler;
         //   view.TimerTick += TimerTickHandler;
            m_service.MosaicFinished += OnMosaicFinished;


            view.DpiNames = Properties.GetInstance().DpiNames;
            //w widoku udostepnic zdarzernie zmiany zaznaczonego indeksu
            //w kontrolerze reagujemy na to i ustawiamy zaznaczony index w properties
            //zaznaczony index mozna wyciagnac na 2 sposoby
            //mamy object sender w metode reagujacej na zmiane indexu i robimy ComboBox cb = (ComboBox)sender;
            //cb.seletedIndex
            //2 sposob 
            //wyciagamy index w postaci wlasciwosci z menu cos jak z DpiName ale get


        }

        private void SelectButtonClickHandler(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg) | *.jpg | (*.bmp) | *.bmp";
            openFileDialog.Title = "Wybierz plik";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog.FileName;
                m_service.LoadImage(path);
                isImageLoaded = true;
            }
        }

        private void CreateMosaicClickHandler(object sender, EventArgs e)
        {
            if (isImageLoaded)
            {
                createMosaic.Enabled = false;
                progressBar.Maximum = m_service.Steps;
                m_service.MakeMosaic();
                isImageCreated = true;
            }
            else
            {
                MessageBox.Show("Wybierz obrazek");
            }


        }
        /*
        private void TimerTickHandler(object sender, EventArgs e)
        {
            if (isImageCreated)
            {
                view.ProgressBarValue = m_service.Step;
             //   ProgressBarValueChanged?.Invoke(this, view.ProgressBarValue);
            }
            else
            {
                view.ProgressBarValue = 0;
             //   ProgressBarValueChanged?.Invoke(this, view.ProgressBarValue);
            }
        }*/


        private void OnMosaicFinished(object sender, Bitmap obraz)
        {
            
               createMosaic.Invoke(new Action(() =>
               {
                   isImageCreated = false;
                      progressBar.Value = 0;
                    //progressBar.Visible = false;
                    createMosaic.Enabled = true;
                  
                    MessageBox.Show("Mozaika została stworzona");
                   SaveFileDialog saveFileDialog = new SaveFileDialog();
                   saveFileDialog.Filter = "Image files(*.jpg) | *.jpg";
                   saveFileDialog.Title = "Podaj nazwę oraz miejsce zapisu";
                   if (saveFileDialog.ShowDialog() == DialogResult.OK)
                   {
                       string filePath = saveFileDialog.FileName;
                       obraz.Save(filePath);
                   }

               }));
            
        }

        private void ProgressUpdatedHandler(object sender, int value)
        {
            if (view.ProgressBarValue != value)
            {
                view.ProgressBarValue = value;
            }
        }



    }
}


