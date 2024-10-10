public class Comment
{
    private string _userName;
    private string _text;

    public Comment(string userName, string text)
    {
        _userName = userName;
        _text = text;
    }

    public string DisplayComment()
    {
        return $"{_userName}: {_text}";
    }
}