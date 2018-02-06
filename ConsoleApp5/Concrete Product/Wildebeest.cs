using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Wildebeest : Herbivore
    {
        public Wildebeest(int weight = 15, bool life = true)
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
