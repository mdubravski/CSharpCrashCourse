using System;

namespace Output
{
    class Program
    {
        static void Main(string[] args)
        {
            // prints sting literal to new line
            Console.WriteLine("Hello World!");

            // does not print string literal on new line
            Console.Write("Hey!");

            /* This 
             * is
             * a
             * multi
             * line
             * comment
             * 
             * 
             */

            /*
             * escape characters
             * \t atab
             * \b backspace
             * \n new line
             * 
             */

            Console.WriteLine("Michael\n");

            // wait for key to be read to end program
            Console.ReadKey(); 

        }
    }
}
