using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a list of numbers from 1 to 30
        List<int> numbers = Enumerable.Range(1, 30).ToList();

        // Use LINQ query to select numbers that are odd and divisible by 3
        var result = from num in numbers
                     where num % 2 != 0 && num % 3 == 0
                     select num;

        // Display the result
        Console.WriteLine("Numbers from 1 to 30 that are odd and divisible by 3:");
        foreach (var number in result)
        {
            Console.Write(number + " ");
        }
    }
}
