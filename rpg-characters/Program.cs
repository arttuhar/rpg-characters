using System;
using rpg_characters.Heroes;

namespace rpg_characters
{
    class Program
    {
        static void Main(string[] args)
        {
            Mage mageHero = new("Mage");
            mageHero.DisplayStats();
        }
    }
}
