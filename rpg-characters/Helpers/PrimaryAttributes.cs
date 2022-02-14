using System;
namespace rpg_characters.Helpers
{
    public class PrimaryAttributes
    {
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }

        public override bool Equals(object obj)
        {
            return obj is PrimaryAttributes attributes &&
                   Strength == attributes.Strength &&
                   Dexterity == attributes.Dexterity &&
                   Intelligence == attributes.Intelligence;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Strength, Dexterity, Intelligence);
        }

        public static PrimaryAttributes operator +(PrimaryAttributes first, PrimaryAttributes second)
        {
            return new PrimaryAttributes
            {
                Strength = first.Strength + second.Strength,
                Dexterity = first.Dexterity + second.Dexterity,
                Intelligence = first.Intelligence + second.Intelligence
            };
        }
    }
}
