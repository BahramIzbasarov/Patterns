using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class NorthAmerica : Continent
    {
        public override Herbivore newHerbivore()
        {
            Herbivore herbivore = new Bison();
            return herbivore;
        }

        public override Carnivore newCarnivore()
        {
            Carnivore carnivore = new Wolf();
            return carnivore;
        }
    }
}
