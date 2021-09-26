using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            // exception =  errors that occur during execution

            //              try:     try some code that is considered "dangerous"
            //              catch:   catches and hadles exceptions when they occur
            //              finally: always executes regardless if the exceptiuon is caught or not 


            double x;
            double y;
            double result;

            try
            {
                Console.WriteLine("Enter first number:");
                x = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter second number:");
                y = Convert.ToInt32(Console.ReadLine());


                result = x / y;
                Console.WriteLine("Result: " + result);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Enter only numbers!");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Cannot enter 0 for second number!");
            }
            finally 
            {
                Console.WriteLine("thanks for visiting!");
            }
            Console.ReadKey();
        }
    }
}
