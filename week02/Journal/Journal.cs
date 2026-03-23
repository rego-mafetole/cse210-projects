using System;
public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void AddEntry(string prompt, string response)
    {
        Entry entry = new Entry(prompt, response);
        _entries.Add(entry);
    }

    public void Display()
    {
        foreach (var entry in _entries)
        {
            Console.WriteLine(entry.GetDisplayText());
        }
    }

    public void Save(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine(entry.GetFileString());
            }
        }
    }

    public void SearchEntriesByDate()
    {
        Console.Write("Enter date to search (YYYY-MM-DD): ");
        if (DateTime.TryParse(Console.ReadLine(), out DateTime searchDate))
        {
            List<Entry> results = _entries.FindAll(entry => DateTime.Parse(entry.Date).Date == searchDate.Date);
            if (results.Count > 0)
            {
                foreach (Entry entry in results)
                {
                    Console.WriteLine(entry.GetDisplayText());
                }
            }
            else
            {
                Console.WriteLine("No entries found for that date.");
            }
        }
        else
        {
            Console.WriteLine("Invalid date format.");
        }
    }

    public void Load(string filename)
    {
        _entries.Clear();
        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            if (parts.Length == 3)
            {
                string date = parts[0];
                string prompt = parts[1];
                string response = parts[2];
                Entry entry = new Entry(prompt, response);
                entry.Date = date;
                _entries.Add(entry);
            }
        }
    }
}
