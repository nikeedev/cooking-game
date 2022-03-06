using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using cooking_game_csharp.codes;

namespace cooking_game_csharp 
{
    class cooking_game {

        public static string VersionNow = "0.2.0";

        static void Main(string[] args)
        {
            Console.WriteLine("Loading all needed things, please wait patient :)");
            Console.WriteLine("...");



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
            bool running = true;
            
            Thread.Sleep(2000);


            Console.WriteLine("Hello and welcome to Cooking Game! v"+VersionNow+"! New: Typo Fixing (more info in 'log' command)");
            Console.WriteLine("press Enter to continue...");
            Console.ReadKey();
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
            Console.ReadKey();
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

            while (running) {
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
                Console.WriteLine("Hello+ "  + username + "! What do you want to do now?");
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

                if ("recipe" == command) {
                    Functions.clearConsole();
                    Console.WriteLine("                   Current Recipes: ");
                    Console.WriteLine("                   ");
                    Console.WriteLine("                   Soup: ");
                    Console.WriteLine("                         Water: 10 Deciliters");
                    Console.WriteLine("                         Potato: 200 grams");
                    Console.WriteLine("                         Carrots: 3");
                    Console.WriteLine("                         ");
                    if (meat_achivement) {
                        Console.WriteLine("                   Soup With Meatballs:");
                        Console.WriteLine("                         Water: 12 Deciliters");
                        Console.WriteLine("                         Potato: 200 grams");
                        Console.WriteLine("                         Carrots: 3");
                        Console.WriteLine("                         Meat Packages: 2");
                    }
                    if (bread_achivement) {
                        Console.WriteLine("                   Bread:");
                        Console.WriteLine("                         Water: 5 Deciliters");
                        Console.WriteLine("                         Flour: 2 Deciliters");
                        Console.WriteLine("                         Oil: 1 Deciliters");
                    }
                }
                if ("inventory" == command) {
                    Functions.clearConsole();
                    Console.WriteLine("                   You have " + water + " deciliters of water");
                    Console.WriteLine("                   You have "+ potato + " grams of potato");
                    Console.WriteLine("                   You have "+ carrot + " carrots");
                    Console.WriteLine("                   You have "+ soup + " soup");
                    if (meat_achivement) {
                        Console.WriteLine("                   You have " + meat_packages + "meat packages");
                        Console.WriteLine("                   You have " + soup_with_meat + "soup with meatballs");
                    }
                    if (bread_achivement) {
                        Console.WriteLine("                         You have" + water + " deciliters of water");
                        Console.WriteLine("                         You have" + flour + " deciliters of flour");
                        Console.WriteLine("                         You have " + oil + " deciliters of oil");
                        Console.WriteLine("                         You have " + bread + " bread");
                    }
                    Console.WriteLine("                   You have " + lasagna + "lasagna's");
                    Console.WriteLine("                   You have " + baked_lasagna + "baked lasagna's\n");
                    Console.WriteLine("\n \n                   You have " + coins + "coins");
                    Console.WriteLine("                   Your level is: Level " + level + ". XP to next level is:" + xp+ " /" + xp_need);
                    Console.WriteLine(
                        "                   Tip: If you have small amount of required amount of ingredients, you won't be able to make food!");
                }

                if ("make something" == command) {
                    Functions.clearConsole();
                    Console.WriteLine("                   Write name of any food above: ");
                    Console.WriteLine("                   Soup");
                    if (meat_achivement) {
                        Console.WriteLine("                   Soup With Meatballs");
                    }
                    else if (lasagna >= 1) {
                        Console.WriteLine("                   Lasagna");
                    }
                    else if (bread_achivement) {
                        Console.WriteLine("                   Bread");
                    }
                    Console.Write("                   ");
                    string make_something = Console.ReadLine();
                    if (make_something == "soup") {
                        Console.WriteLine(
                            "In order to make Soup, you need self write in amounts of ingredients. If you don't remember you must check recipes!");
                        Console.Write("Write deciliters of water you want to add: ");
                        int soup_water = Console.Read();
                        Console.Write("Write grams of potatoes you want to add: ");
                        int soup_potato = Console.Read();
                        Console.Write("Write amount of carrot(s) you want to add: ");
                        int soup_carrot = Console.Read();
                        if (soup_water >= 10) {
                            water = water - soup_water;
                            water_enough = true;
                        }
                        if (soup_potato >= 200) {
                            potato = potato - soup_potato;
                            potato_enough = true;
                        }
                        if (soup_carrot >= 3) {
                            carrot = carrot - soup_carrot;
                            carrot_enough = true;
                        }
                        if (water_enough && potato_enough && carrot_enough) {
                            Console.WriteLine("Yeah! All ingredients is here! You successfully made some Soup!");
                            Console.WriteLine("---- You got 1 Soup! It lies in inventory now, + 10 XP ----");
                            soup = soup + 1;
                            xp += 10;
                        }
                        else {
                            Console.WriteLine("You can't make soup, because you don't have enough ingredients!");
                            Console.WriteLine("You used " + soup_water + " dl, instead of 10 deciliters!");
                            Console.WriteLine("You used " + soup_potato + " grams, instead of 200 grams!");
                            Console.WriteLine("You used " + soup_carrot + " sticks of carrots, instead of 3 carrots!");
                        }
                        water_enough = false;
                        potato_enough = false;
                        carrot_enough = false;
                        soup_water = 0;
                        soup_potato = 0;
                        soup_carrot = 0;
                    }
                    else if (meat_achivement) {
                        if (make_something == "soup with meat") {
                            Console.WriteLine(
                                "In order to make Soup with Meatballs, you need self write in amounts of ingredients. If you don't remember you must check recipes!");
                            Console.Write("Write deciliters of water you want to add: ");
                            int soup_water = Console.Read();
                            Console.Write("Write grams of potatoes you want to add: ");
                            int soup_potato = Console.Read();
                            Console.Write("Write amount of carrot(s) you want to add: ");
                            int soup_carrot = Console.Read();
                            Console.Write("Write amount of meat packages you want to add ");
                            int soup_meat = Console.Read();
                            if (soup_water >= 12) {
                                water = water - soup_water;
                                water_enough = true;
                            }
                            if (soup_potato >= 200) {
                                potato = potato - soup_potato;
                                potato_enough = true;
                            }
                            if (soup_carrot >= 3) {
                                carrot = carrot - soup_carrot;
                                carrot_enough = true;
                            }
                            if (soup_meat >= 2) {
                                meat_packages = meat_packages - soup_meat;
                                meat_enough = true;
                            }
                            if (water_enough && potato_enough && carrot_enough && meat_enough) {
                                Console.WriteLine("Yeah! All ingredients is here! You successfully made some Soup!");
                                Console.WriteLine("---- You got 1 Soup with Meatballs! It lies in inventory now, + 15 XP ----");
                                soup_with_meat += 1;
                                xp += 15;
                            }
                            else {
                                Console.WriteLine("You can't make soup, because you don't have enough ingredients!");
                                Console.WriteLine("You used " + soup_water + " dl of water, instead of 12 deciliters!");
                                Console.WriteLine("You used " + soup_potato + "  grams of potatoes, instead of 200 grams!");
                                Console.WriteLine("You used " + soup_carrot + "  sticks of carrots, instead of 3 carrots!");
                                Console.WriteLine("You used " + soup_meat + "  meat packages, instead of 2 packages");
                            }
                            water_enough = false;
                            potato_enough = false;
                            carrot_enough = false;
                            meat_enough = false;
                            soup_water = 0;
                            soup_potato = 0;
                            soup_carrot = 0;
                            soup_meat = 0;
                        }
                    }
                    else if (lasagna >= 1) {
                        if ("lasagna" == make_something) {
                            Console.WriteLine("You are lucky to buy Lasagna! It costed you so much...");
                            Console.Write("press Enter to continue...");
                            Console.ReadKey();
                            Console.WriteLine("All you need is to say Yes or Y to make that lasagna...");
                            Console.Write("Write yes/y or no/n: ");
                            string lasagna_accept = Console.ReadLine();
                            if ("y" == lasagna_accept || "yes" == lasagna_accept) {
                                Console.WriteLine("Well you did it. But you lose whole 20 Deciliters of water... ");
                                Console.Write("press Enter to continue...");
                                Console.ReadKey();
                                water -= 20;
                                baked_lasagna += 1;
                                Console.WriteLine("---- You made 1 Baked Lasagna ----");
                            }
                            if ("n" == lasagna_accept || "no" == lasagna_accept) {
                                Console.WriteLine("Well you won't regret next time...");
                                Console.Write("Press That Enter button to Continue!!!!!!");
                                Console.ReadKey();
                            }
                        }
                    }
                    else if (bread_achivement) {
                        if (make_something == "bread") {
                            Console.WriteLine(
                                "In order to make Bread, you need self write in amounts of ingredients. If you don't remember you must check recipes!");
                            Console.Write("Write deciliters of water you want to add: ");
                            int bread_water = Console.Read();
                            Console.Write("Write deciliters of flour you want to add: ");
                            int bread_flour = Console.Read();
                            Console.Write("Write deciliters of oil you want to add: ");
                            int bread_oil = Console.Read();
                            if (bread_water >= 5) {
                                water = water - bread_water;
                                water_enough = true;
                            }
                            if (bread_flour >= 2) {
                                flour = flour - bread_flour;
                                flour_enough = true;
                            }
                            if (bread_oil >= 1) {
                                oil = oil - bread_oil;
                                oil_enough = true;
                            }
                            if (water_enough && flour_enough && oil_enough) {
                                Console.WriteLine("Yeah! All ingredients is here! You successfully made some Bread!");
                                Console.WriteLine("---- You got 1 Bread! It lies in inventory now, + 20 XP ----");
                                bread += 1;
                                xp += 20;
                            }
                            else {
                                Console.WriteLine("You can't make Bread, because you don't have enough ingredients!");
                                Console.WriteLine("You used " + bread_water + " dl of water, instead of 5 deciliters!");
                                Console.WriteLine("You used " + bread_flour + " dl of flour, instead of 2 deciliters!");
                                Console.WriteLine("You used " + bread_oil + " dl of oil, instead of 1 deciliters!");
                            }
                            water_enough = false;
                            flour_enough = false;
                            oil_enough = false;
                            bread_water = 0;
                            bread_flour = 0;
                            bread_oil = 0;
                        }
                    }

                    else {
                        continue;
                    }
                }

                if ("market" == command)
                {
                    Functions.clearConsole();
                    Console.WriteLine("Welcome to The Market!");
                    Thread.Sleep(2000);
                    Console.WriteLine("Here, can you buy and sell things, such like food.");
                    Thread.Sleep(3000);
                    Console.WriteLine("And here it is!");
                    Thread.Sleep(2000);
                    Console.WriteLine("List of Market commands:");
                    Console.WriteLine("                          Sell");
                    Console.WriteLine("                          Buy");
                    Console.WriteLine("                          Exit");
                    string market_commands = Console.ReadLine();
                    if ("exit" == market_commands)
                    {
                        continue;
                    }
                    if ("sell" == market_commands)
                    {
                        if (soup < 0 || soup_with_meat < 0 || bread < 0)
                        {
                            Console.WriteLine("You don't have anything to sell, redirecting back in 3 sec");
                            Thread.Sleep(3000);
                            continue;
                        }
                        else if (soup > 0 || soup_with_meat > 0)
                        {
                            Console.WriteLine("You can sell only food you made.");
                            Thread.Sleep(2000);
                            Console.WriteLine("Prices on foods change after time(after updates), so be in right time to get much coins!");
                            Thread.Sleep(3000);
                            Console.WriteLine("You can sell " + soup+ "  soup.");
                            if (meat_achivement)
                            {
                                Console.WriteLine("You can sell " + soup_with_meat+ "  soup with meatballs.");
                            }
                            if (bread_achivement)
                            {
                                Console.WriteLine("You can sell " + bread+ "  bread.");
                            }

                            Thread.Sleep(2);
                            Console.WriteLine("If you want to sell write: name of food you want to sell.");
                            string sell_command = Console.ReadLine();
                            if ("soup" == sell_command)
                            {
                                Console.WriteLine("One soup could be sold for: 25 coins");
                                Console.WriteLine(
                                    "Want to sell 1 soup for current price? If not, you will be redirected back to main commands!");
                                Console.WriteLine("Write yes or no...");
                                string sell_answer = Console.ReadLine();
                                if ("yes" == sell_answer)
                                {
                                    Console.WriteLine("Selling soup!");
                                    soup -= 1;
                                    Thread.Sleep(2);
                                    Console.WriteLine("You got 25 coins");
                                    coins += 25;
                                }
                                else
                                {
                                    Console.WriteLine("Aborting sell...");
                                }
                            }
                            if (meat_achivement)
                            {
                                if ("soup with meatballs" == sell_command)
                                {
                                    Console.WriteLine("One soup with meatballs could be sold for: 30 coins");
                                    Console.WriteLine("Want to sell 1 soup with meatballs for current price?");
                                    Console.WriteLine("If not, you will be redirected back to main commands!");
                                    Console.WriteLine("Write yes or no...");
                                    string sell_answer = Console.ReadLine();
                                    if ("yes" == sell_answer)
                                    {
                                        Console.WriteLine("Selling soup!");
                                        soup_with_meat -= 1;
                                        Thread.Sleep(2000);
                                        Console.WriteLine("You got 30 coins");
                                        coins += 30;
                                    }
                                }
                            }
                            if (bread_achivement)
                            {
                                if ("bread" == sell_command)
                                {
                                    Console.WriteLine("One bread could be sold for: 35 coins");
                                    Console.WriteLine("Want to sell 1 bread for current price?");
                                    Console.WriteLine("If not, you will be redirected back to main commands!");
                                    Console.WriteLine("Write yes or no...");
                                    string sell_answer = Console.ReadLine();
                                    if ("yes" == sell_answer)
                                    {
                                        Console.WriteLine("Selling bread!");
                                        bread -= 1;
                                        Thread.Sleep(2000);
                                        Console.WriteLine("You got 30 coins");
                                        coins += 30;
                                    }
                                }
                            }
                        }
                    }
                    if ("buy" == market_commands)
                    {
                        if (coins == 0)
                        {
                            Console.WriteLine("You don't have enough money! Leaving Market in 2 sec.");
                            Thread.Sleep(2000);
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("You can buy vegetables, water and much other!");
                            Thread.Sleep(2000);
                            Console.WriteLine("Here is what you can buy:");
                            Console.WriteLine("Water, 20 deciliters: 10 coins");
                            Console.WriteLine("Potato, 400 grams: 5 coins");
                            Console.WriteLine("Carrots, 6 sticks: 7 coins");
                            if (bread_achivement)
                            {
                                Console.WriteLine("Flour, 200 grams: 8 coins");
                                Console.WriteLine("Oil, 12 deciliters: 10: coins");
                            }
                            if (meat_achivement)
                            {
                                Console.WriteLine("Meat, 4 packages: 5 coins");
                                Console.WriteLine("Lasagna, 1: 150 coins(being rich to buy this recommended)");
                                Thread.Sleep(3);
                                Console.WriteLine("Write in commands below what you want to buy:");
                                Console.WriteLine("Water");
                                Console.WriteLine("Potato");
                                Console.WriteLine("Carrot");
                                Console.WriteLine("Lasagna");
                                if (bread_achivement)
                                {
                                    Console.WriteLine("Flour");
                                    Console.WriteLine("Oil");
                                }
                                if (meat_achivement)
                                {
                                    Console.WriteLine("Meat");
                                }
                                string buy_commands = Console.ReadLine();
                                if ("water" == buy_commands)
                                {
                                    Console.WriteLine("Adding 20 deciliters, minus 10 coins");
                                    water += 20;
                                    coins -= 10;
                                }
                                else if ("potato" == buy_commands)
                                {
                                    Console.WriteLine("Adding 400 grams potatoes, minus 5 coins");
                                    potato += 400;
                                    coins -= 5;
                                }
                                else if ("carrot" == buy_commands)
                                {
                                    Console.WriteLine("Adding 6 carrots, minus 7 coins");
                                    carrot += 6;
                                    coins -= 7;
                                }
                                if (meat_achivement)
                                {
                                    if ("meat" == buy_commands)
                                    {
                                        Console.WriteLine("Adding 4 meat packages, minus 5 coins");
                                        meat_packages += 4;
                                        coins -= 5;
                                    }
                                }
                                else if ("lasagna" == buy_commands)
                                {
                                    Console.WriteLine("Adding 1 lasagna, minus 150 coins(JESUS!)");
                                    lasagna += 1;
                                    coins -= 150;
                                }
                                if (bread_achivement)
                                {
                                    if ("flour" == buy_commands)
                                    {
                                        Console.WriteLine("Adding 200 grams flour, minus 8 coins");
                                        flour += 200;
                                        coins -= 8;
                                    }
                                    else if ("oil" == buy_commands)
                                    {
                                        Console.WriteLine("Adding 12 deciliters, minus 12 coins");
                                        oil += 12;
                                        coins -= 12;
                                    }
                                }
                            }
                        }
                    }
                }

                
                if ("boosts" == command) {
                    Functions.clearConsole();
                    Console.WriteLine("\n\nBoosts!");
                    Console.WriteLine(" Currently under construction! Come back later!");
                    /*    
                    Console.WriteLine("\n List of Boosts commands:");
                    Console.WriteLine("                          List");
                    Console.WriteLine("                          Buy");
                    Console.WriteLine("                          Exit");
                    string boosts_commands = Console.ReadLine();

                    if ("list" == boost_commands) {
                    
                    }

                    
                    if (coins != 0) 
                    {
                        if ("buy" == boosts_commands) 
                        {
                    
                        }
                    }
                    else if ("exit" == boosts_commands) 
                    {
                            continue;
                    }
                    
                    else 
                    {
                        continue;
                    }
                    */
                }

                else if ("info" == command)
                {
                    Functions.clearConsole();
                    Functions.info();
                }


                else if ("update" == command || "log" == command)
                {
                    Functions.clearConsole();
                    Functions.update();
                }

                else if ("exit" == command)
                {
                    running = false;
                }



                else
                {
                    continue;
                }
            }
        }
    }
}