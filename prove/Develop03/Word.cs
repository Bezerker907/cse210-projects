public class Word
{
    private string _text;
    private bool _isHidden = false;


    public Word(string text)
    {
        _text = text;
    }

    public void Hide()
    {   
        _isHidden = true; //labels word as hidden
        foreach (char part in _text) //breaks down word into characters to then replace with _
        {
            _text = _text.Replace(part, '_');
        }
    }

    public void Show()
    {
        
    }

    public bool IsHidden()
    {
        if (_isHidden)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string GetDisplayText()
    {
        return _text;
    }
}