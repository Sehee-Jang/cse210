using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Provo", "UT", "84604");
        Address address2 = new Address("4th Avenue", "Town", "UT", "12345");
        Address address3 = new Address("556 Main St", "Saltlake City", "UT", "81023");

        Event lecture = new Lecture("Rural Utah at a Crossroads", "An exploration of the tensions between the ideals and realities of life in rural Utah as change", "2024-06-04", "05:30", address1, "Greg Smoak", 200);
        Event reception = new Reception("Company Reception", "Annual commany meet and greet", "2024-06-30", "12:00", address2, "rsvp@company.com");
        Event outdoor = new Outdoor("Picnic in the park", "Join us for a fun picnic", "2024-06-10", "13:00", address3, "Sunny");

        Event[] events = { lecture, reception, outdoor };

        foreach (Event ev in events)
        {
            Console.WriteLine("<Standard Details>");
            Console.WriteLine(ev.getStandardDetails());
            Console.WriteLine();
            Console.WriteLine("<Full Details>");
            Console.WriteLine(ev.getFullDetails());
            Console.WriteLine();
            Console.WriteLine("<Short Description>");
            Console.WriteLine(ev.getShortDescription());
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------");
        }
    }
}