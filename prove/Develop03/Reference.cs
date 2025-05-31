class Reference
{
    // private string _reference = "Moroni 7:45";
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int? _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = verse;
        _endVerse = null;
    }
    public Reference(string book, int chapter, int verse1, int verse2)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = verse1;
        _endVerse = verse2;
    }

    public override string ToString()
    {
        if (_endVerse.HasValue)
        {
            return $"{_book} {_chapter}:{_startVerse}-{_endVerse.Value} ";
        }
        else
        {
            return $"{_book} {_chapter}:{_startVerse} ";
        }
    }
}