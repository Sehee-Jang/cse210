// Keeps track of the book, chapter, and verse information

public class Reference
{
    // Attributes
    public string _book;
    public int _chapter;
    public int _verse;
    public int _endVerse;

    // Constructors
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }

    public string GetDisplayText()
    {
        if (_endVerse != 0)
            return _book + " " + _chapter + ":" + _verse + "-" + _endVerse;
        else
        {
            return _book + " " + _chapter + ":" + _verse;
        }
    }

}
