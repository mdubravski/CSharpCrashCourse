using System;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            // abstract classes = modifier that indicates missing components or incomplete implementation
            //                      cannot instantiate objects of an abstract class

            Console.ReadKey();
        }
    }

    abstract class Vehicle 
    {
        public int speed = 0;

        public void Go() 
        {
            Console.WriteLine("This vehicle is moving.");
        }
    }

    class Car : Vehicle 
    {
        public int wheels = 4;
    }

    class Bicycle : Vehicle
    {
        public int wheels = 2;
    }

    class Boat : Vehicle
    {
        public int wheels = 0;
    }
}
