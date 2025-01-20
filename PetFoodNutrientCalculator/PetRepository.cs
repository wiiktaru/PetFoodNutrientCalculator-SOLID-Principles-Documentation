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

        int petSelection;
        public PetRepository()
        {
            Pets = new List<Pet>();
        }

        // TODO simplify this
        /// <summary>
        /// Add a pet to a repository 
        /// </summary>
        public void AddPet()
        {
            try
            {
                Console.WriteLine("Valitse 1 mikäli lemmikki on koira. Valitse 2 mikäli lemmikki on kissa");
      
                string userInput = Console.ReadLine();

                petSelection= ValidatePetSelection(userInput);

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

                //if (species == 1)
                //{
                //    Dog dog = new Dog(petName, petWeight);
                //    Pets.Add(dog);
                //}
                //else if (species == 2)
                //{
                //    Cat cat = new Cat(petName, petWeight);
                //    Pets.Add(cat);
                //}

                Console.WriteLine("Lemmikki lisätty onnistuneesti");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Tapahtui virhe: {ex.Message}");
            }
        }

        public int ValidatePetSelection(string userInput)
        {
            if(!int.TryParse(userInput, out int species) || (species != 1 && species != 2))
            { 
                Console.WriteLine("Virheellinen syöte. Valitse kokonaisluku 1 tai 2.");
                AddPet();
            }
            
            int selection = int.Parse(userInput);
            return selection; 
        }
    }
}
