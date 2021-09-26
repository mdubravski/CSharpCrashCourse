using System;

namespace StringMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            String fullName = "Michael Dubravski";
            String phoneNumber = "555-123-1234";

            // .toUpper()   conver string to uppercase
            Console.WriteLine(fullName.ToUpper());

            // .toLower()   convert string to lowercase
            Console.WriteLine(fullName.ToLower());

            // .Replace     replace character with given character
            Console.WriteLine(phoneNumber.Replace("-","_"));

            // .Insert()    insert character at given index with given character
            Console.WriteLine(phoneNumber.Insert(2,"9"));

            // .Replace     replace all instances of char in string to given char
            Console.WriteLine(phoneNumber.Replace("5","9"));

            // .Length      return the number of character in string (not a function)
            Console.WriteLine(phoneNumber.Length);

            // .Substring   return section of given string at given index and # of characters after
            Console.WriteLine(phoneNumber.Substring(8));
            Console.WriteLine(phoneNumber.Substring(4,3));

            Console.ReadKey();
        }
    }
}
