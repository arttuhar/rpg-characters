using System;

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
        private string heroName;
        public string HeroName { get => heroName; set => heroName = value; }

        private HeroClasses heroClass;
        public HeroClasses HeroClass { get => heroClass; set => heroClass = value; }

        private int currentLevel;
        public int CurrentLevel { get => currentLevel; set => currentLevel = value; }

        public Hero(string name)
        {
            heroName = name;
            currentLevel = 1;
        }
    }
}
