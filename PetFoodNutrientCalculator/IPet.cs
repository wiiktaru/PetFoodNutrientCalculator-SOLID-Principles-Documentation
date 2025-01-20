namespace PetFoodNutrientCalculator
{
    interface IPet
    {
        double CalculateMetabolicWeight(double weight);
        int CalculateDailyEnergyRequirement();
        void CalculateNutrients();
    }
}
