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
            string name = "Lucifer";
            double weight = 4.5;

            // Act
            var cat = new Cat(name, weight);

            // Assert
            Assert.AreEqual(name, cat.Name, "Nimen tulisi vastata nimeä Lucifer.");
            Assert.AreEqual(weight, cat.Weight, "Painon tulisi vastata painoa 4.5.");
            Assert.AreEqual(cat.CalculateMetabolicWeight(weight), cat.MetabolicWeight, 
                "Metabolisen painon tulisi vastata laskettua metabolista painoa.");
            }

            [TestMethod]
             public void CalculateMetabolicWeight_ShouldReturnCorrectValue()
            {
            // Arrange
            var cat = new Cat("Lucifer", 4.5);
            double actualMetabolicWeight = Math.Round(Math.Pow(4.5, Cat.COEFFICIENT_FOR_METABOLIC_WEIGHT), 2);

            // Act
            double catsMetabolicWeight = cat.CalculateMetabolicWeight(4.5);

            // Assert
            Assert.AreEqual(actualMetabolicWeight, catsMetabolicWeight, "Metabolisen painon tulisi vastata" +
                "laskettua metabolista painoa");
            }

            [TestMethod]
            public void DailyTaurineNeed_ShouldReturnCorrectValue()
            {
            // Arrange
            var cat = new Cat("Lucifer", 4.5);
            double actualTaurineNeed = cat.MetabolicWeight * Cat.DAILY_TAURINE_NEED_PER_METABOLIC_KG;

            // Assert
            Assert.AreEqual(actualTaurineNeed, cat.DailyTaurineNeed, "Tauriinin määrän tulisi vastata" +
                "laskettua tauriinan määrää");
            }
    }
}

