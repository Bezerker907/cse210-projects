using System;
//I added the functionality of a "difficulty" option, where you can choose the number of words that the program hides every round.
class Program
{
    static void Main(string[] args)
    {
        References reference = new References("Helaman", 5, 12, 0);
        Scripture scripture = new Scripture(reference,

            " And now, my sons, remember, remember " +
            "that it is upon the rock of our Redeemer, " +
            "who is Christ, the Son of God, that ye must " +
            "build your foundation; that when the devil " +
            "shall send forth his mighty winds, yea, his " +
            "shafts in the whirlwind, yea, when all his " +
            "hail and his mighty storm shall beat upon you, " +
            "it shall have no power over you to drag you " +
            "down to the gulf of misery and endless wo, " +
            "because of the rock upon which ye are built, " +
            "which is a sure foundation, a foundation whereon " +
            "if men build they cannot fall.");
        string input;

        int wordCount = 0;

        foreach (string word in scripture.GetDisplayText().Split(" ")) {
            wordCount ++;
        }

        Console.WriteLine("Welcome to the Scripture Memorizer program!");

        Console.WriteLine();

        Console.Write("Enter the difficulty (The number of items removed on each round): ");

        int difficulty;
        do {
            difficulty = int.Parse(Console.ReadLine());
            if (difficulty < 1) {
                Console.Write("Invalid entry. Please enter a number 1 or greater: ");
            }
            if (difficulty > wordCount) {
                difficulty = wordCount;
            }
        }
        while (difficulty < 1);
        

        do
        {
            Console.Clear();

            string scriptureText = scripture.GetDisplayText();

            Console.WriteLine(scriptureText);

            Console.WriteLine();

            Console.WriteLine("Press enter to continue or type 'quit' to finish:");

            input = Console.ReadLine();
            
            if (scripture.IsCompletelyHidden()) {
                break;
            }

            scripture.HideRandomWords(difficulty);

            Console.Clear();
        }

        while (input.ToLower() != "quit");

        Console.WriteLine("Goodbye!");
    }
}