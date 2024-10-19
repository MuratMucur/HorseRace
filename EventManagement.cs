using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HorseRace
{
    internal class EventManagement
    {
        //fields
        private string eventName;
        private string location;
        private int numberOfRaces;
        private List <Race> races = new List <Race> ();

        //properties
        public string EventName
        {
            get { return eventName; } 
            set { eventName = value; } 
        
        }

        public string Location
        { 
            get { return location; } 
            set {  location = value; } 
        }
        public int NumberOfRaces
        { 
            get { return numberOfRaces; } 
            set { numberOfRaces = value; } 
        }
        public List<Race> Races
        {
            get { return races; }
            set { races = value; }
        }

        //Constructors
        public EventManagement()
        {
            eventName = " ";
            location = " ";
            numberOfRaces = 1;  
             
        }
        public EventManagement(string eventname, string location, int numberofraces)
        {
            this.eventName = eventname;
            this.location = location;
            this.numberOfRaces = numberofraces;

        }

        //methode for add new race

        public void AddRace (Race newRace)
        {
            races.Add(newRace);
        }

        //methode for new race event

        public override string ToString()
        {
            return $"Event - Event Name:{eventName}, Location:{location}, Number of Races:{numberOfRaces}";
        }
       
         

    }
}
