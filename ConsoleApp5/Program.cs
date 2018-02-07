using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Africa afrika = new Africa();

            AnimalWorld am = new AnimalWorld();

            am.CreateCarnivore(afrika);

            am.MealsHerbivores(am.CreateHerbivore(afrika));
            am.NutritionCarnivores(am.CreateCarnivore(afrika), am.CreateHerbivore(afrika));
        }
    }
}
