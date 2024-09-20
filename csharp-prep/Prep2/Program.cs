using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        string userGrade = Console.ReadLine();
        int gradeNumber = int.Parse(userGrade);

        string gradeLetter = "";

        if (gradeNumber >= 90)
        {
            gradeLetter = "A";
        }
        else if (gradeNumber >= 80)
        {
            gradeLetter = "B";
        }
        else if (gradeNumber >= 70)
        {
            gradeLetter = "C";
        }
        else if (gradeNumber >= 60)
        {
            gradeLetter = "D";
        }
        else
        {
            gradeLetter = "F";
        }

        string passfail = "";
        
        if (gradeNumber >= 70)
        {
            passfail = "pass";
        }
        else
        {
            passfail = "fail";
        }


        Console.WriteLine($"Your lettergrade is {gradeLetter}. That means you have {passfail}ed the course.");
        if (passfail == "pass")
        {
            Console.Write("Good job! Keep up the good work!");
        }
        else if (passfail == "fail")
        {
            Console.Write("You should really try better next time.");
        }


    }
}