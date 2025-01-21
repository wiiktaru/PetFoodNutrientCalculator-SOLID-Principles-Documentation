using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFoodNutrientCalculator
{
    /// <summary>
    /// Handles user interactions
    /// </summary>
    public class UserInteraction
    {
       int userInputInt;

        PetRepository petRepository = new PetRepository();
        InputValidator inputValidator = new InputValidator(); 

        /// <summary>
        /// Starts user interaction. Provides user the possibility to add a pet, choose a pet 
        /// or close the solution
        /// </summary>
        public void StartUserInteraction()
        {
            WriteUserOptions();

            string userInputString = Console.ReadLine();

            if(inputValidator.UserInputValidation(userInputString))
            {
                userInputInt = int.Parse(userInputString);
                SwitchFunctionality(userInputInt); 
            }
            else
            {
                StartUserInteraction();
            }
        }

        /// <summary>
        /// Writes the available options for the user to the console
        /// </summary>
        private void WriteUserOptions()
        {
            Console.WriteLine("Valitse 1 mikäli haluat lisätä lemmikin.");
            Console.WriteLine("Valitse 2 mikäli haluat valita lemmikin listalta");
            Console.WriteLine("Valitse 3 mikäli haluat sulkea sovelluksen");
        }

        // TODO complete method for functionality and funtionality methods 
        public void SwitchFunctionality(int functionality)
        {
            switch (functionality)
            {
                case 1:
                    petRepository.AddPet();
                    break;
                default:
                case 2: 
                    // add method to choosing from a list of pets 
                    break;
                case 3:
                    break;
            }
        }
    }
}



