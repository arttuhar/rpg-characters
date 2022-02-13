using System;
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
            BasePrimaryAttributes.Dexterity += 1;
            BasePrimaryAttributes.Intelligence += 5;
            CurrentLevel++;
        }

        public override void EquipWeapon(Weapon currentWeapon)
        {
            Equipment[currentWeapon.Slot] = currentWeapon;
        }
    }
}
