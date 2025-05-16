public class Entry
{
    public string _prompt;
    public string _text;
    public string _date;
    public string _title;

    public string CreateEntry()
    {
        return $"Title: {_title}\nDate: {_date} - Prompt: {_prompt}\n{_text}\n";
    }
}