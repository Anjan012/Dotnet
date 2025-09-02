using System;

class Program
{
    static void Main()
    {
        try
        {
            int x = 5;
            int y = 0;
            int result = x / y; // This will throw DivideByZeroException
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
    }
}
