using System;

namespace ConditionalOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            // conditional operator = used in condiotional assignments if a conditon is true/false

            //                          ex. (condition) ? true : false


            double temp = 20;
            string message;

            // using if statements
            if (temp >= 15)
            {
                Console.WriteLine("its hot");

            }
            else
            {
                Console.WriteLine("its cold");
            }

            message = (temp >= 20) ? "its hot" : "its cold";
            Console.WriteLine(message);


            Console.ReadKey();
        }
    }
}
