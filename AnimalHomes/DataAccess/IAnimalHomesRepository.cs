using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public interface IAnimalHomesRepository
    {
        List<Animal> GetAllAnimals();
        Animal AddAnimal(Animal animal);
    }
}
