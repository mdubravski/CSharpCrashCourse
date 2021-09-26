using System;

namespace ArrayOfObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car("F150");
            Car c2 = new Car("Corvette");
            Car c3 = new Car("BMW");

            Car[] cars = { c1, c2, c3 };

            // anonymous objects
            Car[] garage = { new Car("F150"), new Car("Corvette"), new Car("BMW") };

            foreach (Car c in cars) 
            {
                Console.WriteLine(c.model);
            }

            Console.ReadKey();
        }
    }

    class Car 
    {
        public string model;

       public Car(string model) 
        {
            this.model = model;
        }
    }
}
