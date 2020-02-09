using System;

namespace EventTracker
{
    class Event
    {
        private static int NextID = 0;
        private int ID;        
        private string Description;
        private DateTime? CompletedDate;

        //Default Constructor
        public Event()
        {
            ID = NextID;
            Description = "";
            CompletedDate = null;
            NextID++;
        }

        //Overloaded Constructor
        //this() calls the default constructor
        public Event(string description) : this()
        {
            Description = description;
        }

        public int GetID() => ID;

        public string GetDescription() => Description;

        public void SetDescription(string description) => Description = description;

        public DateTime? GetCompletedDate() => CompletedDate;

        public void SetCompletedDate(DateTime? completedDate) => CompletedDate = completedDate;

        public override string ToString()
        {
            if(CompletedDate == null)
                return $"TODO -> {Description}.";
            else
                return $"Completed on {CompletedDate} -> {Description}.";
        }
    }
}
