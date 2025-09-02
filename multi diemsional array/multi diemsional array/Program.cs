using System;

class Program
{
    static void Main()
    {
        // Declare a jagged array where each element is an array of marks
        int[][] marks = new int[3][];

        // Initialize each student's marks with different subject counts
        marks[0] = new int[] { 85, 90, 78 };       // Student 1 - 3 subjects
        marks[1] = new int[] { 88, 76, 92, 81 };   // Student 2 - 4 subjects
        marks[2] = new int[] { 95, 89 };           // Student 3 - 2 subjects

        // Display marks and calculate averages
        for (int i = 0; i < marks.Length; i++)
        {
            Console.WriteLine($"Student {i + 1} marks:");
            int total = 0;

            for (int j = 0; j < marks[i].Length; j++)
            {
                Console.WriteLine($"Subject {j + 1}: {marks[i][j]}");
                total += marks[i][j];
            }

            double average = (double)total / marks[i].Length;
            Console.WriteLine($"Average: {average:F2}\n");
        }
    }
}
