// Enhancement: The Breathing Activity uses a custom growing/shrinking
// text animation (instead of a plain countdown) to visually represent
// breathing in and out, making the experience more immersive.
using System;

class Program
{
    static void Main(string[] args)
    {
        

        bool quit = false;

        while (!quit)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start Breathing Activity");
            Console.WriteLine("  2. Start Reflecting Activity");
            Console.WriteLine("  3. Start Listing Activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.Run();
                    break;

                case "2":
                    ReflectingActivity reflecting = new ReflectingActivity();
                    reflecting.Run();
                    break;

                case "3":
                    ListingActivity listing = new ListingActivity();
                    listing.Run();
                    break;

                case "4":
                    quit = true;
                    break;

                default:
                    Console.WriteLine("Invalid choice. Press enter to try again.");
                    Console.ReadLine();
                    break;
            }
        }
    }
}