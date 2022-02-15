using System;
using rpg_characters.Heroes;
using Xunit;

namespace rpg_charactersTests
{
    public class UnitTest1
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
    }
}
