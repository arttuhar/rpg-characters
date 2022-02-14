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
            if (weapon.WeaponType != WeaponType.WEAPON_AXE && weapon.WeaponType != WeaponType.WEAPON_HAMMER && weapon.WeaponType != WeaponType.WEAPON_SWORD)
            {
                throw new InvalidWeaponException("Invalid weapon type!");
            }

            double weaponBonus = 1 + TotalPrimaryAttributes.Intelligence / 100.00;

            Equipment[weapon.Slot] = weapon;
            HeroDamage = DamagePerSecond() * weaponBonus;
        }

        public override void EquipArmor(Armor armor)
        {
            if (armor.ArmourType != ArmourType.ARMOUR_MAIL && armor.ArmourType != ArmourType.ARMOUR_PLATE)
            {
                throw new InvalidArmorException("Invalid armor type!");
            }

            Equipment[armor.Slot] = armor;
            TotalPrimaryAttributes = BasePrimaryAttributes + ArmorAttributes();
        }
    }
}
