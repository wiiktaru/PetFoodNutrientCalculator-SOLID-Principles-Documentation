namespace PetFoodNutrientCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog testDog = new Dog("Pluto", 10.0); 
            Console.WriteLine(testDog.MetabolicWeight);
        }
    }
}
