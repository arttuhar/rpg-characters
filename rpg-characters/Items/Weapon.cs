using System;
using rpg_characters.Helpers;

namespace rpg_characters.Items
{
    public enum WeaponType
    {
        WEAPON_AXE,
        WEAPON_BOW,
        WEAPON_DAGGER,
        WEAPON_HAMMER,
        WEAPON_STAFF,
        WEAPON_SWORD,
        WEAPON_WAND
    }

    /// <summary>
    /// Initialize weapon item
    /// </summary>
    public class Weapon : Item
    {
        public WeaponAttributes WeaponAttributes { get; set; }
        public WeaponType WeaponType { get; set; }
    }
}
