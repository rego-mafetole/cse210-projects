using System;

class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    private Random _random = new Random(); 

    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;
        
        foreach (string wordText in text.Split(' '))
        {
            _words.Add(new Word(wordText));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        int hiddenThisTurn = 0;
        while (hiddenThisTurn < numberToHide && !IsCompletelyHidden())
        {
            int index = _random.Next(_words.Count);
            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                hiddenThisTurn++;
            }
        }
    }

    
    public void RevealWords(int numberToReveal)
    {
        int revealedThisTurn = 0;
        while (revealedThisTurn < numberToReveal)
        {
            int index = _random.Next(_words.Count);
            if (_words[index].IsHidden())
            {
                _words[index].Show();
                revealedThisTurn++;
            }

            bool anyHidden = false;
            foreach (Word w in _words)
            {
                if (w.IsHidden()) anyHidden = true; 
            }
            if (!anyHidden) break;
        }
    }

    public string GetDisplayText()
    {
        string result = _reference.GetDisplayText() + " ";
        foreach (Word w in _words)
        {
            result += w.GetDisplayText() + " ";
        }
        return result.Trim();
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word w in _words)
        {
            if (!w.IsHidden()) 
                return false;
        }
        return true;
    }
}