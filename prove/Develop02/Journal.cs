public class Journal
{
    public List<string> entries = new List<string>();
    public Entry startEntries = new Entry();

    public Journal()
    {
    }

    //creates new journal entry and stores it (not yet saved to file)
    public void NewJournalEntry()
    {
        string newEntry = startEntries.NewEntry();
        entries.Add(newEntry);
    }

    //displays all current entries, account for no journal entries
    public void DisplayJournal()
    {
        if (entries.Count > 0)
        {
            Console.WriteLine("\n--- All Current Journal Entries ---");
            foreach (string entry in entries)
            {
                Console.WriteLine(entry);
            }
            Console.WriteLine("-----------------------------------\n");
        }
        else
        {
            Console.WriteLine("\nNo journal entries to display.\n");
        }
    }

    //saves it all to file
    public void SaveJournal()
    {
        Console.Write("Enter the file name to save the journal (e.g., Journal.txt): ");
        string fileName = Console.ReadLine();

        File.WriteAllLines(fileName, entries);
        Console.WriteLine("Journal saved successfully.");
    }

    //loads from file name, account for incorrect file name
    public void LoadJournal()
    {
        Console.Write("Enter the journal file to load (e.g., Journal.txt): ");
        string loadFile = Console.ReadLine();

        if (File.Exists(loadFile))
        {
            //clears all the previous entries before loading new ones.
            entries.Clear();

            string[] loadedEntries = File.ReadAllLines(loadFile);
            entries.AddRange(loadedEntries);
            Console.WriteLine($"Loaded entries from {loadFile}.");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}

