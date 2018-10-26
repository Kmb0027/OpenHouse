using System;
using System.Collections.Generic;
namespace openHouse
{
    public class Room
    {
        public Room(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
        public List<Item> ItemsInsideRoom { get; set; } = new List<Item>();
    }
}
