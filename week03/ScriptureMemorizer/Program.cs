// Creativity: added a small library of scriptures.
// One is chosen at random each time the program runs, rather than
// always displaying the same scripture.

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        
        Random random = new Random();

        List<Reference> references = new List<Reference>
        {
            new Reference("Ether", 12, 27),
            new Reference("Mosiah", 2, 17),
            new Reference("Doctrine and Covenants", 82, 10)
        };

        List<string> texts = new List<string>
        {
            "And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble, and my grace is sufficient for all men that humble themselves before me; for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them.",
            "And behold, I tell you these things that ye may learn wisdom; that ye may learn that when ye are in the service of your fellow beings ye are only in the service of your God.",
            "I, the Lord, am bound when ye do what I say; but when ye do not what I say, ye have no promise."
        };

        int index = random.Next(references.Count);
        Reference reference = references[index];
        Scripture scripture = new Scripture(reference, texts[index]);

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress enter to continue or type 'quit' to end.");

            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords();

            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                break;
            }
        }
    }
}