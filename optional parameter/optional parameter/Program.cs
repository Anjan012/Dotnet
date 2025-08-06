using System;


namespace optional_parameter
{
    internal class Program
    {
        public void greet(string name = "User")
        {
            Console.WriteLine("hello" + name);
        }
        static void Main(string[] args)
        {

            greet();
        }
    }
}
