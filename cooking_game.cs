using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;


namespace cooking_game_csharp 
{
    class cooking_game {         
        static void Main(string[] args)
        {
            Console.WriteLine("Loading all needed things, please show patient :)");
            Console.WriteLine("...");


            void clearConsole() {
                Console.Clear();
            }

            string username = "";
            bool water_enough = false;
            bool potato_enough = false;
            bool carrot_enough = false;
            bool meat_enough = false;
            bool  oil_enough = false;
            bool flour_enough = false;
            bool use_username = true;
            int coins = 0;
            int water = 120;  // deciliters
            int lasagna = 0;
            int baked_lasagna = 0;
            int potato = 1000;  // grams
            int carrot = 12;  // 12 carrots
            int meat_packages = 0;  // going to be 20 meat packages
            bool meat_achivement = false;
            int soup = 0;
            int soup_with_meat = 0;
            int bread = 0;
            int level = 0;
            int xp = 0;
            int xp_need = 100;
            int xp_rest = 0;
            bool bread_achivement = false;
            int flour = 5000;  // grams
            int oil = 100;  // deciliters
            


            Console.WriteLine("Hello and welcome to Cooking Game! v.0.6.4! New: Typo Fixing (more info in 'log' command)");
            Console.WriteLine("press Enter to continue...");
            Console.ReadLine();
            while (use_username) {
                Console.WriteLine("\n\nWhat is your name or in this case nickname?");
                Console.Write("My nickname is... ");
                username = Console.ReadLine();
                Console.Write("\n\nDo you want to use this username(write 1), PC username(write 2), or change this username(write 3)? ");
                string agree = Console.ReadLine();
                if (agree == "1") {
                    use_username = false;
                }
                else if (agree == "2") {
                    username = Environment.UserName;
                    use_username = false;
                }
                else if (agree == "3") {
                    continue;
                }
            }
            Console.WriteLine($"Hello {username}. Nice, now can we begin to cook!");
            Console.ReadLine();


        }
    }
}