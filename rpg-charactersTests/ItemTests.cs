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

        [Fact]
        public void EquipWeapon_EquipWrongTypeWeapon_ThrowInvalidWeaponException()
        {
            // Arrange
            Warrior warriorHero = new("Warrior");

            Weapon testBow = new()
            {
                ItemName = "Common bow",
                ItemLevel = 1,
                Slot = ItemSlot.SLOT_WEAPON,
                WeaponType = WeaponType.WEAPON_BOW,
                WeaponAttributes = new WeaponAttributes() { Damage = 12, AttackSpeed = 0.8 }
            };

            // Act, Assert
            Assert.Throws<InvalidWeaponException>(() => warriorHero.EquipWeapon(testBow));
        }

        [Fact]
        public void EquipArmor_EquipWrongTypeArmor_ThrowInvalidArmorException()
        {
            // Arrange
            Warrior warriorHero = new("Warrior");

            Armor testClothHead = new()
            {
                ItemName = "Common cloth head armor",
                ItemLevel = 1,
                Slot = ItemSlot.SLOT_HEAD,
                ArmourType = ArmourType.ARMOUR_CLOTH,
                ArmourAttributes = new PrimaryAttributes() { Intelligence = 5 }
            };

            // Act, Assert
            Assert.Throws<InvalidArmorException>(() => warriorHero.EquipArmor(testClothHead));
        }

        [Fact]
        public void EquipWeapon_EquipValidWeapon_ReturnSuccessMessage()
        {
            // Arrange
            Mage mageHero = new("Mage");

            Weapon testStaff = new()
            {
                ItemName = "Common staff",
                ItemLevel = 1,
                Slot = ItemSlot.SLOT_WEAPON,
                WeaponType = WeaponType.WEAPON_STAFF,
                WeaponAttributes = new WeaponAttributes() { Damage = 6, AttackSpeed = 1.2 }
            };

            string expected = "New weapon equipped!";

            // Act
            string actual = mageHero.EquipWeapon(testStaff);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void EquipArmor_EquipValidArmor_ReturnSuccessMessage()
        {
            // Arrange
            Rogue rogueHero = new("Rogue");

            Armor testMailBody = new()
            {
                ItemName = "Common mail body armor",
                ItemLevel = 1,
                Slot = ItemSlot.SLOT_BODY,
                ArmourType = ArmourType.ARMOUR_MAIL,
                ArmourAttributes = new PrimaryAttributes() { Strength = 3 }
            };

            string expected = "New armour equipped!";

            // Act
            string actual = rogueHero.EquipArmor(testMailBody);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Damage_CalculateDamageWithoutWeapon_ReturnDamage()
        {
            // Arrange
            Warrior warriorHero = new("Warrior");
            double expected = 1 * (1 + (5 / 100));

            // Act
            double actual = warriorHero.HeroDamage;

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
