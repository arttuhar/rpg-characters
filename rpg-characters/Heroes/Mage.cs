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

        public override string EquipWeapon(Weapon weapon)
        {
            if (weapon.WeaponType != WeaponType.WEAPON_STAFF && weapon.WeaponType != WeaponType.WEAPON_WAND)
            {
                throw new InvalidWeaponException("Invalid weapon type");
            }

            if (weapon.ItemLevel > CurrentLevel)
            {
                throw new InvalidWeaponException("Invalid hero level");
            }

            Equipment[weapon.Slot] = weapon;
            SetDamage();
            return "New weapon equipped!";
        }

        public override string EquipArmor(Armor armor)
        {
            if (armor.ArmourType != ArmourType.ARMOUR_CLOTH)
            {
                throw new InvalidArmorException("Invalid armor type");
            }

            if (armor.ItemLevel > CurrentLevel)
            {
                throw new InvalidArmorException("Invalid hero level");
            }

            Equipment[armor.Slot] = armor;
            TotalPrimaryAttributes = BasePrimaryAttributes + ArmorAttributes();
            SetDamage();
            return "New armour equipped!";
        }
    }
}
