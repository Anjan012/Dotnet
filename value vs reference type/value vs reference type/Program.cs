using System;

namespace value_vs_reference_type
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Value Type
            int a = 10; // Stored on stack
            int b = a;  // Copies value
            b = 20;     // Doesn't affect a
            Console.WriteLine($"Value Type: a = {a}, b = {b}"); // Output: a = 10, b = 20

            // Reference Type
            string[] arr1 = { "Ram" }; // Stored on heap, arr1 is a reference
            string[] arr2 = arr1;      // Copies reference, not data
            arr2[0] = "Shyam";         // Changes affect arr1 too
            Console.WriteLine($"Reference Type: arr1[0] = {arr1[0]}, arr2[0] = {arr2[0]}"); // Output: arr1[0] = Shyam, arr2[0] = Shyam
        }
    }
}
