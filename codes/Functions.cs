using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Data;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

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

        public static void clearConsole() 
        {
            Console.Clear();
        }

        public static void save(string inventory) 
        {
            Console.WriteLine("Saving to file...");
            Thread.Sleep(2000);
            
            string fileName = "Save_cooking_game.json"; 
            string jsonString = JsonSerializer.Serialize(inventory);
            File.WriteAllText(fileName, jsonString);
        }

        public static data load() {
            Console.WriteLine("Saving to file...");
            Thread.Sleep(2000);
            
            try {
                string fileName = "Save_cooking_game.json"; 
                string jsonString = File.ReadAllText(fileName);
                data inventory = JsonSerializer.Deserialize<data>(jsonString)!;
                return inventory;
            } catch {
                Console.WriteLine("No save found!");
                return null;
            }
        }
    }
    public class data {
        public string username {get; set;}
        public bool water_enough {get; set;}
        public bool potato_enough {get; set;}
        public bool carrot_enough {get; set;}
        public bool meat_enough {get; set;}
        public bool oil_enough {get; set;}
        public bool flour_enough {get; set;}
        public float coins {get; set;}
        public float water {get; set;}  // deciliters
        public float lasagna {get; set;}
        public float baked_lasagna {get; set;}
        public float potato {get; set;}  // grams
        public float carrot {get; set;}  // 12 carrots
        public float meat_packages {get; set;}  // going to be 20 meat packages
        public bool meat_achivement {get; set;}
        public float soup {get; set;}
        public float soup_with_meat {get; set;}
        public float bread {get; set;}
        public float level {get; set;}
        public float xp {get; set;}
        public float xp_need {get; set;}
        public float xp_rest {get; set;}
        public bool bread_achivement {get; set;}
        public float flour {get; set;}  // grams
        public float oil {get; set;}  // deciliters
    }

}
