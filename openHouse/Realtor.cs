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
        public string GiveUserItemChoice(string userItemSelection, string itemName1, string itemDescription1, string itemName2, string itemDescription2, string itemName3, string itemDescription3)
        {

            if (userItemSelection.ToUpper() == itemName1.ToUpper())
            {
                GiveItemDescription(itemDescription1);
                Speak("Which item would you like to know more about?");
            }
            else if (userItemSelection.ToUpper() == itemName2.ToUpper())
            {
                GiveItemDescription(itemDescription2);
                Speak("Which item would you like to know more about?");
            }
            else if (userItemSelection.ToUpper() == itemName3.ToUpper())
            {
                GiveItemDescription(itemDescription3);
                Speak("Which item would you like to know more about?");
            }
            else if (userItemSelection == "none")
            {
                Speak("Okay we can see something else");
            }


            return "Okay we can see something else.";

        }

    }
}


