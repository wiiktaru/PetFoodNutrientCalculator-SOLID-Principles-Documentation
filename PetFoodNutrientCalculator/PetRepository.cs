using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFoodNutrientCalculator
{
    /// <summary>
    /// Serves as a repository for storing and managing pets
    /// </summary>
    public class PetRepository
    {
        public List<Pet> Pets { get; private set; }

        public PetRepository()
        {
            Pets = new List<Pet>();
        }

        /// <summary>
        /// Add a pet to a repository 
        /// </summary>
        public void AddPet()
        {
            try
            {
                Console.WriteLine("Valitse 1 mikäli lemmikki on koira. Valitse 2 mikäli lemmikki on kissa");
      
                if (!int.TryParse(Console.ReadLine(), out int species) || (species != 1 && species != 2))
                {
                    Console.WriteLine("Virheellinen syöte. Valitse 1 tai 2.");
                    return;
                }

                Console.WriteLine("Kirjoita lemmikin nimi");
                string petName = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(petName))
                {
                    Console.WriteLine("Virheellinen syöte. Nimi ei voi olla tyhjä.");
                    return;
                }

                Console.WriteLine("Kirjoita lemmikin paino kiloina. Esim. 4.2");
                string weightInput = Console.ReadLine().Replace('.', ',');
  
                if (!double.TryParse(weightInput, out double petWeight) || petWeight <= 0)
                {
                    Console.WriteLine("Virheellinen syöte. Syötä kelvollinen paino.");
                    return;
                }

                if (species == 1)
                {
                    Dog dog = new Dog(petName, petWeight);
                    Pets.Add(dog);
                }
                else if (species == 2)
                {
                    Cat cat = new Cat(petName, petWeight);
                    Pets.Add(cat);
                }

                Console.WriteLine("Lemmikki lisätty onnistuneesti");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Tapahtui virhe: {ex.Message}");
            }
        }
    }
}
