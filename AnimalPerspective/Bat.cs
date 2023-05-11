using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalPerspective
{
    public class Bat : Animal, IMammal
    {
        public int NumberOfNipples { get; }

        public Bat()
        {
            NumberOfNipples = 2;
        }
        public override string Sound()
        {
            return base.Sound() + "<SCREECH>";
        }
    }
}