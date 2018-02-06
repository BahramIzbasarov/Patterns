using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Elk : Herbivore
    {
        public Elk(int weight = 25, bool life = true)
        {
            Weight = weight;
            Life = life;
        }

        public override void EatGrass()
        {
            Weight += 10;
        }
    }
}
