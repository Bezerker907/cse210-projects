//Hello! This is my first prove project of the class so I'm gonna try to use comments more often throughout.
//For part of my creative endeavors, I found out online how to use the int.TryParse to better have inputs. 
//It will screen for a proper command first and allow the code to keep trying rather than break first mistake it finds.
//Adding general error handling and a more user friendly experience.


using System;

class Program
{
    static void Main(string[] args)
    {
        Journal newJournal = new Journal();
        
        int useMenu = 100; //chosing number that won't be used

        while (useMenu != 0)
        {
            Console.WriteLine("Welcome to the Journal app!");
            Console.WriteLine("------------------------");
            Console.WriteLine("[1]  New Entry");
            Console.WriteLine("[2]  See all Entries");
            Console.WriteLine("[3]  Save Entry");
            Console.WriteLine("[4]  Load Entry");
            Console.WriteLine("[5]  End program");
            Console.WriteLine("------------------------");
            Console.WriteLine("Enter number to select menu options.");

            string menu = Console.ReadLine();
            int menuNum;
            //checks if input is a valid number, also screens for ensuring it is an int, not a str
            while (!int.TryParse(menu, out menuNum) || menuNum < 1 || menuNum > 5)
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 5.");
                menu = Console.ReadLine();
            }

            //menu options
            if (menuNum == 1)//NEW ENTRY
            {
                Console.WriteLine("");
                newJournal.NewJournalEntry();
            }
            else if (menuNum == 2)//SEE ALL ENTRIES
            {
                Console.WriteLine("");
                newJournal.DisplayJournal();
            }
            else if (menuNum == 3)//SAVE ENTRY
            {
                Console.WriteLine("");
                newJournal.SaveJournal();
            }
            else if (menuNum == 4)//LOAD ENTRY
            {
                Console.WriteLine("");
                newJournal.LoadJournal();

                //since the loadjournal is invisble, ill load to make it more clear
                newJournal.DisplayJournal();
            }
            else if (menuNum == 5)//END PROGRAM
            {
                Console.WriteLine("");
                Console.WriteLine("Ending program, goodbye!");
                break; //exit the loop and end program
            }
        }
    }
}