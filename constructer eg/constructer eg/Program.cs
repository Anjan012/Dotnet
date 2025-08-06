using System;

namespace constructer_eg
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            void passByValue(int num)
            {
                num++; // num = num + 1
            }

            void passByReference(ref int num)
            {
                num++;
            }

            int value = 10;
            passByValue(value);
            Console.WriteLine("pass by value: " + value);

            int reference = 10;
            passByReference(reference); // Added 'ref' keyword to fix CS1620
            Console.WriteLine("pass by value: " + reference);
        }
    }
}
