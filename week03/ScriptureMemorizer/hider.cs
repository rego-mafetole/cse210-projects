using System;

namespace ScriptureMemorizer
{
    public class Hider
    {
        private string _text;
        private bool _isHidden;

        public Hider(string text)
        {
            _text = text;
            _isHidden = false;
        }

        public void Hide() => _isHidden = true;
        public void Show() => _isHidden = false;
        public bool IsHidden() => _isHidden;

        public string GetDisplayText()
        {
            return _isHidden ? "_____" : _text;
        }
    }
}