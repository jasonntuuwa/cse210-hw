using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        //Ask user for their grade percentage and convert it to a number
        Console.Write("What is your grade percentage? ");
        string input = Console.ReadLine();
        int grade = int.Parse(input);

        //Print letter grade
        string letter;

        if (grade>=90)
        {
            letter = "A";
        }
        else if (grade>= 80)
        {
            letter = "B";
        }
        else if (grade>=70)
        {
            letter = "C";
        }
        else if (grade>=60)
        {
            letter = "D";
        }
        else
        {letter="F";
        }
        Console.WriteLine(letter);

        if (grade>=70)
        {
            Console.WriteLine("Congratulations, youu passed the course!");
        }
        else
        {
            Console.WriteLine("Keep working hard, you'll get there next time.");
        }
        



        

    }
}