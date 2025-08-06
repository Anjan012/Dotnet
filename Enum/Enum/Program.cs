using System;
namespace EnumExample
{
    enum Department
    {
        ComputerScience,
        Mathematics,
        Physics,
        Chemistry
    }
    enum College
    {
        Engineering,
        Arts,
        Science,
        Business
    }
    class Program
    {
        static void DisplayDepartments()
        {
            Console.WriteLine("Departments:");
            foreach (var dept in Enum.GetValues(typeof(Department)))
            { Console.WriteLine(dept); }
        }
        static void DisplayColleges()
        {
            Console.WriteLine("Colleges:");
            foreach (var college in Enum.GetValues(typeof(College)))
            { Console.WriteLine(college); }
        }
        static void Main(string[] args)
        {
            DisplayDepartments();
            DisplayColleges();
        }
    }
}
