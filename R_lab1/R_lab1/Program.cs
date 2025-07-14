//Lab 1: Write a C# program to create multidimensional array to store the marks of three student in different subjects. First student has marks of 3 subjects, second student has marks of 4 subjects and Third student has marks of 2 subjects, Display the subject marks and average marks for each student

using System;

namespace R_lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // Declare a jagged array: array of arrays
            int[][] studentMarks = new int[3][];

            // Initialize with different subject counts
            studentMarks[0] = new int[3]; // Student 1 - 3 subjects
            studentMarks[1] = new int[4]; // Student 2 - 4 subjects
            studentMarks[2] = new int[2]; // Student 3 - 2 subjects

            Console.WriteLine("Enter marks for each student:");

            // Take input for each student's subjects
            for (int i = 0; i < studentMarks.Length; i++)
            {
                Console.WriteLine($"\nStudent {i + 1}:");

                // Getting the input for subjects 
                for (int j = 0; j < studentMarks[i].Length; j++)
                {
                    Console.Write($"Enter mark for Subject {j + 1}: ");
                    studentMarks[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("\n--- Student Marks and Averages ---\n");

            // Display each student's marks and average
            for (int i = 0; i < studentMarks.Length; i++)
            {
                Console.WriteLine($"Student {i + 1} Marks:");
                int sum = 0;

                for (int j = 0; j < studentMarks[i].Length; j++)
                {
                    Console.WriteLine($"\tSubject {j + 1}: {studentMarks[i][j]}"); // i initial is 0 means the initial student and j is the index of subject for marks
                    sum += studentMarks[i][j];
                }

                double average = (double)sum / studentMarks[i].Length; //(double)sum: type casting to make sure that the division gives a decimal result studentMarks[i].Length: this give us the total subject the i'th student is having 
                Console.WriteLine($"\tAverage Marks: {average:F2}\n"); // up to 2 decimal places 
            }
        }
    }
}
