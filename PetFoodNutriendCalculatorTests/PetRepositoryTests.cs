using PetFoodNutrientCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFoodNutrientCalculatorTests
{
    [TestClass]
    public class PetRepositoryTests
    {
        [TestMethod]
        public void Constructor_ShouldInitializePetsList()
        {
            // Arrange & Act
            var repository = new PetRepository();

            // Assert
            Assert.IsNotNull(repository.Pets);
            Assert.AreEqual(0, repository.Pets.Count);
        }

        [TestMethod]
        public void AddPet_ShouldAddPetToList()
        {
            // Arrange
            var repository = new PetRepository();
            var pet = new Pet { Name = "Buddy" };

            // Act
            repository.Pets.Add(pet);

            // Assert
            Assert.AreEqual(1, repository.Pets.Count);
            Assert.AreEqual("Buddy", repository.Pets[0].Name);
        }

    }
}
