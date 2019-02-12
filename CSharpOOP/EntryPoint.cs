using Characters.Warriors;
using System;

public class EntryPoint
{
    static void Main()
    {
        Warrior theGoodGuy = new Warrior(190, 80, "Good Guy");
        Warrior theBadGuy = new Warrior(170, 80, "Bad Guy");

        //Console.WriteLine(theBadGuy.Height);
        //Console.WriteLine(theGoodGuy.Height);

        

        Console.WriteLine(theGoodGuy.Age);
        Console.WriteLine(theBadGuy.Age);

        try
        {
            theGoodGuy.Age = 25;
            theBadGuy.Age = 15;
        }
        catch (ArgumentOutOfRangeException ex)
        {

            Console.WriteLine(ex.Message);
        }

        //theGoodGuy.Greetings(theBadGuy);
        //theBadGuy.Greetings(theGoodGuy);

        Console.ReadKey();
    }
}