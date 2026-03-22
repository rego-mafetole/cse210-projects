using System;

namespace ScriptureMemorizer
{
    public class Scripture
    {
        private Reference _reference;
        private List<Hider> _words;

        public Scripture(Reference reference, string text)
        {
            _reference = reference;
            _words = new List<Hider>();

            foreach (string word in text.Split(' '))
            {
                _words.Add(new Hider(word));
            }
        }

        public void HideRandomWords(int numberToHide)
        {
            Random rand = new Random();
            for (int i = 0; i < numberToHide; i++)
            {
                int index = rand.Next(_words.Count);
                _words[index].Hide();
            }
        }

        public void RevealWord(int index)
        {
            if (index >= 0 && index < _words.Count)
            {
                _words[index].Show();
            }
        }

        public string GetDisplayText()
        {
            string wordsText = string.Join(" ", _words.ConvertAll(w => w.GetDisplayText()));
            return $"{_reference.GetDisplayText()}: {wordsText}";
        }

        public bool IsCompletelyHidden()
        {
            foreach (var word in _words)
            {
                if (!word.IsHidden()) return false;
            }
            return true;
        }
    }
}
