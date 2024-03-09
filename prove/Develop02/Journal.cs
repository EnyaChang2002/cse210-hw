using System;
using System.ComponentModel;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        Console.WriteLine(_entries);
    }
    public void SaveToFiles(string file)
    {
        using (StreamWriter output1 = new StreamWriter(file))
            {
                output1.WriteLine(_entries);
            }
    }
    public void LoadFromFiles(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);
        Entry newE = new Entry();
        foreach (string line in lines)
        {
            newE._entryText = line;
        }
        _entries.Add(newE);
    }
}