using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace rpg_characters.GameClasses
{
    public class Game
    {
        public void PlayGame()
        {
            StartMessage();
            HeroName();
            HeroClass();
            
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

        public static int HeroClass()
        {
            List<string> heroClassOptions = new List<string>();
            heroClassOptions.Add("1 - Mage");
            heroClassOptions.Add("2 - Ranger");
            heroClassOptions.Add("3 - Rogue");
            heroClassOptions.Add("4 - Warrior");

            foreach (string heroClassOption in heroClassOptions)
            {
                Console.WriteLine(heroClassOption);
            }

            string askClass = "Select your class:";
            Console.WriteLine(askClass);
            int selectedClass = int.Parse(Console.ReadLine());

            while (selectedClass < 1 || selectedClass > 4)
            {
                Console.WriteLine("Class not exist");

                foreach (string heroClassOption in heroClassOptions)
                {
                    Console.WriteLine(heroClassOption);
                }

                selectedClass = int.Parse(Console.ReadLine());

            }

            Console.WriteLine(selectedClass);
            return selectedClass;
        }
    }
}
