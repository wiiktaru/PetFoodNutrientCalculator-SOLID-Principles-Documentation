namespace PetFoodNutrientCalculator
{
    interface IPet
    {
        /// <summary>
        /// Calculates metabolic weight based on pets weight. It is used when calcualating nutritional needs
        /// </summary>
        /// <param name="weight"></param>
        /// <returns></returns>
        double CalculateMetabolicWeight(double weight);

        int CalculateDailyEnergyRequirement();
        void CalculateNutrients();
    }
}
