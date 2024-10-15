using System.Runtime.InteropServices;

public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string title, string studentName, string topic) : base(studentName, topic)
    {
        _title = title;
    }

    public string GetWritingInfo()
    {
        return $"Title: {_title} by {_studentName}";
    }
}