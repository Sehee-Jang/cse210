using System;

class Program
{
    static void Main(string[] args)
    {
        // Test the Square class
        Square square = new Square("red", 5);
        Console.WriteLine($"Color: {square.GetColor()}");
        Console.WriteLine($"Area: {square.GetArea()}");
        Console.WriteLine();

        // Test the Rectangle class
        Rectangle rectangle = new Rectangle("yellow", 5, 4);
        Console.WriteLine($"Color: {rectangle.GetColor()}");
        Console.WriteLine($"Area: {rectangle.GetArea()}");
        Console.WriteLine();

        // Test the Circle class
        Circle circle = new Circle("blue", 5);
        Console.WriteLine($"Color: {circle.GetColor()}");
        Console.WriteLine($"Area: {circle.GetArea()}");
        Console.WriteLine();

        // Create a list to hold shapes
        List<Shape> shapes = new List<Shape>();

        // Add a square, rectangle, and circle to this list
        Square s1 = new Square("purple", 6);
        shapes.Add(s1);

        Rectangle s2 = new Rectangle("green", 2, 3);
        shapes.Add(s2);

        Circle s3 = new Circle("white", 2);
        shapes.Add(s3);

        // Iterate through the list of shapes. For each one, call and display the GetColor() and GetArea() methods.
        foreach (Shape s in shapes)
        {
            string color = s.GetColor();

            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}