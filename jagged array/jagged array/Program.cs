using System; // Imports core .NET namespace for Console and basic functionality

namespace JaggedArrayDemo // Organizes code in a namespace (like Java package)
{
    class Program // Defines the main class
    {
        static void Main(string[] args) // Entry point of the program
        {
            //// Declare a jagged array for 3 students
            //int[][] studentMarks = new int[3][]; // Main array with 3 sub-arrays

            //// Initialize sub-arrays with different lengths
            //studentMarks[0] = new int[2]; // Student 1: 2 test scores
            //studentMarks[1] = new int[4]; // Student 2: 4 test scores
            //studentMarks[2] = new int[1]; // Student 3: 1 test score

            //// Assign marks to sub-arrays
            //studentMarks[0][0] = 80; // Student 1, Test 1: 80
            //studentMarks[0][1] = 90; // Student 1, Test 2: 90
            //studentMarks[1][0] = 70; // Student 2, Test 1: 70
            //studentMarks[1][1] = 85; // Student 2, Test 2: 85
            //studentMarks[1][2] = 60; // Student 2, Test 3: 60
            //studentMarks[1][3] = 95; // Student 2, Test 4: 95
            //studentMarks[2][0] = 75; // Student 3, Test 1: 75

            //// Display the jagged array
            //Console.WriteLine("Student Marks:"); // Print header
            //for (int i = 0; i < studentMarks.Length; i++) // Loop through main array
            //{
            //    Console.Write($"Student {i + 1}: "); // Print student number
            //    for (int j = 0; j < studentMarks[i].Length; j++) // Loop through sub-array
            //    {
            //        Console.Write($"{studentMarks[i][j]} "); // Print each mark
            //    }
            //    Console.WriteLine(); // New line after each student
            //}


            /// sum of each row in jagged array -------------------------
            ///  int[][] studentMarks = new int[3][]; // Declare a jagged array with 3 rows

            // Initialize sub-arrays with different lengths

            int[][] studentMarks = new int[3][]; // Declare a jagged array with 3 rows

            studentMarks[0] = new int[] { 80, 90 }; // Student 1: 2 test scores
            studentMarks[1] = new int[] { 70, 85, 60, 95 }; // Student 2: 4 test scores
            studentMarks[2] = new int[] { 75 }; // Student 3: 1 test score

            // Display the jagged array and calculate row sums
            Console.WriteLine("Student Marks and Row Sums:"); // Print header
            for (int i = 0; i < studentMarks.Length; i++) // Loop through main array
            {
                int rowSum = 0; // Initialize sum for current row
                Console.Write($"Student {i + 1}: "); // Print student number
                for (int j = 0; j < studentMarks[i].Length; j++) // Loop through sub-array
                {
                    Console.Write($"{studentMarks[i][j]} "); // Print each mark
                    rowSum += studentMarks[i][j]; // Add mark to row sum
                }
                Console.WriteLine($"| Sum: {rowSum}"); // Print sum for the row
            }
        }
    }
}