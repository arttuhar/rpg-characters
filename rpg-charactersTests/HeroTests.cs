using System;
using rpg_characters.Helpers;
using rpg_characters.Heroes;
using Xunit;

namespace rpg_charactersTests
{
    public class HeroTests
    {
        [Fact]
        public void Constructor_CreateHero_HeroIsLevel1()
        {
            // Arrange
            Mage mageHero = new("Mage");
            int expected = 1;

            // Act
            int actual = mageHero.CurrentLevel;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void LevelUp_HeroLevelsUp_HeroIsLevel2()
        {
            // Arrange
            Mage mageHero = new("Mage");
            mageHero.LevelUp();
            int expected = 2;

            // Act
            int actual = mageHero.CurrentLevel;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void BasePrimaryAttributes_MageAttributes_GetProperMageDefaultAttributes()
        {
            // Arrange
            Mage mageHero = new("Mage");
            PrimaryAttributes expected = new() { Strength = 1, Dexterity = 1, Intelligence = 8};

            // Act
            PrimaryAttributes actual = mageHero.BasePrimaryAttributes;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void BasePrimaryAttributes_RangerAttributes_GetProperRangerDefaultAttributes()
        {
            // Arrange
            Ranger rangerHero = new("Ranger");
            PrimaryAttributes expected = new() { Strength = 1, Dexterity = 7, Intelligence = 1 };

            // Act
            PrimaryAttributes actual = rangerHero.BasePrimaryAttributes;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void BasePrimaryAttributes_RogueAttributes_GetProperRogueDefaultAttributes()
        {
            // Arrange
            Rogue rogueHero = new("Rogue");
            PrimaryAttributes expected = new() { Strength = 2, Dexterity = 6, Intelligence = 1 };

            // Act
            PrimaryAttributes actual = rogueHero.BasePrimaryAttributes;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void BasePrimaryAttributes_WarriorAttributes_GetProperWarriorDefaultAttributes()
        {
            // Arrange
            Warrior warriorHero = new("Warrior");
            PrimaryAttributes expected = new() { Strength = 5, Dexterity = 2, Intelligence = 1 };

            // Act
            PrimaryAttributes actual = warriorHero.BasePrimaryAttributes;

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
