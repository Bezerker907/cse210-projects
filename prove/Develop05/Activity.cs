public class Activity
{
    //type function to simulate typing effect
    public static void Type(string text, int delay = 35)
    {
        foreach (char c in text)
        {
            Console.Write(c);
            Thread.Sleep(delay);
        }
        Console.WriteLine();
    }

    //Variables
    private string _activityName;
    private int _durationSeconds;
    private string _activityDescription;
    protected int _prepareTime;
    protected int _beReady;
    
    public Activity() {

    }

    public Activity(string name, string description) {
        _activityName = name;
        _activityDescription = description;
        _beReady = 4;
    }

    public void DisplayStartMessage() {
        Type($"Welcome to the {_activityName}");
        Console.WriteLine();
        Type(_activityDescription);
        Console.WriteLine();
        Type("How long, in seconds, would you like for your session? ");
        string seconds = Console.ReadLine();
        int secondsInt = int.Parse(seconds);
        SetDurationSeconds(secondsInt);
    }

    public void DisplayEndMessage() {
        Type("Well done!!");
        MiniSpinner(4);
        Type($"You have completed another {_durationSeconds} seconds of the {_activityName}");
        MiniSpinner(4);
        Console.Clear();
    }

    public void PauseSpinner() {
        for (int i = 1; i <= 1; i++)
        { 
            MiniSpinner(4);
        }
        Console.Clear();
    }

    public void PauseCountdownTimer() {
        for (int i = 0; i < 1; i++)
        {
            Console.Write("\bYou may begin in: 5");
            Thread.Sleep(1000);
            Console.Write("\b4");
            Thread.Sleep(1000);
            Console.Write("\b3");
            Thread.Sleep(1000);
            Console.Write("\b2");
            Thread.Sleep(1000);
            Console.Write("\b1");
            Thread.Sleep(1000);
        }
        Console.Clear();
    }

    public void BeReady() {
        Type("Get ready...");
        Console.WriteLine();
        MiniSpinner(4);
    }

    public void SetDurationSeconds(int numberOfSeconds) {
        _durationSeconds = numberOfSeconds;
    }

    public int GetDurantionSeconds() {
        return _durationSeconds;   
    }

    public void MiniSpinner(int numTimes) {
        for (int i = 1; i <= numTimes; i++)
        { 
            Console.Write("\b+");
            Thread.Sleep(250);
            Console.Write("\bx");
            Thread.Sleep(250);
            Console.Write("\b+");
            Thread.Sleep(250);
            Console.Write("\bx");
            Thread.Sleep(250);
        }
        Console.Write("\b \b");
    }
}