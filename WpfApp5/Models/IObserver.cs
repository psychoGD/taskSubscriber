using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp5.Models
{
    public interface IObserver
    {
        void Update(ISubject subject);
    }

}
