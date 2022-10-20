using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp5.Models
{
    public class Database
    {
        public List<Post> Posts { get; set; }
        public List<Subscriber> Subsribers { get; set; }

        public Database()
        {
            Posts = new List<Post>();
            Subsribers = new List<Subscriber>();
        }
        public int CheckSubscriberExist(string name)
        {
            return Subsribers.FindIndex(s => s.Name == name);

        }
        
    }
}
