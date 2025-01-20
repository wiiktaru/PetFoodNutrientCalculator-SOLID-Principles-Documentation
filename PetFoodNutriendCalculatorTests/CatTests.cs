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
            [TestMethod]
            public void Constructor_ShouldInitializeProperties()
            {
            // Arrange
            string name = "Whiskers";
            double weight = 4.5;

            // Act
            var cat = new Cat(name, weight);

            // Assert
            Assert.AreEqual(name, cat.Name, "Nimen tulisi vastata nimeä Whiskers");
            Assert.AreEqual(weight, cat.Weight, "Painon tulisi olla 4.5");
            Assert.AreEqual(cat.CalculateMetabolicWeight(weight), cat.MetabolicWeight, 
                "Metabolisen painon tulisi vastata laskettua metabolista painoa");
            }

            [TestMethod]
             public void CalculateMetabolicWeight_ShouldReturnCorrectValue()
            {
            // Arrange
            var cat = new Cat("Whiskers", 4.5);
            double expectedMetabolicWeight = Math.Round(Math.Pow(4.5, Cat.COEFFICIENT_FOR_METABOLIC_WEIGHT), 2);

            // Act
            double metabolicWeight = cat.CalculateMetabolicWeight(4.5);

            // Assert
            Assert.AreEqual(expectedMetabolicWeight, metabolicWeight, "Metabolisen painon tulisi vastata" +
                "laskettua metabolista painoa");
            }

            [TestMethod]
            public void DailyTaurineNeed_ShouldReturnCorrectValue()
            {
            // Arrange
            var cat = new Cat("Whiskers", 4.5);
            double expectedTaurineNeed = cat.MetabolicWeight * Cat.DAILY_TAURINE_NEED_PER_METABOLIC_KG;

            // Assert
            Assert.AreEqual(expectedTaurineNeed, cat.DailyTaurineNeed, "Tauriinin määrän tulisi vastata" +
                "laskettua tauriinan määrää");
            }
    }
}

