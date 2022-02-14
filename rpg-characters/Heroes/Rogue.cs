using System;
using rpg_characters.Items;

namespace rpg_characters.Heroes
{
    public class Rogue : Hero
    {
        public Rogue(string name) : base(name, 2, 6, 1)
        {
            HeroClass = HeroClasses.Rogue;
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

        public override void EquipArmor(Armor armor)
        {
            Equipment[armor.Slot] = armor;
        }
    }
}
