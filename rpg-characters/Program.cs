using System;
using rpg_characters.Heroes;
using rpg_characters.Helpers;
using rpg_characters.Items;

namespace rpg_characters
{
    class Program
    {
        static void Main(string[] args)
        {
            Mage mageHero = new("Arttu the Mage");
            Console.WriteLine($"{mageHero.HeroName}, {mageHero.HeroClass}, Level {mageHero.CurrentLevel}");
            Console.WriteLine($"{mageHero.TotalPrimaryAttributes.Strength}, {mageHero.TotalPrimaryAttributes.Dexterity}, {mageHero.TotalPrimaryAttributes.Intelligence}\n");

            Ranger rangerHero = new("Arttu the Ranger");
            Console.WriteLine($"{rangerHero.HeroName}, {rangerHero.HeroClass}, Level {rangerHero.CurrentLevel}");
            Console.WriteLine($"{rangerHero.BasePrimaryAttributes.Strength}, {rangerHero.BasePrimaryAttributes.Dexterity}, {rangerHero.BasePrimaryAttributes.Intelligence}\n");

            Rogue rogueHero = new("Arttu the Rogue");
            Console.WriteLine($"{rogueHero.HeroName}, {rogueHero.HeroClass}, Level {rogueHero.CurrentLevel}");
            Console.WriteLine($"{rogueHero.BasePrimaryAttributes.Strength}, {rogueHero.BasePrimaryAttributes.Dexterity}, {rogueHero.BasePrimaryAttributes.Intelligence}\n");

            Warrior warriorHero = new("Arttu the Warrior");
            Console.WriteLine($"{warriorHero.HeroName}, {warriorHero.HeroClass}, Level {rogueHero.CurrentLevel}");
            Console.WriteLine($"{warriorHero.BasePrimaryAttributes.Strength}, {warriorHero.BasePrimaryAttributes.Dexterity}, {warriorHero.BasePrimaryAttributes.Intelligence}\n");

            
            // Test level up
            Console.WriteLine("Test level up, y");
            string askLevelUp = Console.ReadLine();

            if (askLevelUp == "y")
            {
                mageHero.LevelUp();
                Console.WriteLine($"{mageHero.HeroName}, {mageHero.HeroClass}, Level {mageHero.CurrentLevel}");
                Console.WriteLine($"{mageHero.BasePrimaryAttributes.Strength}, {mageHero.BasePrimaryAttributes.Dexterity}, {mageHero.BasePrimaryAttributes.Intelligence}\n");
            }

            // Test equip a weapon and armor
            Weapon testAxe = new()
            {
                ItemName = "Common axe",
                Slot = ItemSlot.SLOT_WEAPON,
                WeaponType = WeaponType.WEAPON_STAFF,
                WeaponAttributes = new WeaponAttributes() { Damage = 7, AttackSpeed = 2 }
            };

            Armor testPlatebody = new()
            {
                ItemName = "Common platebody",
                Slot = ItemSlot.SLOT_BODY,
                ArmourType = ArmourType.ARMOUR_CLOTH,
                ArmourAttributes = new PrimaryAttributes() { Strength = 4 }
            };

            Console.WriteLine("Check weapon slot, y");
            string testWeapon = Console.ReadLine();

            if(testWeapon == "y")
            {
                mageHero.EquipWeapon(testAxe);
                Console.WriteLine($"{mageHero.Equipment[ItemSlot.SLOT_WEAPON].ItemName}\n");
                Console.WriteLine(mageHero.HeroDamage);
            }

            Console.WriteLine("Check body slot, y");
            string testArmor = Console.ReadLine();

            if (testArmor == "y")
            {
                mageHero.EquipArmor(testPlatebody);
                Console.WriteLine(mageHero.Equipment[ItemSlot.SLOT_BODY].ItemName);
                Console.WriteLine($"{mageHero.TotalPrimaryAttributes.Strength}, {mageHero.TotalPrimaryAttributes.Dexterity}, {mageHero.TotalPrimaryAttributes.Intelligence}\n");
            }
        }
    }
}
