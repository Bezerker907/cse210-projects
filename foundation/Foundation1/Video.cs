using System.Collections.Generic;

public class Video
{
    private string _title;
    private string _author;
    private int _vidLength;
    public List<Comment> Comments;

    public Video(string title, string author, int vidLength)
    {
        _title = title;
        _author = author;
        _vidLength = vidLength;
        Comments = new List<Comment>();
    }

    public int GetNumberOfComments()
    {
        return Comments.Count;
    }

    public void DisplayVideoDetails()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_vidLength} seconds");
        Console.WriteLine($"Number of Comments: {GetNumberOfComments()}");

        Console.WriteLine("Comments:");
        foreach (var comment in Comments)
        {
            Console.WriteLine(comment.DisplayComment());
        }
        Console.WriteLine("------------------------");
    }
}