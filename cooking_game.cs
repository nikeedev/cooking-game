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
            float coins = 0;
            float water = 120;  // deciliters
            float lasagna = 0;
            float baked_lasagna = 0;
            float potato = 1000;  // grams
            float carrot = 12;  // 12 carrots
            float meat_packages = 0;  // going to be 20 meat packages
            bool meat_achivement = false;
            float soup = 0;
            float soup_with_meat = 0;
            float bread = 0;
            float level = 0;
            float xp = 0;
            float xp_need = 100;
            float xp_rest = 0;
            bool bread_achivement = false;
            float flour = 5000;  // grams
            float oil = 100;  // deciliters
            


            Console.WriteLine("Hello and welcome to Cooking Game! v.0.6.4! New: Typo Fixing (more info in 'log' command)");
            Console.WriteLine("press Enter to continue...");
            Console.ReadLine();
            while (use_username) {
                Console.WriteLine("\nWhat is your name or in this case nickname?");
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
            Console.WriteLine("");
            Console.ReadLine();
            Console.WriteLine("Okay, We're ready!");
            Console.WriteLine("press Enter to continue...");
            Console.ReadKey();
            Console.WriteLine("Lets begin with making some soup!");
            Console.WriteLine("press Enter to continue...");
            Console.ReadKey();
            Console.WriteLine(
                "In this game you have desired values of ingredients in recipes, meaning that you can't make very much food, if you dont have enough ingredients.");
            Console.WriteLine("press Enter to continue...");
            Console.ReadKey();
            Console.WriteLine("But we should have it enough to make some Soup!");
            Console.WriteLine("press Enter to continue...");
            Console.ReadKey();
            while (true) {
                if (xp == 2) {
                    Console.WriteLine("You achieved 'Bread Achivement'! You can now make bread!");
                    bread_achivement = true;
                }
                if (xp >= xp_need) {
                    xp_rest -= xp_need;
                    xp = xp_rest;
                    level += 1;
                    xp_rest = 0;
                    xp_need *= 1.15f;
                    Console.WriteLine("");
                    Console.WriteLine($"- New level achieved! - Level {level}, XP {xp} / {xp_need}");
                }
                if (water < 0) {
                    water = 0;
                }
                if (potato < 0) {
                    potato = 0;
                }
                if (carrot < 0) {
                    carrot = 0;
                }
                if (coins < 0) {
                    coins = 0;
                }
                if (flour < 0) {
                    flour = 0;
                }
                if (oil < 0) {
                    oil = 0;
                }
                if (meat_packages < 0) {
                    meat_packages = 0;
                }
                if (!meat_achivement) {
                    if (soup == 2) {
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        meat_achivement = true;
                        Console.WriteLine(
                            "You got Meat achievement, which means you can have meat in inventory, and you're able to make new Soup type!");
                        meat_packages += 20;
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                    }
                }
                Console.WriteLine("");
                Console.WriteLine("Hello, " + username + "! What do you want to do now?");
                Console.WriteLine("List of Commands:      ");
                Console.WriteLine("                   Recipes ( Write 'recipe' ) ");
                Console.WriteLine("                   Inventory ( Write 'inventory' )");
                Console.WriteLine("                   Make something ( Write 'make something' )");
                Console.WriteLine("                   Market(Sell and Buy food) ( Write 'market' )");
                Console.WriteLine("                   Boosts (Buy and list your boosts!) ( Write 'boosts' )");
                Console.WriteLine("                   Info ( Write 'info' )");
                Console.WriteLine("                   Update Log ( Write 'update' or 'log' )");
                Console.WriteLine("                   Exit ( Write 'exit' ) ");
                Console.WriteLine("                   ");
                string command = Console.ReadLine();
            }


        }
    }
}