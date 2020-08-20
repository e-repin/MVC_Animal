using AutoMapper;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class AnimalManager
    {
        public readonly AnimalHomesRepository _animalHomesRepository;
        private readonly Mapper _mapper;
        public AnimalManager()
        {
            _animalHomesRepository = new AnimalHomesRepository();
            var conf = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Animal, AnimalModel>();
                cfg.CreateMap<AnimalModel, Animal>();

            });
            _mapper = new Mapper(conf);
        }
        public List<AnimalModel> GetAllAnimal()
        {
            var mapAnimalModel = _mapper.Map<List<AnimalModel>>(_animalHomesRepository.GetAllAnimals());
            return mapAnimalModel;
        }
        public AnimalModel AddAnimal(AnimalModel animal)
        {
            _animalHomesRepository.AddAnimal(_mapper.Map<Animal>(animal));
            return animal;            
        }

    }
}
