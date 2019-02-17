using Characters.Warriors;
using Weapons;
using System;

public class EntryPoint
{
    static void Main()
    {
        Warrior theGoodGuy = new Warrior(190, 80, "Good Guy");
        Warrior theBadGuy = new Warrior(170, 80, "Bad Guy");

        Warrior theTestGuyWhoLooksLikeTotallyBadass = new Warrior(100, 150, "BadAss 4rcz!k");
        Warrior theTestGuyWhoLooksLikeTotallyBadassTwin = new Warrior(101, 149, "BadAss 4rcz!k evil twin", 76, new Sword(29));

        //wojownik z deafultowymi wartosciami
        theTestGuyWhoLooksLikeTotallyBadass.WhoAmI();
        theTestGuyWhoLooksLikeTotallyBadass.HowMuchDemageCanICause();
        theTestGuyWhoLooksLikeTotallyBadass.AbilityOfMySwordToKillDragons();

        //wojownik z podanymi wartosciami
        theTestGuyWhoLooksLikeTotallyBadassTwin.WhoAmI();
        theTestGuyWhoLooksLikeTotallyBadassTwin.HowMuchDemageCanICause();
        theTestGuyWhoLooksLikeTotallyBadassTwin.AbilityOfMySwordToKillDragons();




        //Console.WriteLine(theGoodGuy.SwordWeapon.Damage);
        //Console.WriteLine(theBadGuy.Height);
        //Console.WriteLine(theGoodGuy.Height);



        //Console.WriteLine(theGoodGuy.Age);
        //Console.WriteLine(theBadGuy.Age);

        //try
        //{
        //    theGoodGuy.Age = 25;
        //    theBadGuy.Age = 15;
        //}
        //catch (ArgumentOutOfRangeException ex)
        //{

        //    Console.WriteLine(ex.Message);
        //}

        //theGoodGuy.Greetings("Tod");
        //theBadGuy.Greetings(theGoodGuy);

        //Console.WriteLine(theGoodGuy.SwordWeapon.Damage);

        //Console.ReadKey();
    }
    
}