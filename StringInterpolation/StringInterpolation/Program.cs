using System;

namespace StringInterpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            // string interpolation =   allows us to insert variable into string literals
            //                          precede a string with $
            //                          {} are placeholders

            string first = "michael";
            string last = "dubravski";
            int age = 22;

            // no string interpolation (using string concatination)
            Console.WriteLine("hello " + first +" "+last+".");
            Console.WriteLine("You are " + age + " years old.");

            // using string interpoliation
            Console.WriteLine($"hello {first} {last}.");
            Console.WriteLine($"you are {age,-10} years old.");


            Console.ReadKey();
        }
    }
}
