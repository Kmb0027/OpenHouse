using System;
using System.Collections.Generic;
namespace openHouse
{
    public class Item
    {
        public Item(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
        public string Description { get; set; }

    }
}
