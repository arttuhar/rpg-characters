using System;
using rpg_characters.Helpers;

namespace rpg_characters.Heroes
{
    public enum HeroClasses
    {
        Mage,
        Ranger,
        Rogue,
        Warrior
    }

    public abstract class Hero
    {
        public string HeroName { get; set; }
        //public string HeroName { get => heroName; set => heroName = value; }

        public HeroClasses HeroClass { get; set; }
        //public HeroClasses HeroClass { get => heroClass; set => heroClass = value; }

        public int CurrentLevel { get; set; }
        //public int CurrentLevel { get => currentLevel; set => currentLevel = value; }

        public PrimaryAttributes BasePrimaryAttributes { get; set; }

        public Hero(string name, int strength, int dexterity, int intelligence)
        {
            HeroName = name;
            CurrentLevel = 1;
            BasePrimaryAttributes = new PrimaryAttributes() { Strength = strength, Dexterity = dexterity, Intelligence = intelligence };
        }

        public abstract void LevelUp();

    }
}
