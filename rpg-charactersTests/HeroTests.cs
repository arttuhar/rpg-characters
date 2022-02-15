using System;
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

            //Act
            int actual = mageHero.CurrentLevel;

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
