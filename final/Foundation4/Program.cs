using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running("01 Jun 2024", 60, 10.0f),
            new Cycling("11 Nov 2023", 120, 12.0f),
            new Swimming("02 Jan 2024", 40, 20)
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}