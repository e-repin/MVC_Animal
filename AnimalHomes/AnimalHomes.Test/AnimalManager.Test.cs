using AutoMapper;
using BusinessLogic;
using DataAccess;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHomes.Test
{

    [TestFixture]
    public class AnimalManagerTest
    {
        private IAnimalHomesRepository _animalHomesRepository;
        [Test]
        public void Test()
        {
            Assert.NotNull(true);
        }
        [Test]
        public void CreateAnimal_CreatedEntity()

        {
            var animalRepositoryMock = new Mock<IAnimalHomesRepository>();
            var test = new AnimalModel { Name = "Test", Age = 99 };
            var mapperMock = new Mock<IMapper>();
            var test1 = new AnimalModel { Name = "Test1", Age = 100, Id = 2 };
            animalRepositoryMock.Setup(x => x.AddAnimal(It.IsAny<Animal>())).Returns(new Animal { Name = "Test1", Age = 100 });
            mapperMock.Setup(x => x.Map<AnimalModel>(It.IsAny<Animal>())).Returns(test1);
            mapperMock.Setup(x => x.Map<Animal>(It.IsAny<AnimalModel>())).Returns(new Animal { Name = "Test1", Age = 100 });
            IAnimalManager _animalManager = new AnimalManager(animalRepositoryMock.Object, mapperMock.Object);
            var test2 = _animalManager.AddAnimal(test);
            Assert.AreEqual(test1.Name, test.Name);
        }
    }
}
