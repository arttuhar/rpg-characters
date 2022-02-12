using System;
using rpg_characters.Heroes;

namespace rpg_characters
{
    class Program
    {
        static void Main(string[] args)
        {
            Mage mageHero = new("Arttu the Mage");
            Console.WriteLine($"{mageHero.HeroName}, {mageHero.HeroClass}, Level {mageHero.CurrentLevel}\n");

            Ranger rangerHero = new("Arttu the Ranger");
            Console.WriteLine($"{rangerHero.HeroName}, {rangerHero.HeroClass}, Level {rangerHero.CurrentLevel}\n");

            Rogue rogueHero = new("Arttu the Rogue");
            Console.WriteLine($"{rogueHero.HeroName}, {rogueHero.HeroClass}, Level {rogueHero.CurrentLevel} \n");

            Warrior warriorHero = new("Arttu the Warrior");
            Console.WriteLine($"{warriorHero.HeroName}, {warriorHero.HeroClass}, Level {rogueHero.CurrentLevel}");
        }
    }
}
