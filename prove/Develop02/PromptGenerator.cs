using System;

public class PromptGenerator
{
    private List<string> _promptList = new List<string>();
    private Random rndPrompt = new Random();

    //add stuff to the prompt list
    public PromptGenerator()
    {
        _promptList.Add("Who is the most interesting person you have met today?");
        _promptList.Add("What was the best part of my day?");
        _promptList.Add("How did I see the hand of the Lord in my life today?");
        _promptList.Add("What was the strongest emotion I felt today?");
        _promptList.Add("If I had one thing I could do over today, what would it be?");
        _promptList.Add("What was the weirdest thing I saw today?");
        _promptList.Add("How can I improve tomorrow?");
        _promptList.Add("How have I furthered my life goals?");
    }

    //pick a random prompt
    public string GetRandomPrompt()
    {
        int randIndex = rndPrompt.Next(_promptList.Count); //get a number for index
        return _promptList[randIndex]; //return said index
    }
}