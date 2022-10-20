using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp5.Models
{
    public class Post:ISubject
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string ImgPath { get; set; }
        public List<IObserver> subscribers { get; set; }

        public Post()
        {
            subscribers = new List<IObserver>();
            ID = App.database.Posts.Count - 1;
        }
        public void Attach(IObserver observer)
        {
            subscribers.Add(observer);

        }

        public void Detach(IObserver observer)
        {
            subscribers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var item in subscribers)
            {
                item.Update(this);
            }
        }
    }
}
