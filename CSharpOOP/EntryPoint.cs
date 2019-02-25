using Characters.Warriors;
using CSharpOOP;
using CSharpOOP.Characters.Spellcasters;
using Enumarations;
using System;

public class EntryPoint
{
    static void Main()
    {
        Warrior firstWarrior = new Warrior(150, 50, "SomeName", Faction.BadGuy);
        Mage firstMage = new Mage();

        Console.WriteLine(firstWarrior.HealthPoints);
        Console.WriteLine(firstMage.Mana);

        firstMage.CastSpell(firstWarrior);

        Console.WriteLine(firstWarrior.HealthPoints);
        Console.WriteLine(firstMage.Mana);

        //try
        //{
        //    firstWarrior.Age = 15;
        //    firstMage.Age = 25;
        //}
        //catch (ArgumentOutOfRangeException ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}

        Console.ReadKey();

        // Warrior.GetDefaultValues(firstWarrior);

        //Tools.ColorfulWriteLines(firstWarrior.ID.ToString(), ConsoleColor.Cyan);
        //Tools.ColorfulWriteLines(secondWarrior.ID.ToString(), ConsoleColor.DarkYellow);
        //Tools.ColorfulWriteLines(thirdWarrior.ID.ToString(), ConsoleColor.Red);

        //firstWarrior.Move(500);
    }

}