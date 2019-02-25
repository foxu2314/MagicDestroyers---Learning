using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP.Characters.Spellcasters
{
    class Mage : Character, ICalculator
    {
        public override int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value >= 30 && value <= 60)
                {
                    this.age = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Please put age betweeb 30 and 60");
                }
            }
        }

        public void Addition(int firstNumber, int secondNumber)
        {
            int sum = firstNumber + secondNumber;
            int modifiedSum = sum + 123;
            Console.WriteLine(modifiedSum-123);
        }
    }
}
