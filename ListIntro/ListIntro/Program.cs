using System;
using System.Collections.Generic;

namespace ListIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // List =   data structure that represents a list of objects that can be accessed by index
            //          similar to array, but can dynamically increase/decrease in size
            //          using System.Collections.Generic;


            // declaring a fixed size array
            string[] food = new string[3];
            food[0] = "pizza";
            food[1] = "fries";
            food[2] = "chicken fingers";

            Console.WriteLine("Fixed size array");
            foreach (string f in food) 
            {
                Console.WriteLine(f);
            }
            Console.WriteLine();

            // creating List
            List<string> foodList = new List<string>();
            foodList.Add("pizza");
            foodList.Add("hamburger");
            foodList.Add("hotdog");
            foodList.Add("chicken fingers");
            foodList.Add("hotdog");

            foodList.Remove("pizza");
            foodList.Insert(1, "cheeseburger");
            Console.WriteLine(foodList.Count);
            Console.WriteLine(foodList.IndexOf("chicken fingers"));
            Console.WriteLine(foodList.LastIndexOf("hotdog"));
            
            // sort alphabetically
            foodList.Sort();
            Console.WriteLine(foodList);

            // reverse sort 
            foodList.Reverse();
            Console.WriteLine(foodList);

            // clear list
            foodList.Clear();

            // convert List to array
            food = foodList.ToArray();

            Console.WriteLine("List object");
            foreach (string f in foodList)
            {
                Console.WriteLine(f);
            }

            Console.WriteLine(foodList[2]);

            

            Console.ReadKey();
        }
    }
}
