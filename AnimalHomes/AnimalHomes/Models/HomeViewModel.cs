using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnimalHomes.Models
{
    public class HomeViewModel
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public List<AnimalViewModel> Animals { get; set; }
    }
}