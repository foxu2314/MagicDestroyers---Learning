using CSharpOOP.Characters;
using Enumarations;
using Interfaces;
using System;
using Weapons;

namespace Characters.Warriors
{
    public class Warrior : Melee, ICalculator
    {
        #region Fields

        private const int DEFAULT_HEIGHT = 170;
        private const int DEFAULT_WEIGHT = 70;
        private const int DEFAULT_AGE = 18;
        private const string DEFAULT_NAME = "Young Warrior";

        private readonly Sword DEFAULT_SWORD_WEAPON = new Sword();

        private static int idCounter;
        private readonly int id;
        private int height;
        private Faction faction;
        private string name;
        private Sword swordWeapon;

        #endregion

        #region Properties

        public static int IdCounter
        {
            get
            {
                return idCounter;
            }
            private set
            {
                idCounter = value;
            }
        }
        public int ID
        {
            get
            {
                return id;
            }
           
        }

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
        public Faction Faction
        {
            get
            {
                return this.faction;
            }
            private set
            {
                this.faction = value;
            }
        }
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
        public Sword SwordWeapon
        {
            get
            {
                return this.swordWeapon;
            }
            set
            {
                this.swordWeapon = value;
            }
        }
        #endregion

        #region Constructors

        public Warrior()
            : this (DEFAULT_HEIGHT, DEFAULT_WEIGHT)
        {

        }
        public Warrior(int height, int weight)
            : this(height, weight, DEFAULT_NAME, Faction.Default)
        {

        }
        public Warrior(int height, int weight, string name, Faction faction)
        {
            idCounter++;
            this.id = IdCounter;
            this.Height = height;
            base.Weight = weight;
            this.Name = name;
            this.Faction = faction;
            base.Age = DEFAULT_AGE;
            this.SwordWeapon = DEFAULT_SWORD_WEAPON;

            if (this.Faction == Faction.GoodGuy)
            {
                base.HealthPoints = 120;
            }
            else if (this.Faction == Faction.BadGuy)
            {
                base.HealthPoints = 100;
            }

        }

        public Warrior(int healthPoints, int weight, int age, int height)
            : base (healthPoints, weight, age)
        {
            this.Height = height;
        }

        //public Warrior(int height, int age, int weight, string name, Sword swordWeapon)
        //{
        //    Height = height;
        //    Age = age;
        //    Weight = weight;
        //    Name = name;
        //    SwordWeapon = swordWeapon;
        //}




        #endregion

        public void Greetings(string name)
        {
            Console.WriteLine($@"{this.name} greets {name}!");
        }

        public static void GetDefaultValues(Warrior warrior)
        {
            Console.WriteLine($"The default height: {DEFAULT_HEIGHT}" +
                $"\nThe default weight: {DEFAULT_WEIGHT}" +
                $"\nThe default age: {DEFAULT_AGE}" +
                $"\nThe default name: {DEFAULT_NAME}" +
                $"\nThe default Weapon Damage: {warrior.DEFAULT_SWORD_WEAPON.Damage}");


        }

        public override void Move(int pauseBetweenMovements)
        {
            base.Move(pauseBetweenMovements);
            Console.WriteLine("I just moved 10 times, I am a Warrior");
        }

        public override void Addition(int firstNumber, int secondNumber)
        {
            Console.WriteLine(firstNumber + secondNumber);
        }
    }
}