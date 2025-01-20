using PetFoodNutrientCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFoodNutrientCalculatorTests
{
    [TestClass]
    public class DogTests
    {
            [TestMethod]
            public void DogConstructor_ShouldInitializeProperties()
            {
                // Arrange
                string name = "Buddy";
                double weight = 10.0;

                // Act
                Dog dog = new Dog(name, weight);

                // Assert
                Assert.AreEqual(name, dog.Name);
                Assert.AreEqual(weight, dog.Weight);
                Assert.AreEqual(Math.Pow(weight, Pet.COEFFICIENT_FOR_METABOLIC_WEIGHT), dog.MetabolicWeight);
            }

            [TestMethod]
            public void CalculateMetabolicWeight_ShouldReturnCorrectValue()
            {
                // Arrange
                double weight = 10.0;
                Dog dog = new Dog("Buddy", weight);

                // Act
                double metabolicWeight = dog.CalculateMetabolicWeight(weight);

                // Assert
                Assert.AreEqual(Math.Pow(weight, Pet.COEFFICIENT_FOR_METABOLIC_WEIGHT), metabolicWeight);
            }
        }
    }
