using System;
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
            BasePrimaryAttributes.Dexterity += 1;
            BasePrimaryAttributes.Intelligence += 5;
            CurrentLevel++;
        }

        public override void EquipWeapon(ItemSlot weaponSlot, Item weaponItem)
        {
            Equipment.Add(weaponSlot, weaponItem);
        }
    }
}
