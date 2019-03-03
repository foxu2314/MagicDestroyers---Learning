using Characters.Warriors;
using CSharpOOP;
using CSharpOOP.Characters;
using CSharpOOP.Characters.Spellcasters;
using Enumarations;
using Interfaces;
using System;
using System.Collections.Generic;

public class EntryPoint
{
    static void Main()
    {
        Warrior firstWarrior = new Warrior(150, 50, "SomeName", Faction.BadGuy);
        Mage firstMage = new Mage();

        Console.WriteLine(firstWarrior.Addition(5, 5));

        Character secondWarrior = new Warrior();

        List<Character> theCharacters = new List<Character>();
        List<ICalculator> calculators = new List<ICalculator>();

        calculators.Add(firstWarrior);
        calculators.Add(firstMage);

        theCharacters.Add(firstWarrior);
        theCharacters.Add(firstMage);

        foreach (var character in theCharacters)
        {
            if (character is Warrior)
            {
                Warrior tempWarrior = character as Warrior;

                Console.WriteLine(tempWarrior.SwordWeapon.Damage);
            }
        }

        Console.WriteLine(firstWarrior.HealthPoints);
        Console.WriteLine(firstMage.Mana);

        firstMage.CastSpell(firstWarrior);

        Console.WriteLine(firstWarrior.HealthPoints);
        Console.WriteLine(firstMage.Mana);

        PerformGreeting(theCharacters);

        Character[] theCharactersAgain = new Character[2];

        theCharactersAgain[0] = firstMage;
        theCharactersAgain[1] = firstWarrior;

        PerformGreeting(theCharactersAgain);
    }

    public static void PerformGreeting(IEnumerable<Character> characters)
    {
        foreach (var item in characters)
        {
            item.Greetings("Tod");
        }
    }
}