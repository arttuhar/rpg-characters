using System;
using rpg_characters.Heroes;

namespace rpg_characters
{
    class Program
    {
        static void Main(string[] args)
        {
            Mage mageHero = new Mage("Arttu the Mage");
            Console.WriteLine($"{mageHero.HeroName}, {mageHero.HeroClass}\n");

            Ranger rangerHero = new Ranger("Arttu the Ranger");
            Console.WriteLine($"{rangerHero.HeroName}, {rangerHero.HeroClass}\n");

            Rogue rogueHero = new Rogue("Arttu the Rogue");
            Console.WriteLine($"{rogueHero.HeroName}, {rogueHero.HeroClass}\n");

            Warrior warriorHero = new Warrior("Arttu the Warrior");
            Console.WriteLine($"{warriorHero.HeroName}, {warriorHero.HeroClass}");
        }
    }
}
