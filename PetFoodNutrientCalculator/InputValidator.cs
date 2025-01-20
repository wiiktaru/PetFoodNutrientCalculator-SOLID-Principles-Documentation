using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFoodNutrientCalculator
{
    public class InputValidator
    {
        public bool ValidatePetSelection(string userInput)
        {
            if (!int.TryParse(userInput, out int selection) || (selection != 1 && selection != 2))
            {
                Console.WriteLine("Virheellinen syöte. Valitse kokonaisluku 1 tai 2.");
                return false;
            }

            return true;
        }

        public bool ValidatePetName(string userInput)
        {
            if (string.IsNullOrWhiteSpace(userInput))
            {
                Console.WriteLine("Virheellinen syöte. Nimi ei voi olla tyhjä.");
                return false;
            }

            return true;
        }

        //TODO functionality that returns to the correct position in the AddPet method
        public bool ValidatePetWeight(string userInput)
        {
            if (!double.TryParse(userInput, out double petWeight) || petWeight <= 0)
            {
                Console.WriteLine("Virheellinen syöte. Syötä kelvollinen paino.");
                return false;
            }
            return true;
        }
    }
}

