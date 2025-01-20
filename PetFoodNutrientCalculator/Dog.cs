using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace PetFoodNutrientCalculator
{
    /// <summary>
    /// Represents a dog, which is a type of pet 
    /// </summary>
    public class Dog : Pet, IPet
    {
        public Dog(string name,double weight)
        {
            Name = name;
            Weight = weight;
            MetabolicWeight = CalculateMetabolicWeight(weight);
            
        }

        public double CalculateMetabolicWeight(double weight)
        {
            double result = Math.Pow(weight, COEFFICIENT_FOR_METABOLIC_WEIGHT);
            result = Math.Round(result, 2);

            return result;
        }

        // TODO add functionality 
        public int CalculateDailyEnergyRequirement()
        {
            throw new NotImplementedException();
        }

        //TODO add functionality 
        public void CalculateNutrients()
        {
            throw new NotImplementedException();
        }
    }
}
