using System;

namespace rpg_characters.CustomExceptions
{
    public class InvalidArmorException : Exception
    {
        public InvalidArmorException(string message) : base(message)
        {
        }

        public override string Message => "Invalid armor";
    }
}
