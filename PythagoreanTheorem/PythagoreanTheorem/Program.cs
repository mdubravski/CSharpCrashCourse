using System;

namespace PythagoreanTheorem
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter side a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter side b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            double hypo = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            Console.WriteLine("Hypotenuse: " + hypo);

            Console.ReadKey();
        }
    }
}
