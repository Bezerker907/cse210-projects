public class References //add a way to allow the user to pick a verse to memorize.
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse = 0; //a surprise tool that will help us later


    public References(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = verse;
    }

    public References(string book, int chapter, int startVerse, int endverse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endverse;
    }
    
    public string GetReferenceText()
    {
        if (_endVerse != 0) //this way it can tell if there is multiple verses
        {
            return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_startVerse}";
        }
    }
}