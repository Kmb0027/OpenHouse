using System;
using System.Collections.Generic;
namespace openHouse
{
    class Program
    {  
        static void Main(string[] args)
        {
            Realtor realtor = new Realtor("Mitch");
            House house1 = new House("123 Main");

            Room kitchen = new Room("Kitchen");

            Items sink = new Items("Kitchen Sink");
            sink.Description = $"This {sink.Name} is a farm-style sink with industrial spray nozzel.";
            kitchen.ItemsInside.Add(sink);
            Items stove = new Items("Kitchen Stove");
            stove.Description = $"The {stove.Name} is a gas appliance that is fifteen years old.";
            kitchen.ItemsInside.Add(stove);
            Items cabinets = new Items("Kitchen Cabinets");
            cabinets.Description = $"These {cabinets.Name} are hand-made oak cabinets.";
            kitchen.ItemsInside.Add(cabinets);

            Room bedRoom = new Room("Bedroom");

            Items floor = new Items("Wooden Floors");
            floor.Description = "These floors are original maple hardwood.";
            bedRoom.ItemsInside.Add(floor);
            Items ceilingFan = new Items("Ceiling Fan");
            ceilingFan.Description = "This fan has 4 blades and a beautiful light fixture";
            bedRoom.ItemsInside.Add(ceilingFan);
            Items closet = new Items("Bedroom Closet");
            closet.Description = "This is a walk-in closet with a shoe rack";
            bedRoom.ItemsInside.Add(closet);

            Room livingRoom = new Room("Living Room");

            Items fireplace = new Items("Fireplace");
            fireplace.Description = "This is a real brick, wood burning fireplace";
            livingRoom.ItemsInside.Add(fireplace);
            Items outlets = new Items("Wall Outlets");
            outlets.Description = "There are 4 grounded electrical outlets and one cable t.v. outlet";
            livingRoom.ItemsInside.Add(outlets);
            Items window = new Items("Window");
            window.Description = "The large bay window overlooks the front yard and lets in a lot of light";
            livingRoom.ItemsInside.Add(window);
            house1.Rooms.Add(bedRoom);
            house1.Rooms.Add(kitchen);
            house1.Rooms.Add(livingRoom);

            realtor.Speak($"Hello! My name is {realtor.Name}");
            realtor.Speak($"Would you like to tour the house at {house1.Address}?");
            if (realtor.UserAnsweredYes(Console.ReadLine()))
            {
                realtor.Speak($"The house has a {kitchen.Name}, a {livingRoom.Name}, and a {bedRoom.Name}.");
            }
            else { realtor.Speak("Bye!"); }

            bool endDialogue = true;
            while (endDialogue == true)
            {
                realtor.Speak($"Do you want to see the {kitchen.Name}, {livingRoom.Name} or the {bedRoom.Name}?");
                string userRoomSelection = Console.ReadLine();
                if (userRoomSelection.ToUpper() == kitchen.Name.ToUpper())
                {
                    realtor.Speak($"The {kitchen.Name} has several interesting items like {sink.Name}, {stove.Name}, and {cabinets.Name}");

                    for (int i = 0; i <= 5; i++)
                    {
                        string userItemSelection = Console.ReadLine();

                        realtor.GiveUserItemChoice(userItemSelection, stove.Name, stove.Description, sink.Name, sink.Description, cabinets.Name, cabinets.Description);
                        if (i == 5)
                        {
                            realtor.Speak("Let's move on.");
                        }
                        else if (userItemSelection == "none")
                        {
                            break;
                        }
                    }

                }
                else if (userRoomSelection.ToUpper() == bedRoom.Name.ToUpper())
                {
                    realtor.Speak($"The {bedRoom.Name} has several interesting items like {floor.Name}, {ceilingFan.Name}, and {closet.Name}");

                    for (int i = 0; i <= 5; i++)
                    {
                        string userItemSelection = Console.ReadLine();

                        realtor.GiveUserItemChoice(userItemSelection, floor.Name, floor.Description, ceilingFan.Name, ceilingFan.Description, closet.Name, closet.Description);
                        if (i == 5)
                        {
                            realtor.Speak("Let's move on.");
                        }
                        else if (userItemSelection == "none")
                        {
                            break;
                        }
                    }
                }
                else if (userRoomSelection.ToUpper() == livingRoom.Name.ToUpper())
                {
                    realtor.Speak($"The {livingRoom.Name} has several interesting items like {window.Name}, {outlets.Name}, and {fireplace.Name}");

                    for (int i = 0; i <= 5; i++)
                    {
                        string userItemSelection = Console.ReadLine();

                        realtor.GiveUserItemChoice(userItemSelection, window.Name, window.Description, outlets.Name, outlets.Description, fireplace.Name, fireplace.Description);
                        if (i == 5)
                        {
                            realtor.Speak("Let's move on.");
                        }
                        else if (userItemSelection == "none")
                        {
                            break;
                        }

                    }
                }
                else
                {
                    endDialogue = false;
                    realtor.Speak("Thank you for coming in today!");
                }
            }
        }
    }
}



