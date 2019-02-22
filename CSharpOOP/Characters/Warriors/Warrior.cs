using System;
using Weapons;

namespace Characters.Warriors
{
    public class Warrior
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
        private int weight;
        private int age;
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
            : this(height, weight, DEFAULT_NAME)
        {

        }
        public Warrior(int height, int weight, string name)
        {
            idCounter++;
            this.id = IdCounter;
            this.Height = height;
            this.Weight = weight;
            this.Name = name;
            this.Age = DEFAULT_AGE;
            this.SwordWeapon = DEFAULT_SWORD_WEAPON;
        }

        public Warrior(int height, int age, int weight, string name, Sword swordWeapon)
        {
            Height = height;
            Age = age;
            Weight = weight;
            Name = name;
            SwordWeapon = swordWeapon;
        }




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
    
    }
}