using System;
namespace rpg_characters.CustomExceptions
{
    public class InvalidWeaponException : Exception
    {
        public InvalidWeaponException(string message) : base(message)
        {
        }

        public override string Message => "Invalid weapon";
    }
}
