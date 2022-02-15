using System;
using rpg_characters.Helpers;

namespace rpg_characters.Items
{
    public enum ArmourType
    {
        ARMOUR_CLOTH,
        ARMOUR_LEATHER,
        ARMOUR_MAIL,
        ARMOUR_PLATE
    }

    /// <summary>
    /// Initialize armor item
    /// </summary>
    public class Armor : Item
    {
        public PrimaryAttributes ArmourAttributes { get; set; }
        public ArmourType ArmourType { get; set; }
    }
}
