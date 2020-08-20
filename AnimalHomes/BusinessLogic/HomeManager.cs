using AutoMapper;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class HomeManager
    {
        public readonly AnimalHomesRepository _animalHomesRepository;
        private readonly Mapper _mapper;
        public HomeManager()
        {
            _animalHomesRepository = new AnimalHomesRepository();
            var conf = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Home, HomeModel>();
                cfg.CreateMap<HomeModel, Home>();

            });
            _mapper = new Mapper(conf);
        }
        public List<HomeModel> GetAllHomes()
        {
            var mapHomeModel = _mapper.Map<List<HomeModel>>(_animalHomesRepository.GetAllHomes());
            return mapHomeModel;
        }
    }
}
