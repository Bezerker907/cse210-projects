public class Scripture
{
    private References _references;
    private List<Word> _words = new List<Word>();

    public Scripture(References References, string text)
    {
        _references = References;
        foreach (string word in text.Split(" "))
        {
            Word newWord = new Word(word);
            _words.Add(newWord);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        int i = 0; //hidden word counter

        while (i < numberToHide)
        {
            Random rand = new Random();
            int index = rand.Next(0, _words.Count);
            
            while (_words[index].IsHidden()) //is word hidden already? TRY AGAIN PUNK
            {
                index = rand.Next(0, _words.Count);

                if (IsCompletelyHidden()) //prevents infinite looping
                {
                    return;
                }
            }

            Word randomWord = _words[index];

            randomWord.Hide();
            i++;
        }
    }

    public string GetDisplayText() //what people see
    {
        string display = _references.GetReferenceText(); //gets the reference

        foreach (Word text in _words)
        {
            string newText = text.GetDisplayText() + " "; //combines the scripture verse with the reference
            display += newText;
        }

        return display;
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word text in _words) //checks if every word is hidden
        {
            if (!(text.IsHidden())) //is any word NOT hidden???
            {
                return false; //cool, move on.
            }
        }
        return true; //above method finished, therefore all text is hidden.
    }
}