﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Data;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using cooking_game_csharp.codes;

namespace cooking_game_csharp 
{
    

    class cooking_game {

        public static string VersionNow = "0.2.0";

        static void Main(string[] args)
        {
            Console.WriteLine("Loading all needed things, please wait patient :)");
            Console.WriteLine("...");

            bool use_username = true;
            bool running = true;

            var inventory = new data {
                username = "",
                water_enough = false,
                potato_enough = false,
                carrot_enough = false,
                meat_enough = false,
                oil_enough = false,
                flour_enough = false,
                coins = 0,
                water = 120,  // deciliters
                lasagna = 0,
                baked_lasagna = 0,
                potato = 1000,  // grams
                carrot = 12,  // 12 carrots
                meat_packages = 0,  // going to be 20 meat packages
                meat_achivement = false,
                soup = 0,
                soup_with_meat = 0,
                bread = 0,
                level = 0,
                xp = 0,
                xp_need = 100,
                xp_rest = 0,
                bread_achivement = false,
                flour = 5000,  // grams
                oil = 100,  // deciliters
            };

            Thread.Sleep(2000);


            Console.WriteLine("Hello and welcome to Cooking Game! v"+VersionNow+"! New: Typo Fixing (more info in 'log' command)");
            Console.WriteLine("press Enter to continue...");
            Console.ReadKey();
            while (use_username) {
                Console.WriteLine("\nWhat is your name or in this case nickname?");
                Console.Write("My nickname is... ");
                inventory.username = Console.ReadLine();
                Console.Write("\n\nDo you want to use this username(write 1), PC username(write 2), or change this username(write 3)? ");
                string agree = Console.ReadLine();
                if (agree == "1") {
                    use_username = false;
                }
                else if (agree == "2") {
                    inventory.username = Environment.UserName;
                    use_username = false;
                }
                else if (agree == "3") {
                    continue;
                }
            }
            Console.WriteLine($"Hello {inventory.username}. Nice, now can we begin to cook!");
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
                if (inventory.xp == 2) {
                    Console.WriteLine("You achieved 'Bread Achivement'! You can now make bread!");
                    inventory.bread_achivement = true;
                }
                if (inventory.xp >= inventory.xp_need) {
                    inventory.xp_rest -= inventory.xp_need;
                    inventory.xp = inventory.xp_rest;
                    inventory.level += 1;
                    inventory.xp_rest = 0;
                    inventory.xp_need *= 1.15f;
                    Console.WriteLine("");
                    Console.WriteLine($"- New level achieved! - Level {inventory.level}, XP {inventory.xp} / {inventory.xp_need}");
                }
                if (inventory.water < 0) {
                    inventory.water = 0;
                }
                if (inventory.potato < 0) {
                    inventory.potato = 0;
                }
                if (inventory.carrot < 0) {
                    inventory.carrot = 0;
                }
                if (inventory.coins < 0) {
                    inventory.coins = 0;
                }
                if (inventory.flour < 0) {
                    inventory.flour = 0;
                }
                if (inventory.oil < 0) {
                    inventory.oil = 0;
                }
                if (inventory.meat_packages < 0) {
                    inventory.meat_packages = 0;
                }
                if (!inventory.meat_achivement) {
                    if (inventory.soup == 2) {
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        inventory.meat_achivement = true;
                        Console.WriteLine(
                            "You got Meat achievement, which means you can have meat in inventory, and you're able to make new Soup type!");
                        inventory.meat_packages += 20;
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                    }
                }
                Console.WriteLine("");
                Console.WriteLine("Hello+ "  + inventory.username + "! What do you want to do now?");
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
                    if (inventory.meat_achivement) {
                        Console.WriteLine("                   Soup With Meatballs:");
                        Console.WriteLine("                         Water: 12 Deciliters");
                        Console.WriteLine("                         Potato: 200 grams");
                        Console.WriteLine("                         Carrots: 3");
                        Console.WriteLine("                         Meat Packages: 2");
                    }
                    if (inventory.bread_achivement) {
                        Console.WriteLine("                   Bread:");
                        Console.WriteLine("                         Water: 5 Deciliters");
                        Console.WriteLine("                         Flour: 2 Deciliters");
                        Console.WriteLine("                         Oil: 1 Deciliters");
                    }
                }
                if ("inventory" == command) {
                    Functions.clearConsole();
                    Console.WriteLine("                   You have " + inventory.water + " deciliters of water");
                    Console.WriteLine("                   You have "+ inventory.potato + " grams of potato");
                    Console.WriteLine("                   You have "+ inventory.carrot + " carrots");
                    Console.WriteLine("                   You have "+ inventory.soup + " soup");
                    if (inventory.meat_achivement) {
                        Console.WriteLine("                   You have " + inventory.meat_packages + "meat packages");
                        Console.WriteLine("                   You have " + inventory.soup_with_meat + "soup with meatballs");
                    }
                    if (inventory.bread_achivement) {
                        Console.WriteLine("                         You have" + inventory.water + " deciliters of water");
                        Console.WriteLine("                         You have" + inventory.flour + " deciliters of flour");
                        Console.WriteLine("                         You have " + inventory.oil + " deciliters of oil");
                        Console.WriteLine("                         You have " + inventory.bread + " bread");
                    }
                    Console.WriteLine("                   You have " + inventory.lasagna + "lasagna's");
                    Console.WriteLine("                   You have " + inventory.baked_lasagna + "baked lasagna's\n");
                    Console.WriteLine("\n \n                   You have " + inventory.coins + "coins");
                    Console.WriteLine("                   Your level is: Level " + inventory.level + ". XP to next level is:" + inventory.xp + " /" + inventory.xp_need);
                    Console.WriteLine(
                        "                   Tip: If you have small amount of required amount of ingredients, you won't be able to make food!");
                }

