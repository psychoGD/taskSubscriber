using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp5.Models;

namespace WpfApp5.ViewModels
{
    public class SubscriberViewModel
    {
        public Subscriber subscriber { get; set; }
        public SubscriberViewModel(Subscriber subscriber)
        {
            this.subscriber = subscriber;
        }
    }
}
