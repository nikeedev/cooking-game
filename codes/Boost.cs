using System;
using System.Collections.Generic;
using System.Text;

namespace cooking_game_csharp.codes
{
    public class Boost
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Time { get; set; }
        
        public Boost(string Name, string Description, int Time)
        {
            this.Name = Name;
            this.Description = Description;
            this.Time = Time;

        }
    }
}
