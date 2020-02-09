using System;

namespace EventTracker
{
    class EventBook
    {
        private const int MaxEvents = 10;
        private int NumEvents;
        private Event[] Events;

        //Default Constructor
        public EventBook()
        {
            NumEvents = 0;
            Events = new Event[MaxEvents];
        }

        public void AddEvent(Event newEvent)
        {
            Events[newEvent.GetID()] = newEvent;
            NumEvents++;
        }

        public Event GetEvent(int index)
        {
            return Events[index];
        }

        public int GetNumEvents() => NumEvents;

        public void EditEventDescription(int index, string description)
        {
            //TODO: Update Events[index]'s description
        }

        public void MarkEventCompleted(int index)
        {
            //Set Events[index] to completed
            Events[index].SetCompletedDate(DateTime.Now);
        }

        public void PrintEvents()
        {
            for(int i=0; i<NumEvents; i++)
            {
                Console.WriteLine($"Event {i}: {Events[i]}");
            }
        }

    }
}
