using System;

namespace ToStringTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // ToString() = converts an object to its string representation so that it is suitable to display

            Car car = new Car("F150", "Ford", 2019, "grey");


            // both of these call the ToString Method
            Console.WriteLine(car.ToString());
            Console.WriteLine(car);



            Console.ReadKey();
        }
    }

    class Car
    {
        string make;
        string model;
        int year;
        string color;

        public Car(string make, string model, int year, string color) 
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.color = color;
        }

        public override string ToString()
        {
            String s = make +" "+ model+ " " + year+" "+color+"\n";
            return s;
        }

    }
}
