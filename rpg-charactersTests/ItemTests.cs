using System;
using rpg_characters.CustomExceptions;
using rpg_characters.Helpers;
using rpg_characters.Heroes;
using rpg_characters.Items;
using Xunit;

namespace rpg_charactersTests
{
    public class ItemTests
    {
        [Fact]
        public void EquipWeapon_EquipWrongLevelWeapon_ThrowInvalidWeaponException()
        {
            // Arrange
            Warrior warriorHero = new("Warrior");

            Weapon testAxe = new()
            {
                ItemName = "Common axe",
                ItemLevel = 2,
                Slot = ItemSlot.SLOT_WEAPON,
                WeaponType = WeaponType.WEAPON_AXE,
                WeaponAttributes = new WeaponAttributes() { Damage = 7, AttackSpeed = 1.1 }
            };

            // Act, Assert
            Assert.Throws<InvalidWeaponException>(() => warriorHero.EquipWeapon(testAxe));
        }

        [Fact]
        public void EquipArmor_EquipWrongLevelArmor_ThrowInvalidArmorException()
        {
            // Arrange
            Warrior warriorHero = new("Warrior");

            Armor testPlatebody = new()
            {
                ItemName = "Common platebody",
                ItemLevel = 2,
                Slot = ItemSlot.SLOT_BODY,
                ArmourType = ArmourType.ARMOUR_PLATE,
                ArmourAttributes = new PrimaryAttributes() { Strength = 1 }
            };

            // Act, Assert
            Assert.Throws<InvalidArmorException>(() => warriorHero.EquipArmor(testPlatebody));
        }
    }
}
