using PetFoodNutrientCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFoodNutrientCalculatorTests
{ 
    [TestClass]
    public class CatTests
    {
        private Cat cat;

        [TestInitialize]
        public void TestInitialize()
        {
            cat = new Cat("Luficer", 4.2);
        }

            [TestMethod]
             public void CalculateMetabolicWeight_ReturnsCalculatedValue()
            {
            // Act
            double actualMetabolicWeight = Math.Round(Math.Pow(cat.Weight, Pet.COEFFICIENT_FOR_METABOLIC_WEIGHT), 2);
            double result = cat.CalculateMetabolicWeight(cat.Weight);

            // Assert
            Assert.AreEqual(result, actualMetabolicWeight, "tuloksen tulisi olla 2.93.");

            }

            [TestMethod]
            public void DailyTaurineNeed_ReturnsCalculatedValue()
            {
            // Arrange
            double actualTaurineNeed = cat.MetabolicWeight * Cat.DAILY_TAURINE_NEED_PER_METABOLIC_KG;

            // Assert
            Assert.AreEqual(actualTaurineNeed, cat.DailyTaurineNeed, "Tauriinin määrän tulisi vastata" +
                "laskettua tauriinan määrää");
            }
    }
}

