class Scripture
{
    private List<Word> _words;
    private Reference _reference;
    private Random _random = new Random();

    public Scripture(string text, string book, int chapter, int verse)
    {
        _reference = new Reference(book, chapter, verse);
        _words = new List<Word>();

        string[] _splitWords = text.Split(' ');

        foreach (string part in _splitWords)
        {
            Word word = new Word(part);
            _words.Add(word);
        }
    }

    public Scripture(string text, string book, int chapter, int verse1, int verse2)
    {
        _reference = new Reference(book, chapter, verse1, verse2);
        _words = new List<Word>();

        string[] _splitWords = text.Split(' ');

        foreach (string part in _splitWords)
        {
            Word word = new Word(part);
            _words.Add(word);
        }
    }

    public void DisplayScripture()
    {
        Console.Write(_reference.ToString());
        foreach (Word word in _words)
        {
            Console.Write(word.Display() + " ");
        }
        Console.WriteLine();
    }

    public bool AllWordsHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.CheckHidden())
            {
                return false; 
            }
        }

        return true; 
    }

    public void HideWords(int num)
    {
        int wordsHidden = 0;

        while (wordsHidden < num)
        {
            int index = _random.Next(_words.Count);
            if (!_words[index].CheckHidden())
            {
                _words[index].Hide();
                wordsHidden++;
            }

            if (AllWordsHidden()) 
            {
                break;
            }
        }
    }
}