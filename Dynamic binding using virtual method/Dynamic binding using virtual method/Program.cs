using System;

namespace Dynamic_binding_using_virtual_method
{
    internal class Program
    {
        public class Animal
        {
            public virtual void Speak()
            { Console.WriteLine("Animal speaks"); }
        }
        public class Dog : Animal
        {
            public override void Speak()
            { Console.WriteLine("Dog barks"); }
        }
        public class Cat : Animal
        {
            public override void Speak()
            { Console.WriteLine("Cat meows"); }
        }

        static void Main(string[] args)
        {
            Animal myAnimal;
            myAnimal = new Dog();
            myAnimal.Speak();
            myAnimal = new Cat();
            myAnimal.Speak();


        }
    }
}
