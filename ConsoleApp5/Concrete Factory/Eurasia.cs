using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Eurasia : Continent
    {
        public override void newHerbivore()
        {
            Herbivore herbivore = new Elk();
        }

        public override void newCarnivore()
        {
            Carnivore carnivore = new Tiger();
        }
    }
}
