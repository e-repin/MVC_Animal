using AnimalHomes.Models;
using AutoMapper;
using BusinessLogic;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AnimalHomes.Controllers.api
{
    public class AnimalsController : ApiController
    {
        private readonly IMapper _mapper;
        public readonly IAnimalManager _animalManager;
        public readonly JSonConverter _jSonConverter;
        public AnimalsController(IMapper mapper, AnimalManager animalManager, JSonConverter jSonConverter)
        {
            _mapper = mapper;
            _animalManager = animalManager;
            _jSonConverter = jSonConverter;
        }



        //GET: api/Animals
        public string Get()
        {
            //var animals = _animalManager.GetAllAnimal();
            //var viewResult = _mapper.Map<List<AnimalViewModel>>(animals);
            //var json = _jSonConverter.Convert(viewResult);


            return "wow";
        }

        // GET: api/Animals/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Animals
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Animals/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Animals/5
        public void Delete(int id)
        {
        }
    }
}
