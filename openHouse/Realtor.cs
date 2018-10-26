using System;
using System.Collections.Generic;
namespace openHouse
{
    public class Realtor
    {
        public Realtor(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
        public void Speak(string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(message);
        }
        public bool UserAnsweredYes(string answer)
        {
            if (answer.ToUpper() == "YES") { return true; }
            else if (answer.ToUpper() == "YEA") { return true; }
            else if (answer.ToUpper() == "Yeah") { return true; }
            else { return false; }

        }
        public string GiveItemDescription(string itemDescription)
        {
            Speak($"{itemDescription}");
            return "GiveItemDescription error";
        }
        public string GiveUserItemChoice(string userItemSelection, string itemName1, string itemDescription1)
        {

            if (userItemSelection.ToUpper() == itemName1.ToUpper())
            {
                GiveItemDescription(itemDescription1);
                Speak("Which item would you like to know more about?");
            }
            else if (userItemSelection == "none")
            {
                Console.Clear();
                Speak("Okay we can see something else");
            }

            return "Okay we can see something else.";

        }
        public void LetUserExamineItem(Room room)
        {
            for (int i = 0; i < 4; i++)
            {
                string userItemSelection = Console.ReadLine();

                GiveUserItemChoice(userItemSelection, room.ItemsInsideRoom[0].Name, room.ItemsInsideRoom[0].Description);
                GiveUserItemChoice(userItemSelection, room.ItemsInsideRoom[1].Name, room.ItemsInsideRoom[1].Description);
                GiveUserItemChoice(userItemSelection, room.ItemsInsideRoom[2].Name, room.ItemsInsideRoom[2].Description);
                if (i == 4)
                {
                    Speak("Let's move on.");
                }
                else if (userItemSelection == "none")
                {
                    break;
                }
            }
        }
        public void ShowHouse(House house)
        {
            Speak($"Do you want to see the {house.Rooms[0].Name}, {house.Rooms[1].Name} or the {house.Rooms[2].Name}?");
            string userRoomSelection = Console.ReadLine();
            if (userRoomSelection.ToUpper() == house.Rooms[0].Name.ToUpper())
            {
                Console.Clear();
                Speak($"The {house.Rooms[0].Name} has several interesting items like {house.Rooms[0].ItemsInsideRoom[0].Name}, {house.Rooms[0].ItemsInsideRoom[1].Name}, and {house.Rooms[0].ItemsInsideRoom[2].Name}");
                LetUserExamineItem(house.Rooms[0]);

            }
            else if (userRoomSelection.ToUpper() == house.Rooms[1].Name.ToUpper())
            {
                Console.Clear();
                Speak($"The {house.Rooms[1].Name} has several interesting items like {house.Rooms[1].ItemsInsideRoom[0].Name}, {house.Rooms[1].ItemsInsideRoom[1].Name}, and {house.Rooms[1].ItemsInsideRoom[2].Name}");
                LetUserExamineItem(house.Rooms[1]);
            }
            else if (userRoomSelection.ToUpper() == house.Rooms[2].Name.ToUpper())
            {
                Console.Clear();
                Speak($"The {house.Rooms[2].Name} has several interesting items like {house.Rooms[2].ItemsInsideRoom[0].Name}, {house.Rooms[2].ItemsInsideRoom[1].Name}, and {house.Rooms[2].ItemsInsideRoom[2].Name}");
                LetUserExamineItem(house.Rooms[2]);
            }
            else
            {
                Speak("Thank you for coming in today!");
            }
        }
        public void IntroduceHouse(House house)
        {
            Speak($"Hello! My name is {Name}");
            Speak($"Would you like to tour the house at {house.Address}?");
            if (UserAnsweredYes(Console.ReadLine()))
            {
                Speak($"The house has a {house.Rooms[0].Name}, a {house.Rooms[1].Name}, and a {house.Rooms[2].Name}.");
            }
            else { Speak("Bye!"); Console.ReadLine(); Environment.Exit(1); }

        }
        public List<string> Houses { get; set; }= new List<string>();
    }
}


