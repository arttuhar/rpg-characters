using System;
using rpg_characters.CustomExceptions;
using rpg_characters.Items;

namespace rpg_characters.Heroes
{
    public class Warrior : Hero
    {
        public Warrior(string name) : base(name, 5, 2, 1)
        {
            HeroClass = HeroClasses.Warrior;
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
            if (weapon.WeaponType != WeaponType.WEAPON_AXE || weapon.WeaponType != WeaponType.WEAPON_HAMMER || weapon.WeaponType != WeaponType.WEAPON_SWORD)
            {
                throw new InvalidWeaponException("Invalid weapon type!");
            }

            Equipment[weapon.Slot] = weapon;
        }

        public override void EquipArmor(Armor armor)
        {
            Equipment[armor.Slot] = armor;
        }
    }
}
