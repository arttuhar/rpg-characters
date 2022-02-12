using System;

namespace rpg_characters.GameClasses
{
    public class Game
    {
        public void PlayGame()
        {
            StartMessage();
            HeroName();
            
        }

        public static void StartMessage()
        {
            string header = "Get ready, adventure begins now!";
            Console.WriteLine(header);

        }

        public static string HeroName()
        {
            string askName = "Greetings adventurer! What is your name?";
            Console.WriteLine(askName);

            string name = Console.ReadLine();
            
            return name;

        }
    }
}
