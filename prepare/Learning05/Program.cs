using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment simpleAssignment = new Assignment("McKay", "Fractions");
        Console.WriteLine(simpleAssignment.GetSummary());

        MathAssignment fractions = new MathAssignment("18.2", "8-19", "McKay", "Fractions");
        Console.WriteLine(fractions.GetHomeworkList());

        WritingAssignment history = new WritingAssignment("Doing the Things", "McKay", "History");
        Console.WriteLine (history.GetWritingInfo());
    }
}