using System.Drawing;

public class Shape
{
    // Attributes
    private string _color;

    // Constructor
    public Shape(string color)
    {
        _color = color;
    }

    // Getter & Setter
    public string GetColor()
    {
        return _color;
    }
    public void SetColor(string color)
    {
        _color = color;
    }

    public virtual double GetArea()
    {
        return 0;
    }

}