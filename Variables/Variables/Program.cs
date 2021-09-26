using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {

            int a; // declaration
            a = 3; // initialization


            // declaration & initialization
            int x = 10;
            string name = "Michael";
            bool b = false;
            double height = 300.5;
            char symbol = '@';
            String username = symbol + name;

            Console.WriteLine(x);
            Console.WriteLine(name);

            int age = 22;



            Console.WriteLine("Your age is " + age);
            Console.WriteLine("Your height is " + height + "cm");
            Console.WriteLine(b);
            Console.WriteLine("Symbol: " + symbol);
            Console.WriteLine(username);

        }
    }
}
