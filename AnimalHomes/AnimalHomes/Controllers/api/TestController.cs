using AnimalHomes.Models;
using AutoMapper;
using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AnimalHomes.Controllers
{
    public class TestController : ApiController
    {
        // GET: api/Test
        private readonly Mapper _mapper;
        public readonly AnimalManager _animalManager;
        public readonly HomeManager _homeManager;
        public TestController()
        {
            _animalManager = new AnimalManager();
            _homeManager = new HomeManager();
            var conf = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<AnimalViewModel, AnimalModel>();
                cfg.CreateMap<AnimalModel, AnimalViewModel>();
                cfg.CreateMap<HomeViewModel, HomeModel>();
                cfg.CreateMap<HomeModel, HomeViewModel>();

            });
            _mapper = new Mapper(conf);
        }
        public IEnumerable<AnimalViewModel> Get()
        {
            var result = _animalManager._animalHomesRepository.GetAllAnimals();           
            var viewResult = _mapper.Map<List<AnimalViewModel>>(result);
            return viewResult;            
        }

        // GET: api/Test/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Test
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Test/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Test/5
        public void Delete(int id)
        {
        }
    }
}
