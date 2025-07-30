using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myfourthoprogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List ------------------------------------------

            // Since array is fixed size, we use List to create a dynamic array, you can add, remove and modify elements

            //List<int> listNumbers = new List<int>()
            //{
            //    1, 2, 3, 4, 5, 6, 7, 8, 9, 10
            //};
            //listNumbers.Add(1);
            //listNumbers.Add(2);
            //listNumbers.Add(3);

            //List<int> listNumbers = new List<int>();


            //for (int i = 0; i < 3; i++)
            //{
            //    Console.Write("Enter a number");
            //    listNumbers.Add(Convert.ToInt32(Console.ReadLine()));
            //    //int num = Convert.ToInt32(Console.ReadLine());

            //    //listNumbers.Add(num);
            //}

            //listNumbers.RemoveAt(0); // Remove first element

            ////List have count
            //for (int i = 0; i < listNumbers.Count; i++)
            //{
            //    Console.WriteLine(listNumbers[i]);
            //}


            //foreach (int number in listNumbers)
            //{
            //    Console.WriteLine(number);
            //}

            //Dictionary ------------------------------------------

            //Dictionary is a general-purpose collection of key-value pairs in no particular order. The key and the value can be of any data type. It comes under System.Collections.Generic namespace.

            // keys must be unique and not null, values can be duplicated or null

            //Dictionary<int, string> names = new Dictionary<int, string>()
            //{
            //    // keyvalue pairs
            //    { 1, "John" },
            //    { 2, "Jane" },
            //    { 3, "Doe" }
            //};

            //names.Add(4, "Alice");

            //for (int i = 0; i < names.Count; i++)
            //{
            //    // Accessing value by key
            //    //Console.WriteLine($"Key: {i + 1}, Value: {names[i + 1]}");

            //    KeyValuePair<int, string> pair = names.ElementAt(i); // Get the KeyValuePair at index i returns key value pair in 
            //    Console.WriteLine($"{pair.Key} - {pair.Value}");
            //}
            //Console.WriteLine();

            //foreach (KeyValuePair<int, string> pair in names)
            //{
            //    Console.WriteLine($"{pair.Key} - {pair.Value}");
            //}

            Dictionary<string, string> countries = new Dictionary<string, string>()
            {
                { "US", "United States" },
                { "CA", "Canada" },
                { "MX", "Mexico" }
            };

            //Console.WriteLine(countries["US"]);

            if()


        }
    }
}
