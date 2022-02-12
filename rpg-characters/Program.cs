using System;
using rpg_characters.Heroes;

namespace rpg_characters
{
    class Program
    {
        static void Main(string[] args)
        {
            Mage mageHero = new Mage("Arttu the Mage");
            Console.WriteLine(mageHero.HeroName);
            Console.WriteLine(mageHero.HeroClass);

            Ranger rangerHero = new Ranger("Arttu the Ranger");
            //Console.WriteLine(rangerHero.heroName);

            Rogue rogueHero = new Rogue("Arttu the Rogue");
            //Console.WriteLine(rogueHero.heroName);

            Warrior warriorHero = new Warrior("Arttu the Warrior");
            //Console.WriteLine(warriorHero.heroName);
        }
    }
}
