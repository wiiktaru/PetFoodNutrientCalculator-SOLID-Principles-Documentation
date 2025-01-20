namespace PetFoodNutrientCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog testDog = new Dog("Pluto", 10.0);
            Dog testDog1 = new Dog("Tessu", 12.0);

            Cat testCat = new Cat("Whiskers", 4.0);

            PetRepository petRepository = new PetRepository();
            petRepository.Pets.Add(testCat);
            petRepository.Pets.Add(testDog1);

            Console.WriteLine(testCat.DailyTaurineNeed);
        }
    }
}
