using System;

namespace MathMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 3.94;
            double y = 5;

            // Math.Pow()   raise a vlaue to a specified power
            double a = Math.Pow(x, 2); // x^2
            Console.WriteLine(a);

            // Math.Sqrt()  take square root of number
            double b = Math.Sqrt(x);
            Console.WriteLine(b);

            // Math.Abs()   find absolute value
            double c = Math.Sqrt(x);
            Console.WriteLine(c);

            // Math.Round() round number 
            double d = Math.Round(x);
            Console.WriteLine(d);

            // Math.Ceiling()   round number up
            double e = Math.Ceiling(x);
            Console.WriteLine(e);

            // Math.Floor()   round number down
            double f = Math.Floor(x);
            Console.WriteLine(f);

            // Math.Max()   return max of two numbers
            double g = Math.Max(x, y);
            Console.WriteLine(g);

            // Math.Min()   return min of two numbers
            double h = Math.Min(x, y);
            Console.WriteLine(h);

            Console.ReadKey();
        }
    }
}
