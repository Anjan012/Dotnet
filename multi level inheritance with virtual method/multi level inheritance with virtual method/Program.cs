using System;

namespace multi_level_inheritance_with_virtual_method
{
    internal class Program
    {
        class Animal
        {
            public virtual void Speak()
            { Console.WriteLine("Animal speaks"); }
        }
        class Dog : Animal
        {
            public override void Speak()
            { 
              Console.WriteLine("Dog barks");
            }
        }
        class Puppy : Dog // Further derived class
        {
            public override void Speak()
            { 
              Console.WriteLine("Puppy yaps");
            }
        }

        static void Main(string[] args)
        {
            Animal myAnimal = new Animal();
            myAnimal.Speak();
            Dog myDog = new Dog();
            myDog.Speak();
            Puppy myPuppy = new Puppy();
            myPuppy.Speak();
        }
    }
}
