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
using System.Runtime.Remoting.Channels;
using Controllers;
namespace Mozaika_GUI
{
    public partial class Form1 : Form, IView
    {
        public event EventHandler CreateMosaicClick;


        public event EventHandler ButtonClickEvent;
        public event EventHandler ButtonClickEvent2;
        public event EventHandler ProgressBarEvent;


        private ListaMiniaturek miniaturki;
        private MosaicService mosaicService;
       
        public Form1()
        {
           
            InitializeComponent();
            MyController myController = new MyController(this, CreateMosaic, progressBar1);
            myController.ProgressBarValueChanged += MyController_ProgressBarValueChanged;
            mosaicService =  MosaicService.Instance;
            Lista.View = View.Details;
            Lista.Columns.Add("Nazwa zbioru", 100);
            Lista.Columns.Add("Ilość Elementów", 100);
            Lista.Columns.Add("Opis", 100);
            Lista.Columns.Add("Ścieżka", 150);
            string[] elementy_Rozmiar_Mozaiki = { "A0: 841mm x 1189mm", "A1: 594mm x 841mm", "A2: 420mm x 594mm",
            "A3: 297mm x 420mm","A4: 210mm x 297mm"};
            MosaicSize.Items.AddRange(elementy_Rozmiar_Mozaiki);
           // mosaicService.MosaicFinished += OnMosaicFinished;
            TimeProgessBar.Start();
            Wybierz.Click += (sender, e) => 
            { 
                ButtonClickEvent?.Invoke(sender, e); 
            };

            CreateMosaic.Click += (sender, e) =>
            {
                Button2ClickEvent?.Invoke(sender, e);
            };

            progressBar1.Click += (sender, e) => 
            { 
  
                TimeProgresBarEvent?.Invoke(sender, e);      
            };


        }

        public EventHandler Button1ClickEvent
        {
            get
            {
                return ButtonClickEvent;
            }
            set
            {
                ButtonClickEvent = value;
            }
        }

        public EventHandler Button2ClickEvent 
        {
            get
            {
                return ButtonClickEvent2;
            }
            set
            {
                ButtonClickEvent2 = value;
            }

        }

        public EventHandler TimeProgresBarEvent
        {
            get
            { 
              return ProgressBarEvent; 
            }

            set
            {
              ProgressBarEvent = value;
            }

        }

        private void MyController_ProgressBarValueChanged(object sender, int value)
        {
            progressBar1.Value = value;
        }



        private void przycisk_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
            //this.przycisk.Text = textBox1.Text;
        }

        private void CreateMosaic_Click(object sender, EventArgs e)
        {
            CreateMosaicClick?.Invoke(sender, e);
        }
        /* private void TimeProgessBar_Tick_1(object sender, EventArgs e)
{
    if (isImageCreated)
    {
        progressBar1.Value = mosaicService.Step;
    }
    else
    {
        progressBar1.Value = 0;
    }
}
*/

        /* private void OnMosaicFinished(object sender, EventArgs e)
         {


             Invoke(new Action(() =>
             {
                 progressBar1.Value = 0;
                 CreateMosaic.Enabled = true;
                 isImageCreated = false;
                 MessageBox.Show("Mozaika została stworzona");


             }));


         }
        */

    }
}



