using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Eurasia : Continent
    {
        public override Herbivore newHerbivore()
        {
            Herbivore herbivore = new Elk();
            return herbivore;
        }

        public override Carnivore newCarnivore()
        {
            Carnivore carnivore = new Tiger();
            return carnivore;
        }
    }
}
