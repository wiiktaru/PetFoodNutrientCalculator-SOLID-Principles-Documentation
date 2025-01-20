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

        /// <summary>
        /// Method to start the user interaction loop
        /// </summary>
        public void Start()
        {
                Console.WriteLine("Valitse 1 mikäli haluat lisätä lemmikin.");
                Console.WriteLine("Valitse 2 mikäli haluat valita lemmikin listalta");
                Console.WriteLine("Valitse 3 mikäli haluat sulkea sovelluksen");

                string userInputString = Console.ReadLine();

                UserInputValidation(userInputString);
        }

        public void UserInputValidation(string userInput)
        {
            if (int.TryParse(userInput, out int userInputInt))
            { 
                    if (userInputInt == 1 || userInputInt == 2 || userInputInt == 3)
                    {
                        SwitchFunctionality(userInputInt);
                    }     
            }
            else
            {
                Console.WriteLine("Syöte virheellinen, valitse kokonaisluku 1,2 tai 3");
                Start();
            }
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



