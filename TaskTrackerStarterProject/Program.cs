using System;

namespace EventTracker
{
    class Program
    {
        static EventBook eventBook;

        static void MainMenu()
        {
            int userInput = 0;
            while(userInput != -1)
            {
                Console.WriteLine("---------------");
                Console.WriteLine("---MAIN MENU---");
                Console.WriteLine("---------------");
                Console.WriteLine("Please Select An Option Below:");
                Console.WriteLine("  1) Add A New Event");
                Console.WriteLine("  2) Mark Event As Completed");
                Console.WriteLine("  3) Edit Event Description");
                Console.WriteLine("  4) List Events");
                userInput = int.Parse(Console.ReadLine());
                switch(userInput)
                {
                    case -1:
                        break;
                    case 1:
                        CreateEventMenu();
                        break;
                    case 2:
                        MarkEventCompletedMenu();
                        break;
                    case 3:
                        //TODO EditEventDescriptionMenu();
                        break;
                    case 4:
                        eventBook.PrintEvents();
                        break;
                    default:
                        break;
                }
            }
        }

        static void CreateEventMenu()
        {
            Event newEvent = new Event();

            //TODO:  Prompt User for Event description information:
            //


            eventBook.AddEvent(newEvent);
        }

        static void MarkEventCompletedMenu()
        {
            //Displays all of the events in the event book
            eventBook.PrintEvents();
            //Prompts the user to select the index of the event to select
            Console.WriteLine("Please enter the number of the event you wish to mark as complete: ");
            int selectedEventIndex = int.Parse(Console.ReadLine());
            if(selectedEventIndex >= 0 && selectedEventIndex < eventBook.GetNumEvents())
                eventBook.MarkEventCompleted(selectedEventIndex);
        }

        static void Main(string[] args)
        {
            eventBook = new EventBook();

            Event e = new Event("new event");
            Console.WriteLine(e);
            e.SetCompletedDate(DateTime.Now);
            Console.WriteLine(e);

            eventBook.AddEvent(e);

            MainMenu();
        }
    }
}
