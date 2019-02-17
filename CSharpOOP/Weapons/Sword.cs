
namespace Weapons
{
    public class Sword
    {
        private int damage;

        protected int damagaeNew=69; //nowe pole ktore ma access modifier 'protected', tzn ze masz do neigo dostep
                                     //w tej klasie(Sword) oraz w Klasie ktora dziedziczy po klasie Sword czyli Warrior
                                     //inicjalizujemy wartoscia 69

        //note that: od c# 6.0(od viual studio chyba 2015) mozesz inicjalizowac properties, 
        //w poprzednich wersjach mozesz to zrobic dopiero w konstruktorze np:
        public int MyProperty1 { get; set; } = 80;



        public int Damage
        {
            get
            {
                return this.damage;
            }

            private set
            {
                this.damage = value;
            }
        }

        public Sword()
        {
            this.Damage = 10; //jak nie podamy przy kontrukcji miecza to deafultowo 10
        }
        public Sword(int _sword)//2 konstruktor z parametrem, jka podamy to wartosc
        {
            this.Damage = _sword;
        }

    }
}
