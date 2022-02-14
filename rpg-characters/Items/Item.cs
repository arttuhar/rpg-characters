using System;

namespace rpg_characters.Items
{

    public enum ItemSlot
    {
        SLOT_WEAPON,
        SLOT_HEAD,
        SLOT_BODY,
        SLOT_LEGS
    }

    public abstract class Item
    {
        public string ItemName { get; set; }
        public ItemSlot Slot { get; set; }
    }
}
