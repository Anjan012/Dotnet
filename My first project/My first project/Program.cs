using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization; // For culture-specific formatting

namespace My_first_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int age = 21;
            //Console.WriteLine(age);

            //long bigNumber = 9000000L;
            //Console.WriteLine(bigNumber);

            //// to check how big and small int can be
            //Console.WriteLine(int.MinValue);
            //Console.WriteLine(int.MaxValue);

            //Console.WriteLine(long.MinValue);
            //Console.WriteLine(long.MaxValue);


            //double negative = -55.2D;
            //Console.WriteLine(negative);
            //Console.WriteLine(double.MinValue);
            //Console.WriteLine(double.MaxValue);

            //float precision = 5.000001F;
            //Console.WriteLine(precision);
            //Console.WriteLine(float.MinValue);
            //Console.WriteLine(float.MaxValue);

            //decimal money = 14.99M;
            //Console.WriteLine(money);
            //Console.WriteLine(decimal.MinValue);
            //Console.WriteLine(decimal.MaxValue); 
            //Console.ReadLine();

            //string name = "Anjan'";
            //char letter = 'A';

            //Console.Write("Your name is: "); // for single line
            //Console.Write(name);
            //Console.WriteLine(letter);

            //string textAge = "-23";
            //int age = Convert.ToInt32(textAge);
            //Console.WriteLine(age);

            //string textBigNumber = "9000000";
            //long bigNumber = Convert.ToInt64(textBigNumber);
            //Console.WriteLine(bigNumber);

            //string textNegative = "-55.2";
            //double negative = Convert.ToDouble(textNegative);
            //Console.WriteLine(negative);

            //string textPrecision = "5.000001";
            //float precision = Convert.ToSingle(textPrecision);
            //Console.WriteLine(precision);

            //string textMoney = "14.99";
            //decimal money = Convert.ToDecimal(textMoney);
            //Console.WriteLine(money);



            // Boolean data type------------------------------------------------------
            //bool value = false;
            //bool isMale = true;

            // operators ------------------------------------------------------
            //int age = 23;
            //age++; // incrementing age by 1
            //Console.WriteLine(age);
            //age--; // decrementing age by 1
            //Console.WriteLine(age);

            //int operation = 23 / 10; // use double for decimal division ( to get exact value)
            //Console.WriteLine(operation);

            //string name = "Anjan";
            //name += " is programmer"; // concatenation
            ////name -= " is programmer"; // error : -= operator is not defined for string
            //Console.WriteLine(name);

            //char ch = 'A';
            //ch++; // incrementing char by 1 we will get B
            //ch += 'C'; // provides a unicode 
            //Console.WriteLine(ch); // B

            //int firstNumber = 10;
            //int secondNumber = 3;
            //Console.WriteLine(firstNumber % secondNumber);

            //Console.WriteLine(1000 % 90);
            //Console.WriteLine(100 % 90);
            //Console.WriteLine(71 % 90);

            //// var keyword ------------------------------------------------------
            //var age = 23; // compiler will automatically detect the type of variable
            ////var num; // error: var must be initialized
            //var name = "Anjan"; // compiler will detect it as string
            //var isMale = true; // compiler will detect it as bool
            //var bigNumber = 9000000L; // compiler will detect it as long
            //var money = 14.99M; // compiler will detect it as decimal
            //var precision = 5.000001F; // compiler will detect it as float
            //var negative = -55.2D; // compiler will detect it as double

            //// Const keyword ------------------------------------------------------
            //int vat = 20;
            //vat = 25; // this is allowed because vat is not a constant
            //const int tax = 10; // this is a constant, cannot be changed
            ////tax = 13; // error: cannot assign a value to a const variable
            //Console.WriteLine("VAT: " + vat);
            //Console.WriteLine("Tax: " + tax);


            //const int vat = 20; // this is a constant, cannot be changed
            //int balance = 1000;
            ////Console.WriteLine(balance * (vat/100D)); 
            //const double percentVat = vat/100D;
            //Console.WriteLine(balance * percentVat);


            //storing the user data in variables-----------
            //string name = "Anjan";
            ////long number = 09813175695; // Note: Leading zeroes in long will be ignored, so this will be treated as 9813175695
            //string phoneNumber = "09813175695"; // Use string to preserve leading zeroes
            //int age = 21;
            //Console.WriteLine(name);
            //Console.WriteLine(phoneNumber);
            //Console.WriteLine(age);

            // odd and even checcker ------------------

            //int num1 = 10;
            //int num2 = 2;
            //int remainder = num1 % num2;
            //Console.WriteLine(remainder); // Output: 0, which means num1 is even

            //num1 = 11;
            //remainder = num1 % num2;
            //Console.WriteLine(remainder);

            // Console Input/Output ------------------
            //Console.Write("Enter your name: "); // Prompt the user for input
            //string name = Console.ReadLine(); // Read the input from the user

            //Console.Write("Enter your age: "); // Prompt the user for input
            //int age = Convert.ToInt32(Console.ReadLine()); // Read the input and convert it to an integer


            ////Console.Write(" My name is ");
            ////Console.Write(name);
            ////Console.Write(" and your age is ");
            ////Console.Write(age);

            //Console.WriteLine(); // Print a new line for better readability
            //Console.WriteLine("Your name is " + name + " and your age is " + age); // Concatenate strings and variables for output

            // If statements ------------------

            //Console.WriteLine("Enter Your Age: ");
            //int age = Convert.ToInt32(Console.ReadLine());


            //if(age < 0 || age > 150)
            //{
            //    Console.WriteLine("Invalid age");
            //}
            //else
            //{
            //    if (age > 18 && age <= 25) // Check if age is greater than 18
            //    {
            //        // If the condition is true, this block will execute

            //        Console.WriteLine("You are between 18 and 25");
            //    }
            //    else if (age >= 26)
            //    {
            //        Console.WriteLine("You are 26 or elder");
            //    }
            //    else
            //    {
            //        Console.WriteLine("You are below 18");
            //    }
            //}

            // multiplication quiz 
            //Console.Write("Enter the first number: ");
            //int numberA = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter the second number: ");
            //int numberB = Convert.ToInt32(Console.ReadLine());

            //int answer = numberA * numberB;
            //Console.Write("Value of " + numberA + " X " + numberB + " :");
            //int actualInput = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine();


            //if (actualInput == answer)
            //{
            //    Console.WriteLine("Correct Answer!");
            //}
            //else
            //{
            //    Console.WriteLine("Wrong Answer! The correct answer is: " + answer);
            //}

            // Switch statement ----------------
            //Console.Write("Enter a day of the week (1-7): ");
            //int day = Convert.ToInt32(Console.ReadLine());

            //switch (day)
            //{
            //    case 1:
            //    Console.WriteLine("Monday");
            //    break;
            //    case 2:
            //    Console.WriteLine("Tuesday");
            //    break;
            //    case 3:
            //    Console.WriteLine("Wednesday");
            //    break;
            //    case 4:
            //    Console.WriteLine("Thursday");
            //    break;
            //    case 5:
            //    Console.WriteLine("Friday");
            //    break;
            //    case 6:
            //    Console.WriteLine("Saturday");
            //    break;
            //    case 7:
            //    Console.WriteLine("Sunday");
            //    break;
            //    default:
            //    Console.WriteLine("Invalid day number. Please enter a number between 1 and 7.");
            //    break;
            //}

            // For loop ----------------

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("Hi");
            //}

            //for(int i = 0; i<=10; i+=2)
            //{
            //    Console.WriteLine("Even number: " + i);
            //}

            //Console.Write("What do you want to print: ");
            //String message = Console.ReadLine();

            //Console.Write("How many times you want to print message: ");
            //int loopCounter = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(); // Print a new line for better readability

            //if (loopCounter <=0)
            //{
            //    Console.WriteLine("Please enter a positive number greater than zero.");
            //}
            //else
            //{
            //    for (int i = 1; i <= loopCounter; i++) // Loop from 1 to the user-defined number
            //    {
            //        Console.WriteLine(message);
            //    }
            //}

            // While loop ----------------
            //int i = 1; // Initialize i to 1
            //while (i <= 10)
            //{
            //  Console.WriteLine("Hi " + i);
            //  i++; // Increment i to avoid infinite loop
            //}


            //Console.Write("Enter the first number: ");
            //int numberA = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter the second number: ");
            //int numberB = Convert.ToInt32(Console.ReadLine());

            //int answer = numberA * numberB;
            //int actualInput = 0; // Initialize actualInput to avoid unassigned variable error

            /*
            while(answer != actualInput)
            {
                Console.WriteLine();    
                Console.WriteLine("What's the value of " + numberA + " X " + numberB + " ?");
                Console.Write("Enter Your Answer: ");
                actualInput = Convert.ToInt32(Console.ReadLine());

                if (answer != actualInput)
                {
                    Console.WriteLine("The answer is not correct!");
                }
            }
            Console.WriteLine("Well done");
            */

            // Do-While loop ----------------
            // only happens once even if the condition is false
            //do
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("What's the value of " + numberA + " X " + numberB + " ?");
            //    Console.Write("Enter Your Answer: ");
            //    actualInput = Convert.ToInt32(Console.ReadLine());

            //    if (answer != actualInput)
            //    {
            //        Console.WriteLine("The answer is not correct!");
            //    }
            //} while (answer != actualInput);

            //int age = -10;

            // condition ? true : false; // ternary operator

            //string result = age >= 0 ? "valid age" : "invalid age"; // if age is greater than or equal to 0, then result will be "valid age" otherwise "invalid age"
            //Console.WriteLine(result);

            // Numeric Formatting ----------------

            //double value = 1000 / 12.34D;
            //Console.WriteLine(value); // Output: 81.07303370786517
            //Console.WriteLine(String.Format("{0:0}", value));
            //Console.WriteLine(String.Format("{0:0.0}", value));
            //Console.WriteLine(String.Format("{0:0.00}", value));
            //Console.WriteLine(String.Format("{0:0.#}", value));

            //double money = -10D / 3D;
            //Console.WriteLine(money);
            //Console.WriteLine(String.Format("$ {0:0.00}", money));
            //Console.WriteLine(money.ToString("C")); // Formats the number as currency based on the current culture 
            //Console.WriteLine(money.ToString("C0")); // Formats the number as currency with no decimal places (whole number
            //Console.WriteLine(money.ToString("C1")); // Formats the number as currency with one decimal place
            //Console.WriteLine(money.ToString("C2")); // Formats the number as currency with two decimal places

            //Console.WriteLine(money.ToString("C", CultureInfo.CurrentCulture));
            //Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-NEP")));

            // TryParse functions ----------------

            //bool success = true;

            //while (success)
            //{
            //    Console.Write("Enter a number: ");
            //    String numInput = Console.ReadLine();
             
            //    if(int.TryParse(numInput, out int num))
            //    {
            //        Console.WriteLine(num);
            //        success = false; // Exit the loop if parsing is successful
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid input. Please enter a valid number.");
            //    }
            //}

            // Exercise ----------

            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i<= 10; i++)
            {
                //Console.WriteLine(number + "X" + i + "= " + number * i);
                Console.WriteLine("{0} x {1} = {2}", number, i, number * i);
            }

        }
    }
}
