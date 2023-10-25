using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public interface IView
    {
        EventHandler Button1ClickEvent { get; set; }
        EventHandler Button2ClickEvent { get; set; }
        EventHandler TimeProgresBarEvent { get; set; }
        
    }   
}   
