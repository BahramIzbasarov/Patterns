using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public abstract class Carnivore
    {
        private int power;

        public int Power
        {
            get => power;
            set => power = value;
        }

        public abstract void Eat(Carnivore carn, Herbivore herb);

    }
}
