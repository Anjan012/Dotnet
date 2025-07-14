using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_driven
{

    //Write a C# program which stores values in two enumerations, Department and college it contain two functions to display the data contained in department and college enumerations. 
    enum Department
    {
        ComputerScience,
        InformationTechnology,
        Electronics,
        CivilEngineering,
        Mechanical
    }

    // Define another enumeration for colleges
    enum College
    {
        ScienceAndTechnology,
        Humanities,
        Management,
        Education
    }

    class Program
    {
        // Function to display departments
        // Optional parameter controls whether to show count
        static void DisplayDepartments(bool showCount = false)
        {
            Console.WriteLine("List of Departments:");
            int count = 0;

            // Loop through all values in the Department enum
            foreach (Department dept in Enum.GetValues(typeof(Department)))
            {
                Console.WriteLine("- " + dept);
                count++;
            }

            // If optional parameter is true, show the count
            if (showCount)
            {
                Console.WriteLine("Total Departments: " + count);
            }

            Console.WriteLine(); // Line break for better readability
        }

        // Function to display colleges
        // Optional parameter with default value
        static void DisplayColleges(bool showCount = false)
        {
            Console.WriteLine("List of Colleges:");
            int count = 0;

            // Loop through all values in the College enum
            foreach (College college in Enum.GetValues(typeof(College)))
            {
                Console.WriteLine("- " + college);
                count++;
            }

            // Display count if optional parameter is true
            if (showCount)
            {
                Console.WriteLine("Total Colleges: " + count);
            }

            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            // Call function without passing optional parameter
            // This will use default (false)
            DisplayDepartments();

            // Call function and pass true to optional parameter
            // Now it will also show the count of items
            DisplayColleges(true);

            // You can experiment by reversing the above
            // or calling both with and without the parameter
        }
    }
}
