// Keeps track of both the reference and the text of the scripture. Can hide words and get the rendered display of the text

public class Scripture
{
    // Attributes
    public Reference _reference;
    public List<Word> _words;

    // Constructor
    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;

        // Split the text into words
        _words = new List<Word>();
        string[] wordArray = text.Split(' ');
        foreach (string word in wordArray)
        {
            _words.Add(new Word(word));
        }
    } 

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        List<int> indices = Enumerable.Range(0, _words.Count).OrderBy(x => random.Next()).Take(numberToHide).ToList();
        foreach (int index in indices)
        {
            _words[index].Hide();
        }
    }

    // Methods
    public string GetDisplayText()
    {
        string displayText = $"{_reference.GetDisplayText()} ";
        foreach (Word word in _words)
        {
            displayText += word.GetDisplayText() + " ";
        }
        return displayText.Trim();
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.isHidden())
            {
                return false;
            }
        }
        return true;
    }
}