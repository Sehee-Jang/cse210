
public class Person
{
    private string _title;
    private string _firstName;
    private string _lastName;

    // Constructors
    public Person()
    {
        _title = "";
        _firstName = "Anonymous";
        _lastName = "Unknown";
    }
    public Person(string first, string last)
    {
        _title = "";
        _firstName = first;
        _lastName = last;
    }
    public Person(string title, string first, string last)
    {
        _title = title;
        _firstName = first;
        _lastName = last;
    }
    // Getters and Setters
    public string GetFirstName()
    {
        return _firstName;
    }
    public void SetFirstName(string firstName)
    {
        _firstName = firstName;
    }
    public string GetLastName()
    {
        return _lastName;
    }
    public void SetLastName(string lastName)
    {
        _lastName = lastName;
    }

    // Methods
    public string GetInformalSignature()
    {
        return "Thanks, " + _firstName;
    }

    public string GetFormalSignature()
    {
        return "Sincerely, " + GetFullName();
    }

    private string GetFullName()
    {
        return _title + " " + _firstName + " " + _lastName;
    }
}