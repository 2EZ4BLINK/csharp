using System;

namespace MasteringCSharp;

public class StructAndDateTime
{
        DateTime datetime = new DateTime(2026, 7, 2);
        DateTime now = DateTime.Now;

    public void GetTime()
    {
        Console.WriteLine($"{now.Hour} o'clock and {now.Minute} minutes and {now.Second} seconds");
    }

    public void GetTimeWithFormat()
    {
        Console.WriteLine("Write a date in this format: yyyy-mm-dd");
        string input = Console.ReadLine();
        if(DateTime.TryParse(input, out datetime))
        {
            Console.WriteLine(datetime);
            TimeSpan dayPassed = now.Subtract(datetime);
            Console.WriteLine($"Days passed since: {dayPassed.Days}");
        } else
        {
            Console.WriteLine("Wrong type of input");
        }
    }
    
}
