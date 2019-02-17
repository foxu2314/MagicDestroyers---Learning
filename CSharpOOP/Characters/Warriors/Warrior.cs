using System;
using Weapons;

namespace Characters.Warriors
{
    public class Warrior:Sword  //dziedziczenie po klasie, w tym przypadku tak musisz zrobic, do poczytania dlaczego ;p
    {
        private int height;
        private int weight;
        private int age;
        private string name;
        private Sword swordWeapon;

        
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
   

        

        public Warrior(int height, int weight, string name, int damageNEW=0, Sword nowyMiecz = null)//2 ostatnie argumenty opcjonalne
        {
            this.Height = height;
            this.Weight = weight;
            this.Name = name;
            if(damageNEW != 0) //jak nie podasz sily bojowej przy tworzeniu woojownika to bedzie deafultowo 69 
                //tak jak ustawlismy w klasie Sword
                this.damagaeNew = damageNEW; //tu mozesz skorzystac z tego pola mimo ze nie jest w proporties w klasie Sword
            if (nowyMiecz == null)
                this.SwordWeapon = new Sword();
            else
                this.SwordWeapon = nowyMiecz;
        }


        public void Greetings(string name)
        {
            Console.WriteLine($@"{this.name} greets {name}!");
        }

        public void WhoAmI()
        {
            Console.WriteLine($@"Wojownik: {this.name} o wzroście {this.height} i wadze {Weight}");
            Console.WriteLine("\n");
            Console.ReadKey();
        }

        public void HowMuchDemageCanICause()
        {
            Console.WriteLine($@"Jego siła bojowa to : {this.damagaeNew} (mimo ze tego pola nie ma w properties)");
            Console.WriteLine("\n");
            Console.ReadKey();
        }

        public void AbilityOfMySwordToKillDragons()
        {
            Console.WriteLine($@"Parametry mojego miecza(bez skojarzen xd) : {this.swordWeapon.Damage}");
            Console.WriteLine("\n");
            Console.ReadKey();
        }


    }
}