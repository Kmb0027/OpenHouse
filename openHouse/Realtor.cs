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

            }
            else if (userItemSelection == "none")
            {
                Console.Clear();
                Speak("Okay we can see something else");
            }

            return "Okay we can see something else.";

        }

        public void LetUserSelectItems(Room room)
        {
            for (int i = 0; i < 4; i++)
            {
                Speak($"Which of those items would you like to know more about?");
                string userItemSelection = Console.ReadLine();

                GiveUserItemChoice(userItemSelection, room.ItemsInsideRoom[0].Name , room.ItemsInsideRoom[0].Description);
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

        public List<string> Houses { get; set; }= new List<string>();

    }
}


