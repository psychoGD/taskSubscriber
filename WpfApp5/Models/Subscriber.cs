using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp5.Models
{
    public class Subscriber:IObserver
    {
        public int ID { get; set; }
        public List<int> PostIDs { get; set; }
        public string Name { get; set; }
        public Subscriber(string username)
        {
            Name = username;
            PostIDs = new List<int>();
            ID = App.database.Subsribers.Count-1;
        }
        public void Update(ISubject subject)
        {
            var subject2 = subject as Post;
            PostIDs.Add(subject2.ID);
            
        }
    }
}
