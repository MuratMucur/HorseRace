using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace HorseRace
{
    internal class Race
    {
        //fields
        private string raceName;
        private string raceTime;
        private List<Horse> horses = new List<Horse>();

        public string RaceName
        {
            get { return raceName; }
            set { raceName = value; }

        }
        public string RaceTime
        {
            get { return raceTime; }
            set { raceTime = value; }
        }
        public List<Horse> Horses
        {
            get { return horses; }
            set { horses = value; }
        }

        //constuctors 

        public Race()
        {
            raceName = "";
            raceTime = "";

        }



        public Race(string racename, string racetime)         
        {
            this.raceName  = racename;
            this.raceTime = racetime;

        }

        //Methode
        public void AddHorse(Horse newHorse)
        {
            horses.Add(newHorse);
        }


        //Methode to display race details

        public override string ToString()
        {
            return $" Race Name:{raceName}, Race Time:{raceTime}";
        }
     

    }


}



