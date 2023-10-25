using Mozaika_GUI;
using Mozaika_Logic;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            view.Button1ClickEvent += Button1Handler;
            view.Button2ClickEvent += Button2Handler;
            view.TimeProgresBarEvent += TimeProgessBarHandler;
            m_service.MosaicFinished += OnMosaicFinished;
            
       
        }

        private void Button1Handler(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg) | *.jpg";
            openFileDialog.Title = "Wybierz plik";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog.FileName;
                m_service.LoadImage(path);
                isImageLoaded = true;
            }
        }

        private void Button2Handler(object sender, EventArgs e)
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

        private void TimeProgessBarHandler(object sender, EventArgs e)
        {
            if (isImageCreated)
            {
                progressBar.Value = m_service.Step;
                ProgressBarValueChanged?.Invoke(this, progressBar.Value);
            }
            else
            {
                progressBar.Value = 0;
                ProgressBarValueChanged?.Invoke(this, progressBar.Value);
            }
        }

        private void OnMosaicFinished(object sender, EventArgs e)
        {
            
               createMosaic.Invoke(new Action(() =>
               {
                    progressBar.Value = 0;
                    createMosaic.Enabled = true;
                    isImageCreated = false;
                    MessageBox.Show("Mozaika została stworzona");
               }));
            
        }


    }
}


