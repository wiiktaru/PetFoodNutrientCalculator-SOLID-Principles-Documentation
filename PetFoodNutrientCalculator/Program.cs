namespace PetFoodNutrientCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog testDog = new Dog("Pluto", 10.0);
            Dog testDog1 = new Dog("Tessu", 12.0);

            PetRepository petRepository = new PetRepository();
            petRepository.Pets.Add(testDog);
            petRepository.Pets.Add(testDog1);

            for (int i = 0; i <petRepository.Pets.Count; i++)
            {
                Console.WriteLine(petRepository.Pets[i].Name);
            }
        }
    }
}
