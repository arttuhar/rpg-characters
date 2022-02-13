using System;
using System.Collections.Generic;
using rpg_characters.Helpers;
using rpg_characters.Items;

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
        public HeroClasses HeroClass { get; set; }
        public int CurrentLevel { get; set; }
        public PrimaryAttributes BasePrimaryAttributes { get; set; }
        public Dictionary<ItemSlot, Item> Equipment { get; set; }

        public Hero(string name, int strength, int dexterity, int intelligence)
        {
            HeroName = name;
            CurrentLevel = 1;
            BasePrimaryAttributes = new PrimaryAttributes() { Strength = strength, Dexterity = dexterity, Intelligence = intelligence };
            Equipment = new Dictionary<ItemSlot, Item>();
        }

        public abstract void LevelUp();

        public void EquipItem(ItemSlot itemSlot, Item item)
        {
            Equipment.Add(itemSlot, item);
        }
        
        public abstract void EquipWeapon(Weapon weapon);
        
    }
}
