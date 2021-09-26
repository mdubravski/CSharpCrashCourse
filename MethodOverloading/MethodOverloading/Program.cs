using System;

namespace MethodOverloading
{
    class Program
    {
        static int mult(int a, int b) 
        {
            return a * b;
        }

        static double mult(double a, double b)
        {
            return a * b;
        }

        static string mult(String s, int b)
        {

            for (int i = 0; i < b; i++) 
            {
                s = s + "\n" + s;
            }

            return s;
        }


        static void Main(string[] args)
        {
            // method overloading = methods share same name, but different parameters
            //                      name + parameters = method signature
            //                      methods must have a unique signature


            int a = 5;
            double  b = 3.14;
            string s = "Goober";

            Console.WriteLine(mult(a, b));
            Console.WriteLine(mult(b, b));
            Console.WriteLine(mult(s, a));

            Console.ReadKey();
        }
    }
}
