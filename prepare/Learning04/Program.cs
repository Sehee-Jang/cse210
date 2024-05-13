using System;
using System.Data.Common;

class Program
{
    static void Main(string[] args)
    {
        Assignment ast = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(ast.GetSummary());
        Console.WriteLine();

        MathAssignment mast = new MathAssignment("Roberto Rodriquez", "Fractions", "7.3", "9-19");
        Console.WriteLine(mast.GetSummary());
        Console.WriteLine(mast.GetHomeworkList());
        Console.WriteLine();

        WritingAssignment wast = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(wast.GetSummary());
        Console.WriteLine(wast.GetWritingInformation());
    }
}