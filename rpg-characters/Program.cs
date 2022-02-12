using System;
using rpg_characters.Heroes;
using rpg_characters.Helpers;

namespace rpg_characters
{
    class Program
    {
        static void Main(string[] args)
        {
            Mage mageHero = new("Arttu the Mage");
            Console.WriteLine($"{mageHero.HeroName}, {mageHero.HeroClass}, Level {mageHero.CurrentLevel}");
            Console.WriteLine($"{mageHero.BasePrimaryAttributes.Strength}, {mageHero.BasePrimaryAttributes.Dexterity}, {mageHero.BasePrimaryAttributes.Intelligence}\n");

            Ranger rangerHero = new("Arttu the Ranger");
            Console.WriteLine($"{rangerHero.HeroName}, {rangerHero.HeroClass}, Level {rangerHero.CurrentLevel}");
            Console.WriteLine($"{rangerHero.BasePrimaryAttributes.Strength}, {rangerHero.BasePrimaryAttributes.Dexterity}, {rangerHero.BasePrimaryAttributes.Intelligence}\n");

            Rogue rogueHero = new("Arttu the Rogue");
            Console.WriteLine($"{rogueHero.HeroName}, {rogueHero.HeroClass}, Level {rogueHero.CurrentLevel}");
            Console.WriteLine($"{rogueHero.BasePrimaryAttributes.Strength}, {rogueHero.BasePrimaryAttributes.Dexterity}, {rogueHero.BasePrimaryAttributes.Intelligence}\n");

            Warrior warriorHero = new("Arttu the Warrior");
            Console.WriteLine($"{warriorHero.HeroName}, {warriorHero.HeroClass}, Level {rogueHero.CurrentLevel}");
            Console.WriteLine($"{warriorHero.BasePrimaryAttributes.Strength}, {warriorHero.BasePrimaryAttributes.Dexterity}, {warriorHero.BasePrimaryAttributes.Intelligence}");

        }
    }
}
