using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HorseRace
{
    internal class Horse
    {
        //fields
        private string horseName;
        private string horseBirth;
        private string horseID;

        //properties
        public string HorseName
        {
            get { return horseName; }
            set { horseName = value; }
        }

        public string HorseBirth 
        {
            get { return horseBirth; }
            set { horseBirth = value; }
        }


        public string HorseID 
        {
            get { return horseID; }
            set { horseID = value; }

        }

        //constructors

        public Horse()
        {
            horseName = "";
            horseBirth = "";
            horseID = "";

        }

        public Horse (string horsename, string horsebirth, string horseID)
        {                  
            this.horseName = horsename;
            this.horseBirth = horsebirth;
            this.horseID = horseID;
        }



        //override methode
        public override string ToString()
        {
            return $"Horse Details - Horse Name:{horseName}, Date of Birth:{horseBirth}, Horse ID:{horseID}";
        }


    }
}
