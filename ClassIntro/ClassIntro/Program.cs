using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // class =  bundle of related code
            //          can be used as a blueprint to create objects (OOP)

            // functions pulled form Math class
            Math.Min(5,10);
            Math.Max(3,5);
            Math.Sqrt(4);

            // using functions from custoim made Messages class
            Messages.Hello();
            Messages.Wait();
            Messages.Goodbye();

            Console.ReadKey();
        }
    }


    // making a class 
    static class Messages 
    {
        public static void Hello() { Console.WriteLine("Hello!"); }
        public static void Wait() { Console.WriteLine("I am waiting..."); }
        public static void Goodbye() { Console.WriteLine("Goodbye!"); }
    }
}
