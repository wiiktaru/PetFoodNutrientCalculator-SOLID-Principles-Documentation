using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFoodNutrientCalculator
{
    public class UserInteraction
    {
        bool isValidInput = false;
        int userInput;

        public void Start()
        {
            while (!isValidInput)
            {
                Console.WriteLine("Valitse 1 mikäli haluat lisätä lemmikin.");
                Console.WriteLine("Valitse 2 mikäli haluat valita lemmikin listalta");
                Console.WriteLine("Valitse 3 mikäli haluat sulkea sovelluksen");

                string input = Console.ReadLine();

                try
                {
                    userInput = int.Parse(input);

                    if (userInput == 1 || userInput == 2 || userInput == 3)
                    {
                        isValidInput = true;
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
        }
    }
}



