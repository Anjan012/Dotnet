using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enum_p1
{
    internal class Program
    {
    
        enum DaysOfWeek
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }

        static void CheckDay(DaysOfWeek day)
        {
            if (day == DaysOfWeek.Saturday || day == DaysOfWeek.Sunday)
            {
                Console.WriteLine($"{day} is a Weekend.");
            }
            else
            {
                Console.WriteLine($"{day} is a Weekday.");
            }
        }

        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter a day (e.g., Monday, Tuesday, ...):");
            string input = Console.ReadLine();

            if (Enum.TryParse(input, true, out DaysOfWeek day))
            {
                CheckDay(day);
            }
            else
            {
                Console.WriteLine("Invalid day entered.");
            }
        }
    }
}

