using System;
using System.Collections.Generic;
using System.Text;
using rpg_characters.Helpers;
using rpg_characters.Items;

namespace rpg_characters.Heroes
{
    public enum HeroClasses
    {
        CLASS_MAGE,
        CLASS_RANGER,
        CLASS_ROGUE,
        CLASS_WARRIOR
    }

    public abstract class Hero
    {
        public string HeroName { get; set; }
        public HeroClasses HeroClass { get; set; }
        public int CurrentLevel { get; set; }
        public PrimaryAttributes BasePrimaryAttributes { get; set; }
        public Dictionary<ItemSlot, Item> Equipment { get; set; }
        public PrimaryAttributes TotalPrimaryAttributes { get; set; }
        public double HeroDamage { get; set; }

        /// <summary>
        /// Initialize hero
        /// </summary>
        /// <param name="name">Name of hero</param>
        /// <param name="strength">Strength of hero</param>
        /// <param name="dexterity">Dexterity of hero</param>
        /// <param name="intelligence">Intelligence of hero</param>
        public Hero(string name, int strength, int dexterity, int intelligence)
        {
            HeroName = name;
            CurrentLevel = 1;
            BasePrimaryAttributes = new PrimaryAttributes() { Strength = strength, Dexterity = dexterity, Intelligence = intelligence };
            Equipment = new Dictionary<ItemSlot, Item>();
            CreateSlots();
            TotalPrimaryAttributes = BasePrimaryAttributes;
            HeroDamage = DamagePerSecond();
        }

        /// <summary>
        /// Create item slots, set slots empty
        /// </summary>
        public void CreateSlots()
        {
            Equipment.Add(ItemSlot.SLOT_WEAPON, null);
            Equipment.Add(ItemSlot.SLOT_HEAD, null);
            Equipment.Add(ItemSlot.SLOT_BODY, null);
            Equipment.Add(ItemSlot.SLOT_LEGS, null);
        }

        /// <summary>
        /// Add gained points to base primary attributes, add level
        /// </summary>
        public abstract void LevelUp();

        /// <summary>
        /// Add item to dictionary
        /// </summary>
        /// <param name="itemSlot">Item slot</param>
        /// <param name="item">Item</param>
        public void EquipItem(ItemSlot itemSlot, Item item)
        {
            Equipment.Add(itemSlot, item);
        }

        /// <summary>
        /// Add weapon to weapon slot, calculate weapon bonus
        /// </summary>
        /// <param name="weapon">Weapon item</param>
        /// <returns>Success message</returns>
        /// <exception cref="InvalidWeaponException">If weapon type or hero level is invalid</exception>
        public abstract string EquipWeapon(Weapon weapon);

        /// <summary>
        /// Add armor to armor slot, calculate total primary attributes, calculate weapon bonus
        /// </summary>
        /// <param name="armor">Armor item</param>
        /// <returns>Success message</returns>
        /// <exception cref="InvalidArmorException">If armor type or hero level is invalid</exception>
        public abstract string EquipArmor(Armor armor);

        /// <summary>
        /// Check if hero has armor equipped, get armour attributes
        /// </summary>
        /// <returns>Armor attributes</returns>
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

        /// <summary>
        /// Check if hero has weapon equipped, calculate damage per second value
        /// </summary>
        /// <returns>DPS if weapon is equipped, else 1</returns>
        public double DamagePerSecond()
        {
            if (Equipment[ItemSlot.SLOT_WEAPON] != null)
            {
                return (Equipment[ItemSlot.SLOT_WEAPON] as Weapon).WeaponAttributes.Damage * (Equipment[ItemSlot.SLOT_WEAPON] as Weapon).WeaponAttributes.AttackSpeed;
            }

            return 1;
        }

        /// <summary>
        /// Check hero class, calculate weapon bonus, calculate total damage
        /// </summary>
        public void SetDamage()
        {
            if (HeroClass == HeroClasses.CLASS_MAGE)
            {
                double weaponBonus = 1 + (TotalPrimaryAttributes.Intelligence / 100.00);
                HeroDamage = DamagePerSecond() * weaponBonus;
            }

            if (HeroClass == HeroClasses.CLASS_RANGER || HeroClass == HeroClasses.CLASS_ROGUE)
            {
                double weaponBonus = 1 + (TotalPrimaryAttributes.Dexterity / 100.00);
                HeroDamage = DamagePerSecond() * weaponBonus;
            }

            if (HeroClass == HeroClasses.CLASS_WARRIOR)
            {
                double weaponBonus = 1 + (TotalPrimaryAttributes.Strength / 100.00);
                HeroDamage = DamagePerSecond() * weaponBonus;
            }
        }

        /// <summary>
        /// Print statistics to console
        /// </summary>
        public void DisplayStats()
        {
            StringBuilder stats = new();

            stats.Append($"Hero name: {HeroName}\n");
            stats.Append($"Level: {CurrentLevel}\n");
            stats.Append($"Strength: {TotalPrimaryAttributes.Strength}\n");
            stats.Append($"Dexterity: {TotalPrimaryAttributes.Dexterity}\n");
            stats.Append($"Intelligence: {TotalPrimaryAttributes.Intelligence}\n");
            stats.Append($"Damage: {HeroDamage}\n");

            Console.WriteLine(stats);
        } 
    }
}
