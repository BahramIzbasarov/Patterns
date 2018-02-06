using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace ConsoleApp5
{
    class Lion : Carnivore
    {
        public Lion(int power = 20)
        {
            Power = power;
        }

        public override void Eat(Carnivore carn, Herbivore herb)
        {
            if (carn.Power > herb.Weight)
            {
                carn.Power += 10;
                herb.Life = false;
            }
            else
            {
                carn.Power -= 10;
            }
        }
    }
}
