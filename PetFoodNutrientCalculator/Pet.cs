using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFoodNutrientCalculator
{
    /// <summary>
    /// Represents a pet with common properties
    /// </summary>
    public class Pet
    {
        public string Name { get; set; }
        public double Weight { get; set; }

        public const double COEFFICIENT_FOR_METABOLIC_WEIGHT = 0.75;

        public double MetabolicWeight { get; set; }
    }
}
