using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    internal class Program
    {
        // Struct Example
        struct Student
        {
            public string Name;
            public int RollNo;
            public double Marks;

            public string GetGrade()
            {
                return Marks >= 60 ? "Pass" : "Fail";
            }
        }

        // Enum Example
        enum ExamStatus
        {
            Pass = 1,
            Fail = 0,
            Absent = -1
        }
        static void Main(string[] args)
        {
            // Using Struct
            Student student = new Student { Name = "Ram", RollNo = 101, Marks = 75 };
            Console.WriteLine($"{student.Name} - Grade: {student.GetGrade()}");

            // Using Enum
            ExamStatus status = ExamStatus.Pass;
            Console.WriteLine($"Status: {status} (Value: {(int)status})");
        }
    }
}
