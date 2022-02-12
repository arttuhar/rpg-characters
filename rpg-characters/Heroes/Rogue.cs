using System;
namespace rpg_characters.Heroes
{
    public class Rogue : Hero
    {
        public Rogue(string name) : base(name, 2, 6, 1)
        {
            HeroClass = HeroClasses.Rogue;
        }
    }
}
