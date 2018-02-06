using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class AnimalWorld
    {
        private Continent continent;

        public Continent Continent
        {
            get => continent;
            set => continent = value;
        }

        

        public void MealsHerbivores(Herbivore herbivore)
        {
            herbivore.EatGrass();
        }

        public void NutritionCarnivores(Carnivore carnivore, Herbivore herbivore)
        {
            carnivore.Eat(carnivore, herbivore);
        }
    }
}
