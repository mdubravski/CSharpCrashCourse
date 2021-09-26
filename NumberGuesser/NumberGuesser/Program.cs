using System;


// namespace
namespace NumberGuesser
{
    // main class
    class Program
    {
       
        // entry point method
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number between 1 and 1000");
            int guess = Int32.Parse(Console.ReadLine());
            Random rd = new Random();
            int ans = rd.Next(1000);

            while (guess != ans)
            {
                if (guess > ans)
                {
                    Console.WriteLine("Guess Lower!");
                    Console.WriteLine("Guess a number between 1 and 1000");
                    guess = Int32.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Guess Higher!");
                    Console.WriteLine("Guess a number between 1 and 1000");
                    guess = Int32.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("You Guessed correctly " + ans);


        }
    }
}
