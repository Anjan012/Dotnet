using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructer
{
    internal class Program
    {

        //A constructor is a special method that is used to initialize objects. The advantage of a constructor, is that it is called when an object of a class is created. It can be used to set initial values for fields:
        class Car
        {
            public string model;

            public Car()
            {
                this.model = "MUSTANG";
            }


        }
       
        static void Main(string[] args)
        {
            Car car = new Car();
            Console.WriteLine(car.model);
            Console.ReadKey();
        }
    }
}
