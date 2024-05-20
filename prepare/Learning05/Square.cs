using System.Reflection.Metadata.Ecma335;

public class Square : Shape
{
    // Attribute
    private double _side;

    // Constructor
    public Square(string color, double side) : base(color)
    {
        _side = side;
    }


    // Method
    public override double GetArea()
    {
        return _side * _side;
    }


}