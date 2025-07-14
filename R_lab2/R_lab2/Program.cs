using System;
using System.Collections.Generic;
using System.Linq;

namespace R_lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Step 1: Create list of numbers from 1 to 30
            //Enumerable.Range(1, 30) → generates numbers from 1 to 30(inclusive).
            //.ToList() → converts it into a List<int>.

            List<int> numbers = Enumerable.Range(1, 30).ToList(); // now you have the numbers = [1,2,3,4,......,30]

            // Step 2: LINQ query to get numbers that are odd and divisible by 3
            // This is a LINQ Query Expression, and it works like SQL. from num in numbers → go through each number in the list. % 2 != 0 → remainder is not zero → it's odd. num % 3 == 0 → divisible by 3. select num → select those numbers that pass the conditions.
            var result = from num in numbers
                         where num % 2 != 0 && num % 3 == 0
                         select num;

            // Step 3: Display result
            Console.WriteLine("Numbers from 1 to 30 that are ODD and divisible by 3:");
            foreach (int n in result)
            {
                Console.Write(n + " ");
            }
        }
    }
}
