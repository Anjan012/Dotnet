using System;

class Animal
{
    public void Speak()
    {
        Console.WriteLine("The animal speaks.");
    }
}

class Dog : Animal
{
    // This is not an override. It's a new method.
    public void Speak()
    {
        Console.WriteLine("The dog barks.");
    }
}

class Program
{
    static void Main()
    {
        Animal a = new Dog();
        a.Speak(); // Output: "The animal speaks." - static binding (compile time decides to use Animal's Speak)
    }
}
