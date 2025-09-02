using System;

// Step 1
delegate void GreetDelegate(string name);

class Program
{
    // Step 2
    static void SayHello(string name)
    {
        Console.WriteLine("Hello, " + name);
    }

    static void SayBye(string name)
    {
        Console.WriteLine("Goodbye, " + name);
    }

    static void Main()
    {
        // Step 3: Assign methods to delegate
        GreetDelegate greet1 = SayHello;
        GreetDelegate greet2 = SayBye;

        greet1("Anjan");   // Output: Hello, Anjan
        greet2("Anjan");   // Output: Goodbye, Anjan
    }
}
