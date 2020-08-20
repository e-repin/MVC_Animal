using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnimalHomes.Models
{
    public class AnimalViewModel
    {
        public string Name { get; set; }
        public int Age { get; set; }
        [MyIgnore]
        public int Id { get; set; }
    }
}