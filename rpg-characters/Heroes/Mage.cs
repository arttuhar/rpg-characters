using System;

namespace rpg_characters.Heroes
{
    public class Mage : Hero
    {
        public Mage(string name) : base(name)
        {
            HeroClass = heroClasses.Mage;
        }
    }
}
