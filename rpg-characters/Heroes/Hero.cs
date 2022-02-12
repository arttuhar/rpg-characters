using System;

namespace rpg_characters.Heroes
{
    public enum heroClasses
    {
        Mage,
        Ranger,
        Rogue,
        Warrior
    }

    public abstract class Hero
    {
        private string heroName;
        public string HeroName { get => heroName; set => heroName = value ; }

        private heroClasses heroClass;
        public heroClasses HeroClass { get => heroClass; set => heroClass = value; }

        public Hero(string name)
        {
            heroName = name;
        }
    }
}
