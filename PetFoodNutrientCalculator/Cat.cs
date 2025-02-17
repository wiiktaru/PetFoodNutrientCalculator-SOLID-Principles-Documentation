﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFoodNutrientCalculator
{
    /// <summary>
    /// Represents a cat, which is a type of pet 
    /// </summary>
    public class Cat : Pet, IPet
    {
        public const double DAILY_TAURINE_NEED_PER_METABOLIC_KG = 9.9;

        public double DailyTaurineNeed
        {
            get
            {
                return MetabolicWeight * DAILY_TAURINE_NEED_PER_METABOLIC_KG;
            }
            set 
            {

            }
        }
        
            public Cat(string name, double weight)
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

        //TODO add functionality 
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
