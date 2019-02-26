using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP.Characters
{
    public abstract class Melee : Character
    {
        public Melee()
        {

        }

        public Melee(int healthPoints, int weight, int age)
            : base(healthPoints, weight, age)
        {

        }
    }
}
