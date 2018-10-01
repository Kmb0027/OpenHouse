using System;
namespace openHouse
{
    public class Room
    {
        public Room(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
        public List<Items> ItemsInside { get; set; } = new List<Items>();
    }
}
