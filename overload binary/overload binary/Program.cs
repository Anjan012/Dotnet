using System;

namespace OperatorOverloading
{
    class Complex
    {
        public int Real { get; set; }
        public int Imaginary { get; set; }

        public Complex(int r, int i)
        {
            Real = r;
            Imaginary = i;
        }

        public static Complex operator +(Complex c1, Complex c2)
        {
            return new Complex(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary);
        }

        public static bool operator ==(Complex c1, Complex c2)
        {
            return (c1.Real == c2.Real) && (c1.Imaginary == c2.Imaginary);
        }

        public static bool operator !=(Complex c1, Complex c2)
        {
            return !(c1 == c2);
        }

        public override string ToString()
        {
            return $"{Real} + {Imaginary}i";
        }

        public override bool Equals(object obj)
        {
            if (obj is Complex c)
                return this == c;
            return false;
        }

        public override int GetHashCode()
        {
            return Real.GetHashCode() ^ Imaginary.GetHashCode();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Complex c1 = new Complex(2, 3);
            Complex c2 = new Complex(4, 5);
            Complex sum = c1 + c2;

            Console.WriteLine($"c1 = {c1}");
            Console.WriteLine($"c2 = {c2}");
            Console.WriteLine($"Sum = {sum}");

            Complex c3 = new Complex(6, 8);

            Console.WriteLine($"Is sum equal to c3? {(sum == c3)}");
        }
    }
}
