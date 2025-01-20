using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFoodNutrientCalculator
{
    public class PetRepository
    {
        public List<Pet> Pets { get; private set; }

        public PetRepository()
        {
            Pets = new List<Pet>();
        }
    }
}
