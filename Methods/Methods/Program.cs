using System;

namespace Methods
{
    class Program
    {

        static void singHappyBirthday() 
        {
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine("Happy birthday to YOU!");
            Console.WriteLine("Happy birthday to you!");
        }

        static void singHappyBirthday(string name)
        {
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine("Happy birthday to " + name + "!");
            Console.WriteLine("Happy birthday to you!\n");
        }

        static void Main(string[] args)
        {
            // method = preforms a section of code, wheneverr it's called/invoked
            //          benefit = let's us reuse code w/o writing it multiple times


            singHappyBirthday();
            singHappyBirthday("Michael");

            Console.ReadKey();
        }
    }
}
