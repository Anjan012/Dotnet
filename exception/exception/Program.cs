using System;


namespace exception
{
    internal class Program
    {
        class Animal // parent class
        {
            public void Sound()
            {
                Console.WriteLine("animal make sound");
            }
        }
        class Dog : Animal // Dog is a child class of Animal, dog will inherit the properties and methods of Animal
        {
            public void Sound()
            {
                Console.WriteLine("Woof!");
            }

            public void name()
            {
               Console.WriteLine("Dog");
            }
        }


        static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.Sound(); // Output: animal make sound
            Dog dog = new Dog();
            dog.Sound(); // Output: Woof!
        }
    }
}
