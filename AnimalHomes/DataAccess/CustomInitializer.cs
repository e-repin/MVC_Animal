using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    class CustomInitializer :/* CreateDatabaseIfNotExists<ContextAnimalHomes>*/DropCreateDatabaseAlways<ContextAnimalHomes>
    {    
        protected override void Seed(ContextAnimalHomes context)
        {
            var cat = new Animal() { Name = "Cat", Age = 10 };
            var dog = new Animal() { Name = "Dog", Age = 20 };
            var bird = new Animal() { Name = "Bird", Age = 30 };

            var house1 = new Home() { Name = "House1" };
            var house2 = new Home() { Name = "House2" };

            house1.Animals.Add(cat);
            house2.Animals.Add(dog);
            house2.Animals.Add(bird);

            context.Animals.Add(cat);
            context.Animals.Add(dog);
            context.Animals.Add(bird);

            context.Homes.Add(house1);
            context.Homes.Add(house2);

            context.SaveChanges();
        }
    }
}
