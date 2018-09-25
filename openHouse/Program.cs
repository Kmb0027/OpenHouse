using System;

namespace openHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            //heavy on if statements
            /* 1)User that's visiting an open house. 2) Promp user to visit rooms. 3)Optionally visit rooms. a)Ask about things in the room b)Optionally describe things
             * 4)The above, but continued w/open house aspects */

            Console.WriteLine("Hello! Welcome to our open house.");

            Console.WriteLine("Would you like to take a tour of the living room?");

            string livingRoomResponse = Console.ReadLine();


            if(livingRoomResponse.ToUpper() == "Y" || livingRoomResponse.ToUpper() == "YES" || livingRoomResponse.ToUpper() == "YEAH" || livingRoomResponse.ToUpper() == "YEP")
            {
                Console.WriteLine("This twelve by eight foot living area has wooden floors, a ceiling fan, a fireplace, and a television.");

                Console.WriteLine("Would you like to know about any of these particular features?");
                string livingRoomFeatureResponse = Console.ReadLine();
                if(livingRoomFeatureResponse.ToUpper() == "Y" || livingRoomFeatureResponse.ToUpper() == "YES" || livingRoomFeatureResponse.ToUpper() == "YEAH" || livingRoomFeatureResponse.ToUpper() == "YEP")
                {
                    Console.WriteLine("Which feature would you like to know more about?");
                    string livingRoomFeatureSelection = Console.ReadLine();
                    if(livingRoomFeatureResponse.ToUpper() == "CEILING FAN")
                    {
                        Console.WriteLine("This is a 4 bladed fan with three speed settings. It has four light fixtures with 40watt incandescent bulbs.");

                    }else if(livingRoomFeatureSelection.ToUpper() == "FIREPLACE")
                    {
                        Console.WriteLine("The fireplace has the original brick from the Sixties, and the oak mantle was added later.");

                    }else if(livingRoomFeatureSelection.ToUpper() == "TELEVISION")
                    {
                        Console.WriteLine("Unfortunately, the current owners will be taking the t.v. with them, but there is cable access for this room only.");

                    }else if(livingRoomFeatureSelection.ToUpper() == "WOODEN FLOORS" || livingRoomFeatureSelection.ToUpper() == "FLOORS" || livingRoomFeatureSelection.ToUpper() == "FLOOR")
                    {
                        Console.WriteLine("These hard wood floors are original pine wood from the Sixties when the house was constructed.");

                    }
                }else
                {
                    Console.WriteLine("I'm not sure what you mean. Let's continue.");
                }
            }


            Console.WriteLine("Okay then. Would you be interested in seeing the kitchen?");

            string kitchenResponse = Console.ReadLine();

            if(kitchenResponse.ToUpper() == "Y" || kitchenResponse.ToUpper() == "YES" || kitchenResponse.ToUpper() == "YEAH" || kitchenResponse.ToUpper() == "YEP")
            {
                Console.WriteLine("The kitchen is equipped with a stove, a dish washer, and a sink.");
                Console.WriteLine("Would you like to know more about the kitchen?");
                string kitchenFeatureResponse = Console.ReadLine();
                if (kitchenFeatureResponse.ToUpper() == "Y" || kitchenFeatureResponse.ToUpper() == "YES" || kitchenFeatureResponse.ToUpper() == "YEAH" || kitchenFeatureResponse.ToUpper() == "YEP")
                {
                    Console.WriteLine("Which item are you interested in?");
                    string kitchenFeatureSelection = Console.ReadLine();
                    if(kitchenFeatureSelection.ToUpper() == "STOVE")
                    {
                        Console.WriteLine("This gas stove is 10 years old, and comes with four eyes and a broiler feature.");

                    }else if (kitchenFeatureSelection.ToUpper() == "DISH WASHER" )
                    {
                        Console.WriteLine("The dish washer is a GE product, and is currently still under warrenty.");
                    }else if (kitchenFeatureSelection.ToUpper() == "SINK")
                    {
                        Console.WriteLine("The sink is a large, farmhouse style sink with a restaurant grade spray nozzle. ");
                    }else
                    {
                        Console.WriteLine("I'll have to check with the owner. Anyway...");
                    }

                }
            }else
            {
                Console.WriteLine("Okay. We can move on then.");
            }


            Console.WriteLine("The bedrooms are upstairs. Shall we?");




        }
    }
}
