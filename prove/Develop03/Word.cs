class Word
{
    private string _word;
    private bool _isHidden;

    public Word(string text)
    {
        _word = text;
        _isHidden = false;
    }

    public string Display()
    {
        if (_isHidden)
        {
            return new string('_', _word.Length);
        }
        else
        {
            return _word;
        }
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public bool CheckHidden()
    {
        return _isHidden;
    }
}