using System;


namespace exception_handling_example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter student name:");
                string name = Console.ReadLine();

                Console.WriteLine("Enter marks (0-100):");
                string input = Console.ReadLine();

                // Try to convert input to a number
                int marks = Convert.ToInt32(input);

                // Check if marks are valid
                if (marks < 0 || marks > 100)
                {
                    throw new ArgumentException("Marks must be between 0 and 100.");
                }

                // Calculate grade
                string grade = marks >= 60 ? "Pass" : "Fail";
                Console.WriteLine($"{name}'s Grade: {grade}");
            }
            catch (FormatException)
            {
                // Handles non-numeric input
                Console.WriteLine("Error: Please enter a valid number for marks.");
            }
            catch (ArgumentException ex)
            {
                // Handles invalid range
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                // Catches any other unexpected errors
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }
            finally
            {
                // Always runs, e.g., to clean up resources
                Console.WriteLine("Calculation completed.");
            }
        }
    }
}
