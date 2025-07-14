using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Threading;

namespace MySecondProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Exercise: Fizz buzz game
            /* Create a for loop that counts from 1 - 15 
             * If the number is divisible by 3, print "Fizz"
             * If the number is divisible by 5, print "Buzz"
             * If the number is divisible by both 3 and 5, print "FizzBuzz"
             * Otherwise, print the number itself
             */


            //bool threeDiv = false;
            //bool fiveDiv = false;

            //for (int i = 1; i <= 15; i++)
            //{
            //    threeDiv = i % 3 == 0;
            //    fiveDiv = i % 5 == 0;
            //    if (threeDiv && fiveDiv)
            //    {
            //        Console.WriteLine("Fizzbuzz");
            //    }
            //    else if (threeDiv)
            //    {
            //        Console.WriteLine("Fizz");

            //    }
            //    else if (fiveDiv)
            //    {
            //        Console.WriteLine("Buzz");

            //    }
            //    else
            //    {
            //        Console.WriteLine(i);

            //    }
            //}


            // verbatim string literal---------------------

            // \t \n \ 
            // \\ = \
            //string speech = "he said \"something\" ";
            //string path = "C:\\User\\CoffeeNCode\\Desktop\\C# \n new line"; // // if you use \n \t then it will just process them as strings literal

            //Console.WriteLine(path);

            // we also have verbatim string literals @ that allow us to use \ without escaping to put verbatim identifier use @ before a string
            //String path2 = @"C:\User\CoffeeNCode\Desktop\C# \n new line"; // this will not process \n as a new line, it will just be a string literal it will neglet all of the escape characters
            //Console.WriteLine(path2);

            //if you want to add speech mark " in verbatim you have to put in "" double on each side like below:
            //string greet = @"Hello ""someone"" ";
            //Console.WriteLine(greet);
            //greet = "Hello 'someone'";

            // String formatting -----------------------
            //using composite formatting
            //string name = "Anjan";
            //int age = 21;

            //Console.WriteLine("Your name is {0}, and your age is {1}", name, age); // from left to right at the end ", put any object will display from left to right 0 replace by name 1 replace by age
            //Console.WriteLine("Name: {0}, \nAge: {1}", name, age);

            //Console.ReadLine();

            // String Interpolation--------------------
            // It is the another method of string concatination
            //string name = "Anjan";
            //int age = 21;

            //Console.WriteLine($"Your name is {name}, and your age is {age}");

            //string concatination---------


            //string test =  string.Concat("Your name is ", name, " and your age is ", age);

            //Empty Strings--------------------

            //Console.WriteLine("Enter Your Name: ");
            //string name = Console.ReadLine();

            //if (name != string.Empty) // string.Empty is more readable than "" it also gives you the better representation of what's going on instead fo ""
            //{
            //    Console.WriteLine($"Your name is ${name}");
            //}
            //else
            //{
            //    Console.WriteLine("Name is empty");
            //}

            // String Equals function -----------------
            //string message = "Hello";
            //string compare = "Hello";

            //if (message.Equals(compare))
            //{
            //    Console.WriteLine("Same");
            //}
            //else
            //{
            //    Console.WriteLine("Different");
            //}

            //== not only compares the value but also the memory address but .Equals concerns about the values 


            // String iteration (looping)-----------
            //string is ArgumentNullException array of character
            //string message = "C# is awesome";
            //Console.WriteLine(message[0]);

            //for(int i = 0; i<message.Length; i++)
            //{
            //    Console.Write(message[i]);
            //    Thread.Sleep(250); // 1000ms = 1s
            //}
            //Console.WriteLine();
            //Console.WriteLine(message.Contains("C"));


            //bool contains = false;

            //for (int i = 0; i < message.Length; i++)
            //{
            //    if (message[i].Equals("C"))
            //    {
            //        contains = true;
            //    }
            //}

            //Console.WriteLine(contains);

            //String isNUllorEmpty function ----------------------------
            //make sure string is valid before we can process information on it

            //Console.Write("Enter Your name: ");
            //string name = Console.ReadLine();

            //Console.WriteLine($"Your name is {name}");

            //if (name != "")
            //    Console.WriteLine("0");

            //if (!name.Equals(""))
            //    Console.WriteLine("1");

            //if(!string.IsNullOrEmpty(name)) // improves the stability so that the exception doesn't happens 
            //    Console.WriteLine("2");


            // Print string in reverse ----------------------------------

            //Console.Write("Enter your message: ");
            //string message = Console.ReadLine();

            //for (int i = 0; i < message.Length; i++)
            //{
            //    Console.Write(message[i]);
            //}

            //Console.WriteLine();

            ////forr tab tab shortcut
            //for (int i = message.Length-1; i>=0;  i--)
            //{
            //    Console.Write(message[i]);
            //}


            //building a password checker-------------------------------

            Console.Write("Enter a passsword: ");
            string pass1 = Console.ReadLine();

            Console.Write("Enter the passsword again: ");
            string pass2 = Console.ReadLine();

            if (!pass1.Equals(string.Empty))
            {
                if (!pass2.Equals(string.Empty))
                {
                    if (pass1.Length >= 6 && pass2.Length >= 6)
                    {
                        if (pass1.Equals(pass2))
                        {
                            Console.WriteLine("Password match");
                        }
                        else
                        {
                            Console.WriteLine("Password do not match");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Password character must be equal or greater than 6 character");
                    }
                }


                else
                {
                    Console.WriteLine("Please enter a password confirmation");
                }
                

            }
            else
            {
                Console.WriteLine("Please enter a password.");

            }











        }
    }
}
