using System;

namespace Characters.Warriors
{
    public class Warrior
    {
        private int height;
        private int weight;
        private int age;
        private string name;

        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value>=18 && value<=45)
                {
                    age = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, $@"The selected age for {name} is not a proper for a warrior. The age must be between 18 and 45");
                }
                
            }
        }
        public int Weight { get; set; }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public Warrior(int height, int weight, string name)
        {
            this.Height = height;
            this.Weight = weight;
            this.Name = name;
        }

        public void Greetings(Warrior warrior)
        {
            Console.WriteLine($"Greetings {warrior.Name}!");
        }
    }
}