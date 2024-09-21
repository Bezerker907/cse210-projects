using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int secret = randomGenerator.Next(1, 100);

        bool win = false;
        
        while (win == false)
        {
            Console.Write("What is your guess? ");
            string y = Console.ReadLine();
            int guess = int.Parse(y);
        
                if (guess > secret)
                {
                    Console.WriteLine("Lower");
                }
                else if (guess < secret)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("That's correct!");
                    win = true;
                }
        }
            





    }
}