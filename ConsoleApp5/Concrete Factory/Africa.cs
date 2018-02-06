using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Africa : Continent
    {
        public override void newHerbivore()
        {
            Herbivore herbivore = new Wildebeest();
        }

        public override void newCarnivore()
        {
            Carnivore carnivore = new Lion();
        }
    }
}
