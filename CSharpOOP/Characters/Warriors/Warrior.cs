using System;

namespace Characters.Warriors
{
    public class Warrior
    {
        private int height;
        private int weight;
        private string name;

        public int Height { get; set; }
        public int Weight { get; set; }
        public string Name { get; set; }

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