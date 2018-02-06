using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class NorthAmerica : Continent
    {
        public override void newHerbivore()
        {
            Herbivore herbivore = new Bison();
        }

        public override void newCarnivore()
        {
            Carnivore carnivore = new Wolf();
        }
    }
}
