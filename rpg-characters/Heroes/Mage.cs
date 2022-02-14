using System;
using rpg_characters.CustomExceptions;
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
            if (weapon.WeaponType != WeaponType.WEAPON_STAFF || weapon.WeaponType != WeaponType.WEAPON_WAND)
            {
                throw new InvalidWeaponException("Invalid weapon type!");
            }

            Equipment[weapon.Slot] = weapon;
        }

        public override void EquipArmor(Armor armor)
        {
            Equipment[armor.Slot] = armor;
            TotalPrimaryAttributes = BasePrimaryAttributes + ArmorAttributes();
        }
    }
}
