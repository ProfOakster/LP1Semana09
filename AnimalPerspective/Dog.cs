using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalPerspective
{
    public class Dog : Animal, IMammal
    {
        public int NumberOfNipples { get; }

        public Dog()
        {
            NumberOfNipples = 10;
        }
        public override string Sound()
        {
            return base.Sound() + "Woof";
        }
    }
}