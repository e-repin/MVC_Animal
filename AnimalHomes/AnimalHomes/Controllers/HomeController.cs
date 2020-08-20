using AnimalHomes.Models;
using AutoMapper;
using BusinessLogic;
using BusinessLogic.Managers;
using DataAccess.Models;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace AnimalHomes.Controllers
{   
    public class HomeController : Controller
    {
        private readonly Mapper _mapper;
        public readonly AnimalManager _animalManager;
        public readonly HomeManager _homeManager;
        public HomeController()
        {
            

            _animalManager = new AnimalManager();
            _homeManager = new HomeManager();
            var conf = new MapperConfiguration(cfg =>
            {
                //cfg.CreateMap<AnimalViewModel, AnimalModel>();
               // cfg.CreateMap<AnimalModel, AnimalViewModel>();
                cfg.CreateMap<СommonViewModel, HomeModel>();
                cfg.CreateMap<HomeModel, СommonViewModel>();
                cfg.CreateMap<СommonViewModel, AnimalModel>();
                cfg.CreateMap<AnimalModel, СommonViewModel>();

            });
            _mapper = new Mapper(conf);
        }
        //public ActionResult AllAnimals()
        //{
        //    var userManager = HttpContext.GetOwinContext().GetUserManager<EmployeeManager>();
        //    var authManager = HttpContext.GetOwinContext().Authentication;

        //    var result = _animalManager.GetAllAnimal();
        //    var viewResult = new GetAllAnimalsViewModel();
        //    viewResult.Animals = _mapper.Map<List<AnimalModel>>(result); 
        //    return View(viewResult);
        //}
        public async Task <ActionResult> AllAnimals()
        {
            //var userManager = HttpContext.GetOwinContext().GetUserManager<EmployeeManager>();

            //var createUser = await userManager.CreateAsync(new Employee
            //{
            //    UserName = "name",
            //    LastName = "lastName",
            //    City = "city",
            //    BirdthDay = DateTime.Now
            //}, "123456789");
            

            var result = _animalManager.GetAllAnimal();
            var viewResult = new CommonAllViewModel();
            viewResult.СommonViewModels = _mapper.Map<List<СommonViewModel>>(result);
            return View(viewResult);
        }
        public ActionResult AllHomes()
        {
            var result = _homeManager.GetAllHomes();
            var viewResult = new CommonAllViewModel();
            viewResult.СommonViewModels = _mapper.Map<List<СommonViewModel>>(result);
            return View(viewResult); ;
        }
        
    }
}