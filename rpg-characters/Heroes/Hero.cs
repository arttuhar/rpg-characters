using System;
using System.Collections.Generic;
using rpg_characters.CustomExceptions;
using rpg_characters.Helpers;
using rpg_characters.Items;

namespace rpg_characters.Heroes
{
    public enum HeroClasses
    {
        Mage,
        Ranger,
        Rogue,
        Warrior
    }

    public abstract class Hero
    {
        public string HeroName { get; set; }
        public HeroClasses HeroClass { get; set; }
        public int CurrentLevel { get; set; }
        public PrimaryAttributes BasePrimaryAttributes { get; set; }
        public Dictionary<ItemSlot, Item> Equipment { get; set; }
        public PrimaryAttributes TotalPrimaryAttributes { get; set; }
        public int DPS { get; set; }

        public Hero(string name, int strength, int dexterity, int intelligence)
        {
            HeroName = name;
            CurrentLevel = 1;
            BasePrimaryAttributes = new PrimaryAttributes() { Strength = strength, Dexterity = dexterity, Intelligence = intelligence };
            Equipment = new Dictionary<ItemSlot, Item>();
            CreateSlots();
            TotalPrimaryAttributes = BasePrimaryAttributes;
            DPS = DamagePerSecond();
        }

        public void CreateSlots()
        {
            Equipment.Add(ItemSlot.SLOT_WEAPON, null);
            Equipment.Add(ItemSlot.SLOT_HEAD, null);
            Equipment.Add(ItemSlot.SLOT_BODY, null);
            Equipment.Add(ItemSlot.SLOT_LEGS, null);
        }

        public abstract void LevelUp();

        public void EquipItem(ItemSlot itemSlot, Item item)
        {
            Equipment.Add(itemSlot, item);
        }
        
        public abstract void EquipWeapon(Weapon weapon);

        public abstract void EquipArmor(Armor armor);

        public PrimaryAttributes ArmorAttributes()
        {
            PrimaryAttributes ArmorPrimaryAttributes = new() { Strength = 0, Dexterity = 0, Intelligence = 0 };

            if (Equipment[ItemSlot.SLOT_HEAD] != null)
            {
                ArmorPrimaryAttributes += (Equipment[ItemSlot.SLOT_HEAD] as Armor).ArmourAttributes;
            }

            if (Equipment[ItemSlot.SLOT_BODY] != null)
            {
                ArmorPrimaryAttributes += (Equipment[ItemSlot.SLOT_BODY] as Armor).ArmourAttributes;
            }

            if (Equipment[ItemSlot.SLOT_LEGS] != null)
            {
                ArmorPrimaryAttributes += (Equipment[ItemSlot.SLOT_LEGS] as Armor).ArmourAttributes;
            }

            return ArmorPrimaryAttributes;

        }

        public int DamagePerSecond()
        {
            if (Equipment[ItemSlot.SLOT_WEAPON] != null)
            {
                return (Equipment[ItemSlot.SLOT_WEAPON] as Weapon).WeaponAttributes.Damage * (Equipment[ItemSlot.SLOT_WEAPON] as Weapon).WeaponAttributes.AttackSpeed;
            }

            return 1;
        }
        
    }
}
