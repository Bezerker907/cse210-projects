using System;

class Program
{
    //I added a Type method to give a more relaxed feel to this project.

    //I don't quite know how to make this apply to my whole code without adding it
    //specifically to the "Program" file here, but I just made it an inherited Method in the Activity class.
    public static void Type(string text, int delay = 50)//the text you want typed, then default is 50 millisecond delay
    {
        foreach (char c in text)
        {
            Console.Write(c);
            Thread.Sleep(delay);//delay between each character (milliseconds)
        }
        Console.WriteLine();
    }
    static void Main(string[] args)
    {
        Boolean menu = true;
        while (menu == true) 
        {
            Type("Menu options: ", 15);
            Type("1. Start Breathing Activity", 15);
            Type("2. Start Reflecting Activity", 15);
            Type("3. Start Listing Activity", 15);
            Type("4. Quit", 15);
            Type("Select a choice from the menu: ", 15);
            string option = Console.ReadLine();
            if (option == "1")
            {
                Breathing main = new Breathing("Breathing Activity","This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                main.DisplayStartMessage();
                main.BeReady();
                DateTime startTime = DateTime.Now;
                DateTime futureTime = startTime.AddSeconds(main.GetDurantionSeconds());
                Console.Clear();
                while (DateTime.Now < futureTime) 
                {
                    main.RunBreathingActivity();
                }
                main.DisplayEndMessage();
            }
            else if (option == "2")
            {
                Reflecting main = new Reflecting("Reflecting Activity","This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                main.DisplayStartMessage();
                main.BeReady();
                main.DisplayPrompt();
                DateTime startTime = DateTime.Now;
                DateTime futureTime = startTime.AddSeconds(main.GetDurantionSeconds());
                Console.Clear();
                while (DateTime.Now < futureTime) 
                {
                    main.RunReflectingActivity();
                }
                main.DisplayEndMessage();
            }
            else if (option == "3")
            {
                Listing main = new Listing("Listing Activity","This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                main.DisplayStartMessage();
                main.BeReady();
                main.DisplayPrompt();
                DateTime startTime = DateTime.Now;
                DateTime futureTime = startTime.AddSeconds(main.GetDurantionSeconds());
                main.PauseSpinner();
                while (DateTime.Now < futureTime)
                {
                    main.RunListingActivity();
                }
                main.GetNumbPrompts();
                main.DisplayEndMessage();
            }
            else 
            {
                menu = false;
            }

        }
    }
}