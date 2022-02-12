using System;
namespace rpg_characters.Heroes
{
    public class Warrior : Hero
    {
        public Warrior(string name) : base(name, 5, 2, 1)
        {
            HeroClass = HeroClasses.Warrior;
        }
    }
}
