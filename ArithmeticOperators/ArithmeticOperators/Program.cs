using System;

namespace ArithmeticOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int friends = 5;

            friends = friends + 1;
            friends += 3;
            friends++;

            friends = friends - 1;
            friends -= 2;
            friends--;

            friends = friends * 2;
            friends *= 2;

            // integer division
            friends = friends / 2;
            friends /= 2;

            double d = 13;

            // mod
            friends = 10;
            int remainder = friends % 3;
            Console.WriteLine(remainder);
            Console.WriteLine(friends);


            Console.ReadKey();
        }
    }
}
