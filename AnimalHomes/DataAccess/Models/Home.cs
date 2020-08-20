using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Home
    {
        public Home()
        {
            Animals = new List<Animal>();
        }
        public string Name { get; set; }
        public int Id { get; set; }
        public List<Animal> Animals {get; set;}
    }
    
}
