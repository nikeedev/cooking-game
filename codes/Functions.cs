using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;


namespace cooking_game_csharp.codes
{
    public class Functions {
        public static void info() {
            Console.WriteLine("Cooking Game®");
            Console.WriteLine("Made by nikeedev(Nikita)");
            Console.WriteLine("Copyright ©2022");
            Console.WriteLine("This game is made completely by hand, and no tutorials have been used.");
            Console.WriteLine("Game code can be changed, but without asking owner(nikeedev),");
            Console.WriteLine("you are not following rules and may cause in problems.");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Contact me here:");
            Console.WriteLine("Discord(Spamming me causes to block you from support): nikeedev#8874");
            Console.WriteLine("Github: nikeedev(Use issue report function in repo)");
            Console.WriteLine("");
        }


        public static void update() {
            Console.WriteLine("Update: Typos fixing");
            Console.WriteLine("");
            Console.WriteLine("Version: v"+cooking_game.VersionNow);
            Console.WriteLine("");
            Console.WriteLine("New:");
            Console.WriteLine("");
            Console.WriteLine("Fixed typos, and words to make it easier for you to read!");
            Console.WriteLine(" (^^^^^^^ that wasn't small sentence!) ");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
        }

        public static void clearConsole() {
            Console.Clear();
        }
    }
}
