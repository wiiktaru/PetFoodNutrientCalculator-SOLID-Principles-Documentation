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
                double metabolicWeight = dog.CalculateMetabolicWeight(weight);
                double calculationForMetabolicWeight = Math.Round(Math.Pow(weight, Pet.COEFFICIENT_FOR_METABOLIC_WEIGHT), 2);
            // Assert
            Assert.AreEqual(name, dog.Name, "Koiran nimen tulisi olla Ressu");
                Assert.AreEqual(weight, dog.Weight, "Koiran painon tulisi olla 10");
                Assert.AreEqual(calculationForMetabolicWeight, metabolicWeight,
                "Metabolisen painon tulisi vastata laskettua metabolista painoa");
            }

            [TestMethod]
            public void CalculateMetabolicWeight_ShouldReturnRightValue()
            {
                // Arrange
                double weight = 10.0;
                Dog dog = new Dog("Ressu", weight);

                // Act
                double metabolicWeight = dog.CalculateMetabolicWeight(weight);
                double calculationForMetabolicWeight = Math.Round(Math.Pow(weight, Pet.COEFFICIENT_FOR_METABOLIC_WEIGHT), 2);

                // Assert
                Assert.AreEqual(calculationForMetabolicWeight, metabolicWeight,
                    "Metabolisen painon tulisi vastata laskettua metabolista painoa");
            }
        }
    }
