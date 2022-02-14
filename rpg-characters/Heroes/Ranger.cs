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

        public override void EquipWeapon(Weapon weapon)
        {
            if (weapon.WeaponType != WeaponType.WEAPON_BOW)
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
