using System.Runtime.CompilerServices;

public class Assignment
{
    // Attributes
    private string _studentName;
    private string _topic;

    // Constructor
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // Getters & Setters
    public string GetStudentName()
    {
        return _studentName;
    }
    public string GetTopic()
    {
        return _topic;
    }

    // Method
    public string GetSummary()
    {
        return _studentName + " - " + _topic;
    }
}