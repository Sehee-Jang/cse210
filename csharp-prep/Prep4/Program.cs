using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int userNum = -1;
        while (userNum != 0)
        {
            Console.Write("Enter number(type 0 to quit): ");
            userNum = int.Parse(Console.ReadLine());

            // Add a number
            if (userNum != 0){
                numbers.Add(userNum);
            }
        }
        
        // // Print the list of numbers
        // foreach (int number in numbers)
        // {
        //     Console.WriteLine(number);
        // }

        // Sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}.");

        // Average
        float avg = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {avg}.");

        // Find the max
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                // if this number is greater than the max, it's the new max.
                max = number;
            }
        }
        Console.WriteLine($"The max is: {max}.");
    }
}