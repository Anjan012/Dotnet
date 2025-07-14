using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mythirdprogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arrays ----------------------------------
            //storing multiple values of same datatype

            //int[] numbers = new int[3]; // 0-2
            //numbers[0] = 5;
            //numbers[1] = 10;
            //numbers[2] = 15;

            //Console.WriteLine(numbers[0]);

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write("Enter a number: ");
            //    numbers[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write(numbers[i] + " ");
            //}
            //Console.WriteLine();

            //foreach (int num in numbers) // can't choose how may times to loop
            //{
            //    Console.Write(num);
            //}

            //Triangle Exercise ----------------
            //const int angleCount = 3;
            //int[] angles = new int[angleCount]; //  new int[3] having the actual numbers is known as magical number they quite hurt the redability

            //for (int i = 0; i < angles.Length; i++)
            //{
            //    Console.Write($"Enter angle{i+1}: ");
            //    angles[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //int angleSum = 0;

            //foreach (int angle in angles)
            //{
            //   angleSum += angle;
            //}

            //Console.WriteLine(angleSum == 180 ? "Valid" : "Invalid!");

            //more short version : if we are not going to use these values after no point of storing them--
            //const int angleCount = 3;
            //int angleSum = 0;

            //for (int i = 0; i < angleCount; i++)
            //{
            //    Console.Write($"Enter angle{i + 1}: ");
            //    angleSum += Convert.ToInt32(Console.ReadLine());
            //}

            //Console.WriteLine(angleSum == 180 ? "Valid" : "Invalid!");


            //Console.Write("Enter angle 1: ");
            //int angle1 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter angle 2: ");
            //int angle2 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter angle 3: ");
            //int angle3 = Convert.ToInt32(Console.ReadLine());

            //int angleSum = angle1 + angle2 + angle3;

            //Console.WriteLine(angleSum == 180 ? "Valid" : "Invalid!");


            //Array sorting -------------------------------

            //int[] numbers = new int[] { 1, 7, 3, 9, 5 };

            //Array.Sort(numbers); // when you run array function they tend to return back void and you don't have to do anything other than you wanted to sort it will affect the array straight away and you don't have to restore it 

            //foreach (int number in numbers)
            //{
            //    Console.Write(number + " ");
            //}

            // Array reversal-------------------
            int[] numbers = new int[] { 1, 7, 3, 9, 5 };

            //Array.Reverse(numbers); // comes in handy when you have situations like the names or the price by ascending or descending it is a lot easier than going back to the database is that more data and more computational power on the backend 

            //foreach (int number in numbers)
            //{
            //    Console.Write(number + " ");
            //}

            //you can use for loop to do that:
            //int[] sortedNumbers = new int[numbers.Length];

            //int x = 0;

            //for (int i = numbers.Length - 1; i >= 0; i--)
            //{
            //    sortedNumbers[x] = numbers[i];
            //    x++;
            //}

            //foreach(int number in sortedNumbers)
            //{
            //    Console.Write(number + " ");
            //}

        }
    }
}
