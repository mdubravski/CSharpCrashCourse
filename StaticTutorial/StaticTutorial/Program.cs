using System;

namespace StaticTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // static = modifier to declar a static member, whcih belongs to the class itsself
            //          rather than to any specific object
            //          cannoit create objects of a static class

            // getting field in non-static way          c1.numCars
            // getting field in static way              Car.numCars

            Car c1 = new Car("F150");
            Car c2 = new Car("Mustang");

            Console.WriteLine(Car.numCars);
            Car.StartRace();
            Console.ReadKey();
        }
    }

    class Car
    {
        String model;
        public static int numCars;
        public Car(String model)
        {
            this.model = model;
            numCars++;
        }

        public static void StartRace() 
        {
            Console.WriteLine("3,2,1 GO!");
        }
    }
}
