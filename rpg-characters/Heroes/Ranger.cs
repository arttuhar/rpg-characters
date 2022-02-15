using System;
using rpg_characters.CustomExceptions;
using rpg_characters.Items;

namespace rpg_characters.Heroes
{
    public class Ranger : Hero
    {
        public Ranger(string name) : base(name, 1, 7, 1)
        {
            HeroClass = HeroClasses.Ranger;
        }

        public override void LevelUp()
        {
            BasePrimaryAttributes.Strength += 1;
            BasePrimaryAttributes.Dexterity += 5;
            BasePrimaryAttributes.Intelligence += 1;
            CurrentLevel++;
        }

        public override string EquipWeapon(Weapon weapon)
        {
            if (weapon.WeaponType != WeaponType.WEAPON_BOW)
            {
                throw new InvalidWeaponException("Invalid weapon type");
            }

            if (weapon.ItemLevel > CurrentLevel)
            {
                throw new InvalidWeaponException("Invalid hero level");
            }

            double weaponBonus = 1 + TotalPrimaryAttributes.Dexterity / 100.00;

            Equipment[weapon.Slot] = weapon;
            HeroDamage = DamagePerSecond() * weaponBonus;
            return "New weapon equipped!";
        }

        public override string EquipArmor(Armor armor)
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
            return "New armour equipped!";
        }
    }
}
