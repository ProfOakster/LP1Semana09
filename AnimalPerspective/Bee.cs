using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalPerspective
{
    public class Bee : Animal, ICanFly
    {
        public int NumberOfWings { get; }

        public Bee()
        {
            NumberOfWings = 4;
        }

        public override string Sound()
        {
            return base.Sound() + "<Buzz>";
        }
    }
}