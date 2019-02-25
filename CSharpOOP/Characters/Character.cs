using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpOOP.Characters
{
    public class Character : ICalculator
    {
        private int healthPoints;
        private int weight;

        protected int age;

        public int HealthPoints
        {
            get
            {
                return this.healthPoints;
            }
            set
            {
                this.healthPoints = value;
            }
        }

        public int Weight
        {
            get
            {
                return this.weight;
            }
            set
            {
                this.weight = value;
            }
        }

        public virtual int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value >= 18 && value <= 45)
                {
                    this.age = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Please put age betweeb 18 and 45");
                }
            }
        }

        public Character()
        {

        }

        public Character(int healthPoints, int weight, int age)
        {
            this.HealthPoints = healthPoints;
            this.Weight = weight;
            this.Age = age;
        }

        public virtual void Move(int pauseBetweenMovements)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("I am moving");
                Thread.Sleep(pauseBetweenMovements);
            }
        }

        public abstract int Addition(int firstNumber, int secondNumber);

    }
}
