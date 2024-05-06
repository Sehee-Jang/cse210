using System;

class programPerson
{
    static void Main(string[] args)
    {
        Person p = new Person();
        p.SetFirstName("Peter");
        Console.WriteLine(p.GetFirstName());
        Person p1 = new Person(); // Don't pass any information to get the default values
        Person p2 = new Person("Sehee", "Jang"); // pass the first and last names
        Person p3 = new Person("Mrs.", "Sehee", "Jang"); // pass all three variables

    }
}
