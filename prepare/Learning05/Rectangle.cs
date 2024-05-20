public class Rectangle : Shape
{
    // Attributes
    private double _length;
    private double _width;

    // Constructor
    public Rectangle(string color, double length, double width) : base(color)
    {
        _length = length;
        _width = width;
    }

    // Method

    public override double GetArea()
    {
        return _width * _length;
    }
}