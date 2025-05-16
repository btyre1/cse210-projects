using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void PrintJournal()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine(entry.CreateEntry());
        }
    }

    public void Save(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine($"{entry._title}|{entry._date}|{entry._prompt}|{entry._text}");
            }
        }
    }

    public void Load(string fileName)
    {
        _entries.Clear();

        if (File.Exists(fileName))
        {
            string[] lines = File.ReadAllLines(fileName);

            foreach (string line in lines)
            {
                string[] parts = line.Split("|");

                Entry entry = new Entry();
                entry._title = parts[0];
                entry._date = parts[1];
                entry._prompt = parts[2];
                entry._text = parts[3];
                _entries.Add(entry);
            }
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}