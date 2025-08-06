using System;
using System.Collections;

namespace boxing_vs_unboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Boxing: Converting value type (int) to reference type (object)
            int marks = 85; // Value type (stack)
            object boxedMarks = marks; // Boxing: wraps int into object (heap)
            Console.WriteLine($"Boxed: marks = {marks}, boxedMarks = {boxedMarks}");
            

            // Using ArrayList (requires boxing for value types)
            ArrayList studentMarks = new ArrayList();
            studentMarks.Add(marks); // Boxing: int to object
            studentMarks.Add(90);    // Boxing: int to object
            Console.WriteLine($"ArrayList: {studentMarks[0]}, {studentMarks[1]}");

            // Unboxing: Converting object back to int
            try
            {
                int unboxedMarks = (int)boxedMarks; // Unboxing: object to int
                Console.WriteLine($"Unboxed: unboxedMarks = {unboxedMarks}");

                // Unboxing from ArrayList
                int firstMark = (int)studentMarks[0]; // Unboxing
                Console.WriteLine($"Unboxed from ArrayList: firstMark = {firstMark}");

                // Incorrect unboxing (will throw exception)
                string wrongUnbox = (string)boxedMarks; // Causes InvalidCastException
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
