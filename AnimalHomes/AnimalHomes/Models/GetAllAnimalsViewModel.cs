using BusinessLogic;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnimalHomes.Models
{
    public class GetAllAnimalsViewModel
    {
        public List <AnimalModel> Animals { get; set; }
    }
}