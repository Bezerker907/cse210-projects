public class Breathing : Activity {
    private string _breatheIn = "Breathe in...";
    private string _breatheOut = "Now breathe out...";
    List<string> breathList = new List<string>();
    
    public Breathing(string name, string description) : base(name, description) {
        breathList.Add(_breatheIn);
        breathList.Add(_breatheOut);
    }

    public void RunBreathingActivity() {
        int i = 0;
        string s = breathList[i];
        Type($"\b{breathList[i]}5");
        Thread.Sleep(1000);
        Console.Write($"\b4");
        Thread.Sleep(1000);
        Console.Write($"\b3");
        Thread.Sleep(1000);
        Console.Write($"\b2");
        Thread.Sleep(1000);
        Console.Write($"\b1");
        Thread.Sleep(1000);
        Console.WriteLine();
        Type($"\b{breathList[i+1]}5");
        Thread.Sleep(1000);
        Console.Write($"\b4");
        Thread.Sleep(1000);
        Console.Write($"\b3");
        Thread.Sleep(1000);
        Console.Write($"\b2");
        Thread.Sleep(1000);
        Console.Write($"\b1");
        Thread.Sleep(1000);
        Console.WriteLine();
        Console.WriteLine();
        i++;
        if (i == breathList.Count) {
            i = 0;
        }
    }
}