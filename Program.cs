using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;



namespace HorseRace
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Please select the following");
            Console.WriteLine("For manager, press 1");
            Console.WriteLine("For horse owner, press 2");
            Console.WriteLine("For Racegoer, press 3");

            string UserChoice = Console.ReadLine();
            int UserChoiceNumber = 0;
            while (!Int32.TryParse(UserChoice, out UserChoiceNumber) || UserChoiceNumber < 1 || UserChoiceNumber > 3)
            {
                Console.WriteLine("Invalid selection!");
                Console.WriteLine("Please select the following");
                Console.WriteLine("For manager, press 1");
                Console.WriteLine("For horse owner, press 2");
                Console.WriteLine("For Racegoer, press 3");
                UserChoice = Console.ReadLine();

            }

            if (UserChoiceNumber == 1)
            {

                Console.WriteLine("Please select the following");
                Console.WriteLine("To create new event and add races, press 1");
                Console.WriteLine("To upload list of horses, press 2");

                string userChoice2 = Console.ReadLine();
                int userChoiceNumber2 = 0;
                while (!Int32.TryParse(userChoice2, out userChoiceNumber2) || userChoiceNumber2 < 1 || userChoiceNumber2 > 2)
                {
                    Console.WriteLine("Invalid selection!");
                    Console.WriteLine("Please select the following");
                    Console.WriteLine("To create new event and add races, press 1");
                    Console.WriteLine("To upload list of horses, press 2");
                    userChoice2 = Console.ReadLine();
                }
                if (userChoiceNumber2 == 1)
                {


                   
                    EventManagement newEvent = CreateNewEvent();
                    Console.WriteLine(newEvent);
                    Race race1 = CreateRace();
                    Race race2 = new Race("Shelby Tournement", "Wednesday");
                    newEvent.AddRace(race1);
                    newEvent.AddRace(race2);
                    Console.WriteLine(newEvent);

                    foreach (Race race in newEvent.Races)
                    {
                        Console.WriteLine(race);
                    }




                }
                else if (userChoiceNumber2 == 2)
                {
                    Console.WriteLine("Create a race to upload list of horses");
                    Race race3 = CreateRace();

                    string filePath = "horses.txt";
                    Readfromfile(filePath);

                }


            }
            else if (UserChoiceNumber == 2)
            {

                Race race3 = new Race("Dundalk", "Wednesday");
                Race race4 = new Race("Cheltenham", "Thursday");
                Race race5 = new Race("Christmas Fest", "Sunday");
                Console.WriteLine("You can add a horse in the following races");
                Console.WriteLine(race3);
                Console.WriteLine(race4);
                Console.WriteLine(race5);
                

                while (true)
                {

                    Console.WriteLine("Press 1 for Dundalk");
                    Console.WriteLine("Press 2 for Cheltenham");
                    Console.WriteLine("Press 3 for Christmas Fest");
                    Console.WriteLine("Press 0 for Exit");
                    Console.Write("Choose an option:");

                    var input = Console.ReadLine();

                    switch (input)
                    {
                        case "1":
                            Horse horse1 = CreateHorse();
                            race3.AddHorse(horse1);
                            Console.WriteLine(race3);

                            foreach (Horse horse in race3.Horses)
                            {
                                Console.WriteLine(horse);
                            }
                            break;

                        case "2":
                            Horse horse2 = CreateHorse();
                            race4.AddHorse(horse2);
                            Console.WriteLine(race4);
                            foreach (Horse horse in race4.Horses)
                            {
                                Console.WriteLine(horse);
                            }
                            break;

                        case "3":
                            Horse horse3 = CreateHorse();
                            race5.AddHorse(horse3);
                            Console.WriteLine(race5);
                            foreach (Horse horse in race5.Horses)
                            {
                                Console.WriteLine(horse);
                            }
                            break;

                        case "0":
                            return;

                        default:
                            Console.WriteLine("invalid selection.Try again.");
                            break;

                    }
                }
            }

            else if (UserChoiceNumber == 3)
            {
                
                Console.WriteLine("sorry I didnt figure out this section:(");
            }


        }

        public static EventManagement CreateNewEvent()
        {
            EventManagement newEvent = new EventManagement();
            Console.WriteLine("Please enter details for new race event");
            Console.Write("Event Name:");
            newEvent.EventName = Console.ReadLine();
            Console.Write("Event Location:");
            newEvent.Location = Console.ReadLine();
            Console.Write("Number of Races:");
            newEvent.NumberOfRaces = int.Parse(Console.ReadLine());
            return newEvent;


        }



        private static Race CreateRace()
        {
            Race newRace = new Race();
            Console.Write("Enter race name:");
            newRace.RaceName = Console.ReadLine();
            Console.Write("Enter Date:");
            newRace.RaceTime = Console.ReadLine();
            return newRace;

        }

        private static Horse CreateHorse()
        {
            Horse NewHorse = new Horse();
            Console.Write("Enter Horse Name:");
            NewHorse.HorseName = Console.ReadLine();
            Console.Write("Enter horse date of birth(YYY-MM-DD)");
            NewHorse.HorseBirth = Console.ReadLine();
            return NewHorse;

        }




        public static void Readfromfile(string filePath)
        {
            List<string> horses = File.ReadAllLines(filePath).ToList();
            foreach (string horse in horses)
            {
                Console.WriteLine(horse);

            }


        }
    }
}
        
      