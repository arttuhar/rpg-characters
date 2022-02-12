using System;
namespace rpg_characters.Heroes
{
    public class Rogue : Hero
    {
        public Rogue(string name) : base(name)
        {
            HeroClass = HeroClasses.Rogue;
        }
    }
}
