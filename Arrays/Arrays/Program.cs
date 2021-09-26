using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // array =  a variable that cnaa store multipe values. fixed size

            String[] cars = { "F150", "Mustang", "Corvette", "Forrester" };

            string[] books = new string[3];

            cars[1] = "Tesla";

            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }


            Console.ReadKey();
        }
    }
}
