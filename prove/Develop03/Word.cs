// Keeps track of a single word and whether it is shown or hidden

public class Word
{
    // Attributes
    public string _text;
    public bool _isHidden;
    
    // Constructors
    public Word(string text)
    {
        _text = text;
    }

    // Methods
    public void Hide()
    {
        _isHidden = true;
    }
    public void Show()
    {
        _isHidden = false;
    }
    public bool isHidden()
    {
        return _isHidden;
    }
    public string GetDisplayText()
    {
        if (_isHidden)
        {
            return "_____";
        }
        else
        {
            return _text;
        }
    }

    // Getters and Setters
    
}