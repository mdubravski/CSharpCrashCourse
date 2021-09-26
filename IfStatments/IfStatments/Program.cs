using System;

namespace IfStatments
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age < 21)
            {
                Console.WriteLine("You are under 21");
            }
            else 
            {
                Console.WriteLine("You are over 21");
            }

            Console.ReadKey();
        }
    }
}
