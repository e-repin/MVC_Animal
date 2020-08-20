using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class HomeModel
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public List<AnimalModel> Animals { get; set; }
    }
}
