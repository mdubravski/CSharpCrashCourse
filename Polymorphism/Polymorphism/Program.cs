using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            // polymorphism =   Greek word that means to "have many forms"
            //                  Objects can be identified by more than one type
            //                  Ex. Dog is also: Canine, Animal, Organism

            Car car = new Car();
            Bicycle bike = new Bicycle();
            Boat boat = new Boat();

            Vehicle[] vehicles = {car, bike, boat };

            foreach (Vehicle v in vehicles) 
            {
                v.Go();
            }


            Console.ReadLine();
        }
    }

    class Vehicle
        {
        public virtual void Go()
        {
           
        }
    }

    class Car : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("The car is moving!");
        }
    }

    class Bicycle : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("The bicycle is moving!");
        }
    }

    class Boat : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("The boat is moving!");
        }
    }
}
