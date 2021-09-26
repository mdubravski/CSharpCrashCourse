using System;

namespace RandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            // .Next()  generate random whole integer 0 .. 2billion
            int x = rand.Next();
            Console.WriteLine(x);

            // .Next(1,101) generate random int between 1 and 100, second param exclusive
            int y = rand.Next(1, 101);
            Console.WriteLine(y);

            // .NextDouble()    generate random double between 0 .. 1
            double d = rand.NextDouble();
            Console.WriteLine(d);

            // roll 3 dice
            int dice1 = rand.Next(1, 7);
            int dice2 = rand.Next(1, 7);
            int dice3 = rand.Next(1, 7);
            Console.WriteLine(dice1);
            Console.WriteLine(dice2);
            Console.WriteLine(dice3);


            Console.ReadKey();
        }
    }
}
