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
        private Dog dog;

        [TestInitialize]
        public void TestInitialize()
        {
            dog= new Dog("Kulkuri", 10.0);
        }

        [TestMethod]
            public void CalculateMetabolicWeight_ReturnsCalculatedValue()
            {
                // Act
                double metabolicWeight = dog.CalculateMetabolicWeight(dog.Weight);
                double actualMetabolicWeight = Math.Round(Math.Pow(dog.Weight, Pet.COEFFICIENT_FOR_METABOLIC_WEIGHT), 2);

                // Assert
                Assert.AreEqual(actualMetabolicWeight, metabolicWeight,
                    "Metabolisen painon tulisi vastata laskettua metabolista painoa");
            }
        }
    }
