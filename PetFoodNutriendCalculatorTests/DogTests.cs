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
                string name = "Ressu";
                double weight = 10.0;

                // Act
                Dog dog = new Dog(name, weight);

                // Assert
                Assert.AreEqual(name, dog.Name, "Koiran nimen tulisi olla Ressu");
                Assert.AreEqual(weight, dog.Weight, "Koiran painon tulisi olla 10");
                Assert.AreEqual(dog.MetabolicWeight, 5.62, "Koiran metabolisen painon tulisi olla 5.62");
            }

            [TestMethod]
            public void CalculateMetabolicWeight_ShouldReturnRightValue()
            {
                // Arrange
                double weight = 10.0;
                Dog dog = new Dog("Ressu", weight);

                // Act
                double metabolicWeight = dog.CalculateMetabolicWeight(weight);

                // Assert
                Assert.AreEqual(Math.Pow(weight, Pet.COEFFICIENT_FOR_METABOLIC_WEIGHT), metabolicWeight,
                    "Metabolisen painon tulisi vastata laskettua metabolista painoa");
            }
        }
    }
