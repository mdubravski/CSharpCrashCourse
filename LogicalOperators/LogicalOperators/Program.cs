using System;

namespace LogicalOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            // logical operators = Can be used to check if more than 1 condition is true/false
            // && AND
            // || OR

            Console.WriteLine("What is the temperature outside?");
            int temp = Convert.ToInt32(Console.ReadLine());

            if (temp < 0)
            {
                Console.WriteLine("it is freezing!");
            }
            else if (temp > 0 && temp <= 40)
            {
                Console.WriteLine("it is cold!");
            }
            else if (temp > 40 && temp <= 60)
            {
                Console.WriteLine("it is chilly!");
            }
            else if (temp > 60 && temp <= 70)
            {
                Console.WriteLine("it is warm!");
            }
            else 
            {
                Console.WriteLine("it is hot!");
            }

            Console.ReadKey();
        }
    }
}
