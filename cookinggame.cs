using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;


namespace cookinggamecsharp 
{
    class cookinggame {         
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


            print("Hello and welcome to Cooking Game! v.0.6.4! New: Typo Fixing (more info in 'log' command)")
            input("press Enter to continue...")
            while use_username:
                print("\n\nWhat is your name or in this case nickname?")
                username = input("My nickname is... ")
                agree = input(
                    "\n\nDo you want to use this username(write 1), PC username(write 2), or change this username(write 3)? ")
                if agree == "1":
                    use_username = False
                elif agree == "2":
                    username = getpass.getuser()
                    use_username = False
                elif agree == "3":
                    continue
            print(f"Hello {username}. Nice, now can we begin to cook!")


        }
    }
}