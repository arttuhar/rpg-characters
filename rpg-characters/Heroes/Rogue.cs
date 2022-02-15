using System;
using rpg_characters.CustomExceptions;
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
            BasePrimaryAttributes.Dexterity += 4;
            BasePrimaryAttributes.Intelligence += 1;
            CurrentLevel++;
        }

        public override void EquipWeapon(Weapon weapon)
        {
            if (weapon.WeaponType != WeaponType.WEAPON_DAGGER && weapon.WeaponType != WeaponType.WEAPON_SWORD)
            {
                throw new InvalidWeaponException("Invalid weapon type");
            }

            if (weapon.ItemLevel > CurrentLevel)
            {
                throw new InvalidWeaponException("Invalid hero level");
            }

            double weaponBonus = 1 + TotalPrimaryAttributes.Intelligence / 100.00;

            Equipment[weapon.Slot] = weapon;
            HeroDamage = DamagePerSecond() * weaponBonus;
        }

        public override void EquipArmor(Armor armor)
        {
            if (armor.ArmourType != ArmourType.ARMOUR_LEATHER && armor.ArmourType != ArmourType.ARMOUR_MAIL)
            {
                throw new InvalidArmorException("Invalid armor type");
            }

            if (armor.ItemLevel > CurrentLevel)
            {
                throw new InvalidArmorException("Invalid hero level");
            }

            Equipment[armor.Slot] = armor;
            TotalPrimaryAttributes = BasePrimaryAttributes + ArmorAttributes();
        }
    }
}
