using System;

namespace Switches
{
    class Program
    {
        static void Main(string[] args)
        {
            // switch = an effiecient alternative to manu else if statements

            Console.WriteLine("What day is it today?");
            String day = Console.ReadLine();

            switch (day)
            {
                case "Monday":
                    Console.WriteLine("Today is Monday!");
                    break;
                case "Tuesday":
                    Console.WriteLine("Today is Tuesday!");
                    break;
                case "Wednsday":
                    Console.WriteLine("Today is Wednsday!");
                    break;
                case "Thursday":
                    Console.WriteLine("Today is Thursday!");
                    break;
                case "Friday":
                    Console.WriteLine("Today is Friday!");
                    break;
                case "Saturday":
                    Console.WriteLine("Today is Saturday!");
                    break;
                case "Sunday":
                    Console.WriteLine("Today is Sunday!");
                    break;
                default:
                    Console.WriteLine(day +" is not a day!");
                    break;

            }


            Console.ReadKey();
        }
    }
}
