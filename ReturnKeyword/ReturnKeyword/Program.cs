using System;

namespace ReturnKeyword
{
    class Program
    {

        static double mult(double a, double b) 
        {
            return a * b;
        }

        static void Main(string[] args)
        {
            // return = returns data back to the place where a method is invoked

            Console.WriteLine("Enter first number:");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(mult(a,b));

            Console.ReadKey();

        }
    }
}
