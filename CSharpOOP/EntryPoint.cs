using Characters.Warriors;
using System;

public class EntryPoint
{
    static void Main()
    {
        Warrior firstWarrior = new Warrior();
        Console.WriteLine(Warrior.idCounter);

        Warrior secondWarrior = new Warrior(200, 20);
        Console.WriteLine(Warrior.idCounter);

        Warrior thirdWarrior = new Warrior(300, 30, "I am the third Warrio!");
        Console.WriteLine(Warrior.idCounter);

        //Warrior theGoodGuy = new Warrior(190, 80, "Good Guy");
        //Warrior theBadGuy = new Warrior(170, 80, "Bad Guy");

        //Warrior youngWarrior = new Warrior(150, 50);
        //youngWarrior.Age = 18;
        //Console.WriteLine(youngWarrior.Age);

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

        Console.ReadKey();
    }
    
}