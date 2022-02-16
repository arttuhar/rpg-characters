using System;
using rpg_characters.CustomExceptions;
using rpg_characters.Items;

namespace rpg_characters.Heroes
{
    public class Warrior : Hero
    {
        /// <summary>
        /// Initialize warrior class hero
        /// </summary>
        /// <param name="name">Name of hero</param>
        public Warrior(string name) : base(name, 5, 2, 1)
        {
            HeroClass = HeroClasses.CLASS_WARRIOR;
        }

        /// <summary>
        /// Add gained points to base primary attributes, add level
        /// </summary>
        public override void LevelUp()
        {
            BasePrimaryAttributes.Strength += 3;
            BasePrimaryAttributes.Dexterity += 2;
            BasePrimaryAttributes.Intelligence += 1;
            CurrentLevel++;
        }

        /// <summary>
        /// Add weapon to weapon slot, calculate weapon bonus
        /// </summary>
        /// <param name="weapon">Weapon item</param>
        /// <returns>Success message</returns>
        /// <exception cref="InvalidWeaponException">If weapon type or hero level is invalid</exception>
        public override string EquipWeapon(Weapon weapon)
        {
            if (weapon.WeaponType != WeaponType.WEAPON_AXE && weapon.WeaponType != WeaponType.WEAPON_HAMMER && weapon.WeaponType != WeaponType.WEAPON_SWORD)
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

        /// <summary>
        /// Add armor to armor slot, calculate total primary attributes, calculate weapon bonus
        /// </summary>
        /// <param name="armor">Armor item</param>
        /// <returns>Success message</returns>
        /// <exception cref="InvalidArmorException">If armor type or hero level is invalid</exception>
        public override string EquipArmor(Armor armor)
        {
            if (armor.ArmourType != ArmourType.ARMOUR_MAIL && armor.ArmourType != ArmourType.ARMOUR_PLATE)
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
