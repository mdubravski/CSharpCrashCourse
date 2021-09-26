using System;

namespace ParamsKeyword
{
    class Program
    {

        static double checkOut(params double[] a) 
        {
            double total = 0;

            foreach (double d in a) 
            {
                total += d;
            }

            return total;
        }

        static void Main(string[] args)
        {
            // params keyword = a method parameter that takes a variable anumber of arguments
            //                  the parameter type must be a single-dimensional array

            Console.WriteLine(checkOut(30.3,55.2,10.99));

            Console.ReadKey();
        }
    }
}
