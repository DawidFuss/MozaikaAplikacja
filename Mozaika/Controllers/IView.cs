using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public interface IView
    {
        EventHandler CreateMosaicClick { get; set; }
        EventHandler SelectButtonClick { get; set; }
        EventHandler TimerTick { get; set; }

        int ProgressBarValue { set; }

    }   
}   
