using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Provo", "UT", "84604");
        Address address2 = new Address("95 N 300 W", "Salt Lake City", "UT", "84101");
        Address address3 = new Address("50 S University Ave", "Provo", "UT", "84601");

        Event lecture = new Lecture("Rural Utah at a Crossroads", "An exploration of the tensions between the ideals and realities of life in rural Utah as change", "2024-06-04", "05:30", address1, "Greg Smoak", 200);
        Event reception = new Reception("Company Reception", "Annual commany meet and greet", "2024-06-30", "12:00", address2, "rsvp@company.com");
        Event outdoor = new Outdoor("Picnic in the park", "Join us for a fun picnic", "2024-06-10", "13:00", address3, "Sunny");

        Event[] events = { lecture, reception, outdoor };

        foreach (Event ev in events)
        {
            Console.WriteLine("<Standard Details>");
            Console.WriteLine(ev.GetStandardDetails());
            Console.WriteLine();
            Console.WriteLine("<Full Details>");
            Console.WriteLine(ev.GetFullDetails());
            Console.WriteLine();
            Console.WriteLine("<Short Description>");
            Console.WriteLine(ev.GetShortDescription());
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------");
        }
    }
}