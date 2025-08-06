using System;

namespace pass_by_value_vs_pass_by_reference
{
    internal class Program


    {
        // Pass by Value (for value type)
        static void UpdateMarks(int marks)
        {
            marks += 10; // Changes copy, not original
            Console.WriteLine($"Inside UpdateMarks: marks = {marks}");
        }

        // Pass by Reference (ref)
        static void UpdateMarksRef(ref int marks)
        {
            marks += 10; // Changes original variable
            Console.WriteLine($"Inside UpdateMarksRef: marks = {marks}");
        }

        // Pass by Reference (out)
        static void CalculateGrade(int marks, out string grade)
        {
            grade = marks >= 60 ? "Pass" : "Fail"; // Must assign grade
            Console.WriteLine($"Inside CalculateGrade: grade = {grade}");
        }
        static void Main(string[] args)
        {
            // Pass by Value
            int studentMarks = 75;
            Console.WriteLine($"Before UpdateMarks: studentMarks = {studentMarks}");
            UpdateMarks(studentMarks);
            Console.WriteLine($"After UpdateMarks: studentMarks = {studentMarks}"); // Unchanged

            // Pass by Reference (ref)
            Console.WriteLine($"\nBefore UpdateMarksRef: studentMarks = {studentMarks}");
            UpdateMarksRef(ref studentMarks);
            Console.WriteLine($"After UpdateMarksRef: studentMarks = {studentMarks}"); // Changed

            // Pass by Reference (out)
            string studentGrade;
            CalculateGrade(studentMarks, out studentGrade);
            Console.WriteLine($"Final Grade: {studentGrade}");
        }
    }
}
