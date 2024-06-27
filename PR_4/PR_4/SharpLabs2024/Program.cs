using System;
using System.Collections.Generic;
using System.Text;
using CSharpLabs2024.Spells;
using CSharpLabs2024.Mages;
using CSharpLabs2024;

internal class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        Mage player = ChooseMage();
        Mage bot = RandomMage();

        Console.Clear();
        player.ShowStats();
        bot.ShowStats();

        List<ISpell> playerSpells = GetSpellsForMage(player);
        List<ISpell> botSpells = GetSpellsForMage(bot);

        Random rnd = new Random();

        while (player.Hp > 0 && bot.Hp > 0)
        {
            Console.WriteLine("\nНатисніть будь-яку клавішу, щоб продовжити...");
            Console.ReadKey();
            Console.Clear();
            PlayerTurn(player, bot, playerSpells);
            if (bot.Hp > 0)
            {
                BotTurn(bot, player, botSpells, rnd);
            }
        }

        Console.WriteLine(player.Hp > 0 ? "\nГравець переміг!" : "\nБот переміг!");
        Console.ReadLine();
    }

    static List<ISpell> GetSpellsForMage(Mage mage)
    {
        if (mage is FireMage)
        {
            return new List<ISpell> { new FireBall(), new FireBlast() };
        }
        else if (mage is WaterMage)
        {
            return new List<ISpell> { new WaterGun(), new WaterPulse() };
        }
        else
        {
            return new List<ISpell>();
        }
    }

    static Mage ChooseMage()
    {
        Console.WriteLine("Введіть ваше ім'я:");
        string playerName = Console.ReadLine();

        Console.WriteLine("Виберіть мага:");
        Console.WriteLine("1. FireMage");
        Console.WriteLine("2. WaterMage");

        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                switch (choice)
                {
                    case 1:
                        return new FireMage(playerName, 90, 100);
                    case 2:
                        return new WaterMage(playerName, 100, 120);
                    default:
                        Console.WriteLine("Неправильний вибір. Спробуйте знову.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Неправильне введення. Спробуйте знову.");
            }
        }
    }

    static Mage RandomMage()
    {
        Random rnd = new Random();
        return rnd.Next(2) == 0 ? new FireMage("Fire Bot", 90, 100) : new WaterMage("Water Bot", 100, 120);
    }

    static void PlayerTurn(Mage player, Mage bot, List<ISpell> spells, bool isEror = false)
    {
        Console.Clear();
        player.ShowStats();
        bot.ShowStats();



        if (isEror)
        {
            Console.WriteLine("\nНеправильне введення. Спробуйте знову.");
        }

        Console.WriteLine("\nВведіть 'A' для атаки або 'D' для захисту:");

        char input = Console.ReadKey().KeyChar;
        Console.WriteLine();

        switch (input)
        {
            case 'A':
            case 'a':
                CastSpellMenu(player, bot, spells);
                break;
            case 'D':
            case 'd':
                player.Defend();
                break;
            default:
                PlayerTurn(player, bot, spells, true);
                break;
        }
    }

    static void CastSpellMenu(Mage player, Mage bot, List<ISpell> spells)
    {
        Console.WriteLine("Виберіть заклинання:");
        for (int i = 0; i < spells.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {spells[i].GetType().Name} (Шкода: {spells[i].Damage}, Вартість мани: {spells[i].ManaCost})");
        }

        if (int.TryParse(Console.ReadLine(), out int choice) && choice > 0 && choice <= spells.Count)
        {
            player.CastSpell(spells[choice - 1], bot);
        }
        else
        {
            Console.WriteLine("Неправильний вибір. Спробуйте знову.");
            CastSpellMenu(player, bot, spells);
        }
    }

    static void BotTurn(Mage bot, Mage player, List<ISpell> spells, Random rnd)
    {
        if (rnd.Next(2) == 0)
        {
            int spellIndex = rnd.Next(spells.Count);
            bot.CastSpell(spells[spellIndex], player);
        }
        else
        {
            bot.Defend();
        }
    }
}
