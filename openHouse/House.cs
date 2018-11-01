using System;
using System.Collections.Generic;
namespace openHouse
{
    public class House
    {
        public House(string address)
        {
            Address = address;
        }
        public string Address { get; set; }
        public List<Room> Rooms { get; set; } = new List<Room>();
    }
}
