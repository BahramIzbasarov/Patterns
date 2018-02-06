using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public abstract class Herbivore
    {
        private int weight;
        private bool life;

        public int Weight
        {
            get => weight;
            set => weight = value;
        }

        public bool Life
        {
            get => life;
            set => life = value;
        }

        public abstract void EatGrass();
    }
}
