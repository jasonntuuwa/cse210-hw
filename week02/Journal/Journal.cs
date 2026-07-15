using System;
using System.Collections.Generic;
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
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                string date = EscapeCsvField(entry._date);
                string prompt = EscapeCsvField(entry._promptText);
                string text = EscapeCsvField(entry._entryText);

                outputFile.WriteLine($"{date},{prompt},{text}");
            }
        }
    }

    private string EscapeCsvField(string field)
    {
        if (field.Contains(",") || field.Contains("\"") || field.Contains("\n"))
        {
            field = field.Replace("\"", "\"\"");
            field = $"\"{field}\"";
        }
        return field;
    }

    public void LoadFromFile(string file)
    {
        _entries.Clear();

        string[] lines = File.ReadAllLines(file);
        foreach (string line in lines)
        {
            List<string> fields = ParseCsvLine(line);

            Entry newEntry = new Entry();
            newEntry._date = fields[0];
            newEntry._promptText = fields[1];
            newEntry._entryText = fields[2];

            _entries.Add(newEntry);
        }
    }

    private List<string> ParseCsvLine(string line)
    {
        List<string> fields = new List<string>();
        string currentField = "";
        bool inQuotes = false;

        for (int i = 0; i < line.Length; i++)
        {
            char c = line[i];

            if (inQuotes)
            {
                if (c == '"')
                {
                    if (i + 1 < line.Length && line[i + 1] == '"')
                    {
                        currentField += '"';
                        i++;
                    }
                    else
                    {
                        inQuotes = false;
                    }
                }
                else
                {
                    currentField += c;
                }
            }
            else
            {
                if (c == '"')
                {
                    inQuotes = true;
                }
                else if (c == ',')
                {
                    fields.Add(currentField);
                    currentField = "";
                }
                else
                {
                    currentField += c;
                }
            }
        }

        fields.Add(currentField);
        return fields;
    }
}