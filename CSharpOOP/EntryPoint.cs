using Characters.Warriors;
using System;

public class EntryPoint
{
    static void Main()
    {
        Warrior theGoodGuy = new Warrior(190, 80, "Good Guy");
        Warrior theBadGuy = new Warrior(170, 80, "Bad Guy");

        Console.WriteLine(theBadGuy.Height);
        Console.WriteLine(theGoodGuy.Height);

        theGoodGuy.Greetings(theBadGuy);
        theBadGuy.Greetings(theGoodGuy);
    }
}