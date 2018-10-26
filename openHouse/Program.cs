using System;
using System.Collections.Generic;
namespace openHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();

            Realtor realtor = new Realtor("Mitch");
            House house1 = new House("123 Main");

            Room kitchen = new Room("Kitchen");

            Item sink = new Item("Kitchen Sink");
            sink.Description = $"This {sink.Name} is a farm-style sink with industrial spray nozzel.";
            kitchen.ItemsInsideRoom.Add(sink);
            Item stove = new Item("Kitchen Stove");
            stove.Description = $"The {stove.Name} is a gas appliance that is fifteen years old.";
            kitchen.ItemsInsideRoom.Add(stove);
            Item cabinets = new Item("Kitchen Cabinets");
            cabinets.Description = $"These {cabinets.Name} are hand-made oak cabinets.";
            kitchen.ItemsInsideRoom.Add(cabinets);

            Room bedRoom = new Room("Bedroom");

            Item floor = new Item("Wooden Floors");
            floor.Description = "These floors are original maple hardwood.";
            bedRoom.ItemsInsideRoom.Add(floor);
            Item ceilingFan = new Item("Ceiling Fan");
            ceilingFan.Description = "This fan has 4 blades and a beautiful light fixture";
            bedRoom.ItemsInsideRoom.Add(ceilingFan);
            Item closet = new Item("Bedroom Closet");
            closet.Description = "This is a walk-in closet with a shoe rack";
            bedRoom.ItemsInsideRoom.Add(closet);

            Room livingRoom = new Room("Living Room");

            Item fireplace = new Item("Fireplace");
            fireplace.Description = "This is a real brick, wood burning fireplace";
            livingRoom.ItemsInsideRoom.Add(fireplace);
            Item outlets = new Item("Wall Outlets");
            outlets.Description = "There are 4 grounded electrical outlets and one cable t.v. outlet";
            livingRoom.ItemsInsideRoom.Add(outlets);
            Item window = new Item("Window");
            window.Description = "The large bay window overlooks the front yard and lets in a lot of light";
            livingRoom.ItemsInsideRoom.Add(window);
            house1.Rooms.Add(bedRoom);
            house1.Rooms.Add(kitchen);
            house1.Rooms.Add(livingRoom);

            realtor.Speak($"Hello! My name is {realtor.Name}");
            realtor.Speak($"Would you like to tour the house at {house1.Address}?");
            if (realtor.UserAnsweredYes(Console.ReadLine()))
            {
                realtor.Speak($"The house has a {kitchen.Name}, a {livingRoom.Name}, and a {bedRoom.Name}.");
            }
            else { realtor.Speak("Bye!"); Console.ReadLine(); Environment.Exit(1); }
            bool endDialogue = true;
            while (endDialogue == true)
            {
                realtor.Speak($"Do you want to see the {kitchen.Name}, {livingRoom.Name} or the {bedRoom.Name}?");
                string userRoomSelection = Console.ReadLine();
                if (userRoomSelection.ToUpper() == kitchen.Name.ToUpper())
                {
                    Console.Clear();
                    realtor.Speak($"The {kitchen.Name} has several interesting items like {sink.Name}, {stove.Name}, and {cabinets.Name}");
                    realtor.LetUserSelectItems(kitchen);
                }
                else if (userRoomSelection.ToUpper() == bedRoom.Name.ToUpper())
                {
                    Console.Clear();
                    realtor.Speak($"The {bedRoom.Name} has several interesting items like {floor.Name}, {ceilingFan.Name}, and {closet.Name}");
                    realtor.LetUserSelectItems(bedRoom);
                }
                else if (userRoomSelection.ToUpper() == livingRoom.Name.ToUpper())
                {
                    Console.Clear();
                    realtor.Speak($"The {livingRoom.Name} has several interesting items like {window.Name}, {outlets.Name}, and {fireplace.Name}");
                    realtor.LetUserSelectItems(livingRoom);
                }
                else
                {
                    endDialogue = false;
                    realtor.Speak("Thank you for coming in today!");
                }
            }
            Console.ReadLine();
        }
    }
}