                if ("make something" == command) {
                    Functions.clearConsole();
                    Console.WriteLine("                   Write name of any food above: ");
                    Console.WriteLine("                   Soup");
                    if (inventory.meat_achivement) {
                        Console.WriteLine("                   Soup With Meatballs");
                    }
                    else if (inventory.lasagna >= 1) {
                        Console.WriteLine("                   Lasagna");
                    }
                    else if (inventory.bread_achivement) {
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
                            inventory.water = inventory.water - soup_water;
                            inventory.water_enough = true;
                        }
                        if (soup_potato >= 200) {
                            inventory.potato = inventory.potato - soup_potato;
                            inventory.potato_enough = true;
                        }
                        if (soup_carrot >= 3) {
                            inventory.carrot = inventory.carrot - soup_carrot;
                            inventory.carrot_enough = true;
                        }
                        if (inventory.water_enough && inventory.potato_enough && inventory.carrot_enough) {
                            Console.WriteLine("Yeah! All ingredients is here! You successfully made some Soup!");
                            Console.WriteLine("---- You got 1 Soup! It lies in inventory now, + 10 XP ----");
                            inventory.soup = inventory.soup + 1;
                            inventory.xp += 10;
                        }
                        else {
                            Console.WriteLine("You can't make soup, because you don't have enough ingredients!");
                            Console.WriteLine("You used " + soup_water + " dl, instead of 10 deciliters!");
                            Console.WriteLine("You used " + soup_potato + " grams, instead of 200 grams!");
                            Console.WriteLine("You used " + soup_carrot + " sticks of carrots, instead of 3 carrots!");
                        }
                        inventory.water_enough = false;
                        inventory.potato_enough = false;
                        inventory.carrot_enough = false;
                        soup_water = 0;
                        soup_potato = 0;
                        soup_carrot = 0;
                    }
                    else if (inventory.meat_achivement) {
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
                                inventory.water = inventory.water - soup_water;
                                inventory.water_enough = true;
                            }
                            if (soup_potato >= 200) {
                                inventory.potato = inventory.potato - soup_potato;
                                inventory.potato_enough = true;
                            }
                            if (soup_carrot >= 3) {
                                inventory.carrot = inventory.carrot - soup_carrot;
                                inventory.carrot_enough = true;
                            }
                            if (soup_meat >= 2) {
                                inventory.meat_packages = inventory.meat_packages - soup_meat;
                                inventory.meat_enough = true;
                            }
                            if (inventory.water_enough && inventory.potato_enough && inventory.carrot_enough && inventory.meat_enough) {
                                Console.WriteLine("Yeah! All ingredients is here! You successfully made some Soup!");
                                Console.WriteLine("---- You got 1 Soup with Meatballs! It lies in inventory now, + 15 XP ----");
                                inventory.soup_with_meat += 1;
                                inventory.xp += 15;
                            }
                            else {
                                Console.WriteLine("You can't make soup, because you don't have enough ingredients!");
                                Console.WriteLine("You used " + soup_water + " dl of water, instead of 12 deciliters!");
                                Console.WriteLine("You used " + soup_potato + "  grams of potatoes, instead of 200 grams!");
                                Console.WriteLine("You used " + soup_carrot + "  sticks of carrots, instead of 3 carrots!");
                                Console.WriteLine("You used " + soup_meat + "  meat packages, instead of 2 packages");
                            }
                            inventory.water_enough = false;
                            inventory.potato_enough = false;
                            inventory.carrot_enough = false;
                            inventory.meat_enough = false;
                            soup_water = 0;
                            soup_potato = 0;
                            soup_carrot = 0;
                            soup_meat = 0;
                        }
                    }
                    else if (inventory.lasagna >= 1) {
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
                                inventory.water -= 20;
                                inventory.baked_lasagna += 1;
                                Console.WriteLine("---- You made 1 Baked Lasagna ----");
                            }
                            if ("n" == lasagna_accept || "no" == lasagna_accept) {
                                Console.WriteLine("Well you won't regret next time...");
                                Console.Write("Press That Enter button to Continue!!!!!!");
                                Console.ReadKey();
                            }
                        }
                    }
                    else if (inventory.bread_achivement) {
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
                                inventory.water = inventory.water - bread_water;
                                inventory.water_enough = true;
                            }
                            if (bread_flour >= 2) {
                                inventory.flour = inventory.flour - bread_flour;
                                inventory.flour_enough = true;
                            }
                            if (bread_oil >= 1) {
                                inventory.oil = inventory.oil - bread_oil;
                                inventory.oil_enough = true;
                            }
                            if (inventory.water_enough && inventory.flour_enough && inventory.oil_enough) {
                                Console.WriteLine("Yeah! All ingredients is here! You successfully made some Bread!");
                                Console.WriteLine("---- You got 1 Bread! It lies in inventory now, + 20 XP ----");
                                inventory.bread += 1;
                                inventory.xp += 20;
                            }
                            else {
                                Console.WriteLine("You can't make Bread, because you don't have enough ingredients!");
                                Console.WriteLine("You used " + bread_water + " dl of water, instead of 5 deciliters!");
                                Console.WriteLine("You used " + bread_flour + " dl of flour, instead of 2 deciliters!");
                                Console.WriteLine("You used " + bread_oil + " dl of oil, instead of 1 deciliters!");
                            }
                            inventory.water_enough = false;
                            inventory.flour_enough = false;
                            inventory.oil_enough = false;
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
                        if (inventory.soup < 0 || inventory.soup_with_meat < 0 || inventory.bread < 0)
                        {
                            Console.WriteLine("You don't have anything to sell, redirecting back in 3 sec");
                            Thread.Sleep(3000);
                            continue;
                        }
                        else if (inventory.soup > 0 || inventory.soup_with_meat > 0)
                        {
                            Console.WriteLine("You can sell only food you made.");
                            Thread.Sleep(2000);
                            Console.WriteLine("Prices on foods change after time(after updates), so be in right time to get much coins!");
                            Thread.Sleep(3000);
                            Console.WriteLine("You can sell " + inventory.soup+ "  soup.");
                            if (inventory.meat_achivement)
                            {
                                Console.WriteLine("You can sell " + inventory.soup_with_meat+ "  soup with meatballs.");
                            }
                            if (inventory.bread_achivement)
                            {
                                Console.WriteLine("You can sell " + inventory.bread+ "  bread.");
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
                                    inventory.soup -= 1;
                                    Thread.Sleep(2);
                                    Console.WriteLine("You got 25 coins");
                                    inventory.coins += 25;
                                }
                                else
                                {
                                    Console.WriteLine("Aborting sell...");
                                }
                            }
                            if (inventory.meat_achivement)
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
                                        inventory.soup_with_meat -= 1;
                                        Thread.Sleep(2000);
                                        Console.WriteLine("You got 30 coins");
                                        inventory.coins += 30;
                                    }
                                }
                            }
                            if (inventory.bread_achivement)
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
                                        inventory.bread -= 1;
                                        Thread.Sleep(2000);
                                        Console.WriteLine("You got 30 coins");
                                        inventory.coins += 30;
                                    }
                                }
                            }
                        }
                    }
                    if ("buy" == market_commands)
                    {
                        if (inventory.coins == 0)
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
                            if (inventory.bread_achivement)
                            {
                                Console.WriteLine("Flour, 200 grams: 8 coins");
                                Console.WriteLine("Oil, 12 deciliters: 10: coins");
                            }
                            if (inventory.meat_achivement)
                            {
                                Console.WriteLine("Meat, 4 packages: 5 coins");
                                Console.WriteLine("Lasagna, 1: 150 coins(being rich to buy this recommended)");
                                Thread.Sleep(3);
                                Console.WriteLine("Write in commands below what you want to buy:");
                                Console.WriteLine("Water");
                                Console.WriteLine("Potato");
                                Console.WriteLine("Carrot");
                                Console.WriteLine("Lasagna");
                                if (inventory.bread_achivement)
                                {
                                    Console.WriteLine("Flour");
                                    Console.WriteLine("Oil");
                                }
                                if (inventory.meat_achivement)
                                {
                                    Console.WriteLine("Meat");
                                }
                                string buy_commands = Console.ReadLine();
                                if ("water" == buy_commands)
                                {
                                    Console.WriteLine("Adding 20 deciliters, minus 10 coins");
                                    inventory.water += 20;
                                    inventory.coins -= 10;
                                }
                                else if ("potato" == buy_commands)
                                {
                                    Console.WriteLine("Adding 400 grams potatoes, minus 5 coins");
                                    inventory.potato += 400;
                                    inventory.coins -= 5;
                                }
                                else if ("carrot" == buy_commands)
                                {
                                    Console.WriteLine("Adding 6 carrots, minus 7 coins");
                                    inventory.carrot += 6;
                                    inventory.coins -= 7;
                                }
                                if (inventory.meat_achivement)
                                {
                                    if ("meat" == buy_commands)
                                    {
                                        Console.WriteLine("Adding 4 meat packages, minus 5 coins");
                                        inventory.meat_packages += 4;
                                        inventory.coins -= 5;
                                    }
                                }
                                else if ("lasagna" == buy_commands)
                                {
                                    Console.WriteLine("Adding 1 lasagna, minus 150 coins(JESUS!)");
                                    inventory.lasagna += 1;
                                    inventory.coins -= 150;
                                }
                                if (inventory.bread_achivement)
                                {
                                    if ("flour" == buy_commands)
                                    {
                                        Console.WriteLine("Adding 200 grams flour, minus 8 coins");
                                        inventory.flour += 200;
                                        inventory.coins -= 8;
                                    }
                                    else if ("oil" == buy_commands)
                                    {
                                        Console.WriteLine("Adding 12 deciliters, minus 12 coins");
                                        inventory.oil += 12;
                                        inventory.coins -= 12;
                                    }
                                }
                            }
                        }
                    }
                }

                
                if ("boosts" == command) {
                    Functions.clearConsole();
                    Console.WriteLine("\n\nBoosts!");
                    /*
                    Console.WriteLine(" Currently under construction! Come back later!");
                    */
                    Console.WriteLine("\n List of Boosts commands:");
                    Console.WriteLine("                          List");
                    Console.WriteLine("                          Buy");
                    Console.WriteLine("                          Exit");
                    string boosts_commands = Console.ReadLine();

                    if ("list" == boosts_commands) {
                        Console.WriteLine("Under Development");
                    }

                    
                    if (inventory.coins != 0) 
                    {
                        if ("buy" == boosts_commands) 
                        {
                            Console.WriteLine("Under Development");
                        }
                    }
                    else if ("exit" == boosts_commands) 
                    {
                        Console.WriteLine("Exiting...");
                        continue;
                    }
                    
                    else 
                    {
                        continue;
                    }
                    
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