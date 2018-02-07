using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Africa : Continent
    {
        public override Herbivore newHerbivore()
        {
            Herbivore herbivore = new Wildebeest();
            Console.WriteLine("Wildwest created");
            return herbivore;
        }

        public override Carnivore newCarnivore()
        {
            Carnivore carnivore = new Lion();
            Console.WriteLine("Lion created");
            return carnivore;
        }
    }
}
