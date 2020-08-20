using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class AnimalHomesRepository
    {
        public void SaveHomes(Home home)
        {
            using (var context = new ContextAnimalHomes())
            {
                context.Homes.Add(home);
                context.SaveChanges();
            }
        }
        public void SaveAnimal(Animal animal)
        {
            using (var context = new ContextAnimalHomes())
            {
                context.Animals.Add(animal);
                context.SaveChanges();
            }
        }

        public List<Animal> GetAllAnimals()
        {
            using (var context = new ContextAnimalHomes())
            {
                return context.Animals.ToList();
            }
        }
        public List<Home> GetAllHomes()
        {
            using (var context = new ContextAnimalHomes())
            {
                return context.Homes.ToList();
            }
        }
        public Animal AddAnimal(Animal animal)
        {
            using (var context = new ContextAnimalHomes())
            {
                context.Animals.Add(animal);
                context.SaveChanges();
                return animal;
            }
        }
    }

}
