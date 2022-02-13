using System;

namespace rpg_characters.Helpers
{
    public class WeaponAttributes
    {
        public int Damage { get; set; }
        public int AttackSpeed { get; set; }

        public WeaponAttributes(int baseDamage, int attacksPerSecond)
        {
            Damage = baseDamage;
            AttackSpeed = attacksPerSecond;
        }
    }
}
