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

        private int petSelection;
        private string petName = string.Empty;
        private double petWeight; 

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
           
            Console.WriteLine("Valitse 1 mikäli lemmikki on koira. Valitse 2 mikäli lemmikki on kissa");
            string userInput = Console.ReadLine();
            petSelection= ValidatePetSelection(userInput);

            Console.WriteLine("Kirjoita lemmikin nimi");
            userInput = Console.ReadLine();
            petName = ValidatePetName(userInput);

            Console.WriteLine("Kirjoita lemmikin paino kiloina. Esim. 4.2");
            userInput = Console.ReadLine().Replace('.', ',');
            petWeight = ValidatePetWeight(userInput);

            SwitchPetToAdd(petSelection);      
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

        //TODO functionality that returns to the correct position in the AddPet method
        public string ValidatePetName(string userInput)
        {
            if (string.IsNullOrWhiteSpace(userInput))
            {
                Console.WriteLine("Virheellinen syöte. Nimi ei voi olla tyhjä.");
                AddPet();
            }

            return userInput;
        }

        //TODO functionality that returns to the correct position in the AddPet method
        public double ValidatePetWeight(string userInput)
        {
            if (!double.TryParse(userInput, out double petWeight) || petWeight <= 0)
            {
                Console.WriteLine("Virheellinen syöte. Syötä kelvollinen paino.");
                AddPet();
            }

            return petWeight;
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
