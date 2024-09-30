public class Entry
{
    PromptGenerator getPrompt = new PromptGenerator();
    DateTime theCurrentDate = DateTime.Now;    

    public Entry()
    {
    }

public string NewEntry()
    {
        //converts date into string, prints
        string dateText = theCurrentDate.ToShortDateString();
        Console.WriteLine($"Date: {dateText}");

        //gets a random prompt, prints
        string randomPrompt = getPrompt.GetRandomPrompt();
        Console.WriteLine($"Prompt: {randomPrompt}");

        //gets the users input for their entry
        Console.Write("Begin Journal Entry: ");
        string journalEntry = Console.ReadLine();

        //combines and formats the stuffs
        string combinedEntry = $"~|~ {dateText} | {randomPrompt}:\n {journalEntry} ~|~";
        
        return combinedEntry;
    }
}