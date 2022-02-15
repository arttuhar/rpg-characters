using System;
using rpg_characters.CustomExceptions;
using rpg_characters.Items;

namespace rpg_characters.Heroes
{
    public class Ranger : Hero
    {
        /// <summary>
        /// Initialize ranger class hero
        /// </summary>
        /// <param name="name">Name of hero</param>
        public Ranger(string name) : base(name, 1, 7, 1)
        {
            HeroClass = HeroClasses.Ranger;
        }

        /// <summary>
        /// Add gained points to base primary attributes, add level
        /// </summary>
        public override void LevelUp()
        {
            BasePrimaryAttributes.Strength += 1;
            BasePrimaryAttributes.Dexterity += 5;
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
            if (weapon.WeaponType != WeaponType.WEAPON_BOW)
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
        /// <param name="armor"></param>
        /// <returns>Succcess message</returns>
        /// <exception cref="InvalidArmorException">If armor type or hero level is invalid</exception>
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
            SetDamage();
            return "New armour equipped!";
        }
    }
}
