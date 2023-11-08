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
        private event EventHandler createMosaicClick;
        private event EventHandler selectButtonClick;
        private event EventHandler timerTick;

        private ListaMiniaturek miniaturki;
        private MosaicService mosaicService;

        public Form1()
        {

            InitializeComponent();
            MyController myController = new MyController(this, CreateMosaic, progressBar1);
            mosaicService = MosaicService.Instance;
            Lista.View = View.Details;
            Lista.Columns.Add("Nazwa zbioru", 100);
            Lista.Columns.Add("Ilość Elementów", 100);
            Lista.Columns.Add("Opis", 100);
            Lista.Columns.Add("Ścieżka", 150);
            string[] elementy_Rozmiar_Mozaiki = { "A0: 841mm x 1189mm", "A1: 594mm x 841mm", "A2: 420mm x 594mm",
            "A3: 297mm x 420mm","A4: 210mm x 297mm"};
            MosaicSize.Items.AddRange(elementy_Rozmiar_Mozaiki);
            Timer.Start();


        }

        public EventHandler CreateMosaicClick
        {
            get
            {
                return createMosaicClick;
            }
            set
            {
                createMosaicClick = value;
            }
        }

        public EventHandler SelectButtonClick
        {
            get
            {
                return selectButtonClick;
            }
            set
            {
                selectButtonClick = value;
            }

        }

        public EventHandler TimerTick
        {
            get
            {
                return timerTick;
            }
            set
            {
                timerTick = value;
            }

        }
        int IView.ProgressBarValue
        {
            get
            {
                return progressBar1.Value;
            }
            set
            {
                if (this.InvokeRequired)
                {
                    this.Invoke(new Action(() => progressBar1.Value = value));
                }
                else
                {
                    progressBar1.Value = value;
                }
            }
        }


        private void CreateMosaic_Click(object sender, EventArgs e)
        {
            CreateMosaicClick?.Invoke(sender, e);
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            SelectButtonClick?.Invoke(sender, e);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            TimerTick?.Invoke(sender, e);
        }
    }
}



