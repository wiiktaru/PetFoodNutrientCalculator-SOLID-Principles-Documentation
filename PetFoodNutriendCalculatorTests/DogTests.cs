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
                string name = "Pluto";
                double weight = 10.0;

                // Act
                Dog dog = new Dog(name, weight);
                double metabolicWeight = dog.CalculateMetabolicWeight(weight);
                double actualMetabolicWeight = Math.Round(Math.Pow(weight, Pet.COEFFICIENT_FOR_METABOLIC_WEIGHT), 2);
            
                // Assert
                Assert.AreEqual(name, dog.Name, "Koiran nimen tulisi vastata nimeä Pluto.");
                Assert.AreEqual(weight, dog.Weight, "Koiran painon tulisi vastata painoa 10.");
                Assert.AreEqual(actualMetabolicWeight, metabolicWeight,
                "Metabolisen painon tulisi vastata laskettua metabolista painoa");
            }

            [TestMethod]
            public void CalculateMetabolicWeight_ShouldReturnRightValue()
            {
                // Arrange
                double weight = 10.0;
                Dog dog = new Dog("Pluto", weight);

                // Act
                double metabolicWeight = dog.CalculateMetabolicWeight(weight);
                double actualMetabolicWeight = Math.Round(Math.Pow(weight, Pet.COEFFICIENT_FOR_METABOLIC_WEIGHT), 2);

                // Assert
                Assert.AreEqual(actualMetabolicWeight, metabolicWeight,
                    "Metabolisen painon tulisi vastata laskettua metabolista painoa");
            }
        }
    }
