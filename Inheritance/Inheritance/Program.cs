using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // inheritance = 1 or more child classes recieving fields, methods, etc. from a common parent
            //                 allows us to reuse code

            Car car = new Car();
            Bicycle bike = new Bicycle();
            Boat boat = new Boat();

            Console.WriteLine(car.speed);
            Console.WriteLine(car.wheels);
            car.Go();

            Console.WriteLine(bike.speed);
            Console.WriteLine(bike.wheels);
            bike.Go();

            Console.WriteLine(boat.speed);
            Console.WriteLine(boat.wheels);
            boat.Go();

            Console.ReadKey();
        }
    }

    // parent class
    class Vehicle 
    {
        public int speed = 0;

        public void Go() 
        {
            Console.WriteLine("this Vehicle is moving");
        }
    }

    // child classes
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
