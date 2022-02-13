using System;
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

        public override void EquipWeapon(Weapon currentWeapon)
        {
            Equipment[currentWeapon.Slot] = currentWeapon;
        }
    }
}
