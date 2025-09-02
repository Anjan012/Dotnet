using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_31
{
    class Parent
    {
        public Parent()
        {
            Console.WriteLine("Parent constructor called");
        }

        public void Display()
        {
            Console.WriteLine("Display method of Parent class");
        }
    }

    class Child : Parent
    {
        public Child() : base()
        {
            Console.WriteLine("Child constructor called");
        }

        public void Show()
        {
            base.Display();
        }
    }

    class Program
    {
        static void Main()
        {
            Child obj = new Child();
            obj.Show();
            Console.ReadLine();
        }
    }
}
