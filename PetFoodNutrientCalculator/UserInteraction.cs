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

        bool userInputIsValid = false;
        int userInputInt;
        
        PetRepository petRepository = new PetRepository();

        // TODO simplify this method for better readability and maintainability 
        /// <summary>
        /// Method to start the user interaction loop
        /// </summary>
        public void Start()
        {
            while (!userInputIsValid)
            {
                Console.WriteLine("Valitse 1 mikäli haluat lisätä lemmikin.");
                Console.WriteLine("Valitse 2 mikäli haluat valita lemmikin listalta");
                Console.WriteLine("Valitse 3 mikäli haluat sulkea sovelluksen");

                string userInputString = Console.ReadLine();

                try
                {
                    userInputInt = int.Parse(userInputString);

                    if (userInputInt == 1 || userInputInt == 2 || userInputInt == 3)
                    {
                        userInputIsValid = true;
                    }
                    else
                    {
                        Console.WriteLine("Syöte virheellinen, valitse kokonaisluku 1, 2 tai 3");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Syöte virheellinen, valitse kokonaisluku 1, 2 tai 3.");
                }

            }

            switch (userInputInt)
            {
                case 1:
                    petRepository.AddPet();
                    userInputIsValid = false;
                    break;  
            }
        }
    }
}



