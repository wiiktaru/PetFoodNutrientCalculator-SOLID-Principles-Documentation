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

        private InputValidator inputValidator; 

        private int petSelection;
        private string petName = string.Empty;
        private double petWeight; 

        public PetRepository()
        {
            Pets = new List<Pet>();
            inputValidator = new InputValidator();
        }

        // TODO simplify this method for better readability and maintainability 
        /// <summary>
        /// Add a pet to a repository 
        /// </summary>
        public void AddPet()
        {
            Console.WriteLine("Valitse 1 mikäli lemmikki on koira. Valitse 2 mikäli lemmikki on kissa.");
            string userInput = Console.ReadLine();
            if(!inputValidator.ValidatePetSelection(userInput)) 
            {
                AddPet();
                return;
            }
            petSelection = int.Parse(userInput);

            Console.WriteLine("Kirjoita lemmikin nimi.");
            userInput = Console.ReadLine();
            if(!inputValidator.ValidatePetName(userInput))
            {
                AddPet();
                return;
            }
            petName = userInput; 

            Console.WriteLine("Kirjoita lemmikin paino kiloina. Esim. 4.2");
            userInput = Console.ReadLine().Replace('.', ',');
            if(!inputValidator.ValidatePetWeight(userInput))
            {
                AddPet();
                return;
            }
            petWeight = double.Parse(userInput);

            SwitchPetToAdd(petSelection);      
        }

        public void SwitchPetToAdd(int selection)
        {
            if (selection == 1)
            {
                Dog dog = new Dog(petName, petWeight);
                Pets.Add(dog);
            }
            else if (selection == 2)
            {
                Cat cat = new Cat(petName, petWeight);
                Pets.Add(cat);
            }

            Console.WriteLine($"Lemmikkisi {petName} lisätty onnistuneesti");
        }
    }
}
