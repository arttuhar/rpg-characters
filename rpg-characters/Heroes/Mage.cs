﻿using System;
using rpg_characters.Items;

namespace rpg_characters.Heroes
{
    public class Mage : Hero
    {
        public Mage(string name) : base(name, 1, 1, 8)
        {
            HeroClass = HeroClasses.Mage;
        }

        public override void LevelUp()
        {
            BasePrimaryAttributes.Strength += 1;
            BasePrimaryAttributes.Dexterity += 1;
            BasePrimaryAttributes.Intelligence += 5;
            CurrentLevel++;
        }

        public override void EquipWeapon(Weapon weapon)
        {
            Equipment[weapon.Slot] = weapon;
        }
    }
}
