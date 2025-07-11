class Video
{
    private string _title;
    private string _author;
    private int _lengthInSeconds;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int lengthInSeconds)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = lengthInSeconds;
    }
    public int GetCommentCount()
    {
        int count = _comments.Count;
        return count;
    }
    public void AddComment(string user, string text)
    {
        Comment c = new Comment(user, text);
        _comments.Add(c);
    }
    public void DisplayInfo()
    {
        int i = 0;
        Console.WriteLine($"\nVideo: '{_title}' by {_author}, Length - {_lengthInSeconds} seconds, {GetCommentCount()} Comments\n");
        foreach (Comment c in _comments)
        {
            i++;
            Console.Write($"{i}. User: {c.GetUser()} said '{c.GetText()}'\n");
        }
    }
}