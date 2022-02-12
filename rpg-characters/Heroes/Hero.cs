using System;

namespace rpg_characters.Heroes
{
    public abstract class Hero
    {
        public string heroName;


        public Hero(string name)
        {
            heroName = name;
        }
    }
}
