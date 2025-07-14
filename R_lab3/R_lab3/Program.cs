//Lab 3: Write a C# program to achieve dynamic binding using virtual method in C#

//Dynamic Binding also known as Runtime Polymorphism:
//Happens at runtime (not during compilation). The method to be called is decided during execution — based on the object type.

//Achieved in C# using:

//    virtual methods in base class

//    override methods in derived class

using System;


namespace R_lab3
{
    internal class Program
    {
        class Animal
        {
            // Virtual method - can be overridden in derived class
            public virtual void Speak()
            {
                Console.WriteLine("The animal makes a sound.");
            }
        }

        // Dog inherits Animal
        class Dog : Animal
        {
            // Override the virtual method
            public override void Speak() // override → tells the compiler: “Use this version of the method instead of the base version if this object is used.” the base version doesn't get affected
            {
                Console.WriteLine("The dog barks.");
            }
        }

        // Cat inherits Animal
        class Cat : Animal
        {
            public override void Speak()
            {
                Console.WriteLine("The cat meows.");
            }
        }

        static void Main()
        {
            // Base class reference pointing to derived class objects
            Animal a1 = new Dog();  // Dynamic binding here
            Animal a2 = new Cat();  // Dynamic binding here
            Animal a3 = new Animal(); // Calls base class method

            // Method calls (decided at runtime)
            a1.Speak(); // Calls Dog's Speak()
            a2.Speak(); // Calls Cat's Speak()
            a3.Speak(); // Calls Animal's Speak()

            //Even though the variable type is Animal, the actual object type(Dog, Cat) decides which method runs. This is runtime decision = dynamic binding
        }
    }
}
