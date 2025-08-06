using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace lamda_expression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lambda expression: A Lambda Expression is a shorter way to write anonymous methods (methods without a name). It’s used mostly when you want to pass behavior (a function) as data. 
            // Func<int, int>: This means a function that takes int input and returns int.
            Func<int, int> square = x => x * x;

            Console.WriteLine(square(5));  // Output: 25



            //with list and filtering
            List<int> numbers = new List<int> { 1, 5, 8, 2, 10, 3 };

            // Find even numbers using lambda
            var evenNumbers = numbers.Where(n => n % 2 == 0);

            foreach (var n in evenNumbers)
            {
                Console.WriteLine(n);
            }
        }
    }
}
