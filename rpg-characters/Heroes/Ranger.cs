using System;

namespace rpg_characters.Heroes
{
    public class Ranger : Hero
    {
        public Ranger(string name) : base(name)
        {
            HeroClass = HeroClasses.Ranger;
        }
    }
}
