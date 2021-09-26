using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // while loop   =   repeats some code while some condition is true
            // for loop     =   repeats some code for a finite number of times
            // nested loops =   a loop within a loop
            // for each     =   a simpler way to iterate over an array, but it's less flexible


            // while loop
            String name = "";
            while (name == "") 
            {
                Console.WriteLine("enter your name: ");
                name = Console.ReadLine();
            }
            
            Console.WriteLine("hello " + name);

            // for loop
            for (int i = 0; i < 1001; i++) 
            {
                Console.WriteLine(i);
            }

            for (int i = 10; i > 0; i--) 
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Happy New Year!");

            // nested loops
            Console.WriteLine("How many rows?");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many columns?");
            int cols = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a symbol:");
            char c = Convert.ToChar(Console.ReadLine());

            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(c);
                }
            }

            // for each
            String[] cars = {"F150","BMW","Mustang","Corvette"};

            foreach (String s in cars) 
            {
                Console.WriteLine(s);
            }

            Console.ReadKey();
        }
    }
}
