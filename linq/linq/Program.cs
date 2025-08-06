using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>() { 10, 20, 30, 40, 50 };

        // LINQ query to get numbers greater than 25
        var result = from n in numbers
                     where n > 25
                     select n;

        foreach (var num in result)
        {
            Console.WriteLine(num);
        }
    }
}
