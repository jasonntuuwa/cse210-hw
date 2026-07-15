// To exceed requirements, the journal is saved and loaded using proper CSV formatting,
// including correctly handling fields that contain commas and double quotes.

using System;

Journal journal = new Journal();
PromptGenerator promptGenerator = new PromptGenerator();

bool quit = false;

while (!quit)
{
    Console.WriteLine("Please select one of the following choices:");
    Console.WriteLine("1. Write");
    Console.WriteLine("2. Display");
    Console.WriteLine("3. Save");
    Console.WriteLine("4. Load");
    Console.WriteLine("5. Quit");
    Console.Write("> ");

    string choice = Console.ReadLine();

    if (choice == "1")
    {
        string prompt = promptGenerator.GetRandomPrompt();
        Console.WriteLine(prompt);
        Console.Write("> ");
        string response = Console.ReadLine();

        Entry newEntry = new Entry();
        newEntry._date = DateTime.Now.ToShortDateString();
        newEntry._promptText = prompt;
        newEntry._entryText = response;

        journal.AddEntry(newEntry);
    }
    else if (choice == "2")
    {
        journal.DisplayAll();
    }
    else if (choice == "3")
    {
        Console.Write("Filename: ");
        string filename = Console.ReadLine();
        journal.SaveToFile(filename);
    }
    else if (choice == "4")
    {
        Console.Write("Filename: ");
        string filename = Console.ReadLine();
        journal.LoadFromFile(filename);
    }
    else if (choice == "5")
    {
        quit = true;
    }
    else
    {
        Console.WriteLine("Invalid choice, please try again.");
    }
}