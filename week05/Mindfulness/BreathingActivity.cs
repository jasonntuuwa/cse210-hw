using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine();
            Console.Write("Breathe in...");
            AnimateBreath(grow: true, seconds: 4);

            Console.WriteLine();
            Console.Write("Breathe out...");
            AnimateBreath(grow: false, seconds: 4);
        }

        DisplayEndingMessage();
    }

    private void AnimateBreath(bool grow, int seconds)
    {
        int maxWidth = 10;
        int steps = seconds * 2;

        for (int i = 0; i <= steps; i++)
        {
            int width = grow
                ? (int)((double)i / steps * maxWidth)
                : maxWidth - (int)((double)i / steps * maxWidth);

            string bar = new string('o', width);
            Console.Write("\r" + bar.PadRight(maxWidth));
            Thread.Sleep(500);
        }

        Console.Write("\r" + new string(' ', maxWidth) + "\r");
    }
}