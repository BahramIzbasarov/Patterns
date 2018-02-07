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

        public Herbivore CreateHerbivore(Continent cont)
        {
            return cont.newHerbivore();
        }

        public Carnivore CreateCarnivore(Continent cont)
        {
            return cont.newCarnivore();
        }

        public void MealsHerbivores(Herbivore herbivore)
        {
            herbivore.EatGrass();
            Console.WriteLine("herbivore ate");
        }

        public void NutritionCarnivores(Carnivore carnivore, Herbivore herbivore)
        {
            carnivore.Eat(carnivore, herbivore);
            Console.WriteLine("carnivore ate");

        }
    }
}
