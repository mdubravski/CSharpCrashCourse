using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            double y;
            string op = "";
            string result = "";

            Console.WriteLine("-------------------");
            Console.WriteLine("Calculator Program");
            Console.WriteLine("-------------------\n");

            Console.WriteLine("Enter first number: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            y = Convert.ToDouble(Console.ReadLine());

            while (op != "+" && op != "-" && op !="*" && op != "/")
            {
                Console.WriteLine("Enter Opperation (+, -, *, /): ");
                op = Console.ReadLine();
            }

            switch (op) 
            {
                case "+":
                    result = Convert.ToString(x + y);
                    break;
                case "-":
                    result = Convert.ToString(x - y);
                    break;
                case "*":
                    result = Convert.ToString(x * y);
                    break;
                case "/":
                    result = Convert.ToString(x / y);
                    break;
            }

            Console.WriteLine(x + " " + op + " " + y + " " + "=" + " " + result);
            Console.ReadKey();
        }
    }
}
