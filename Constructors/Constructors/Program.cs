using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            // constructor =    A special method in a class
            //                  Same name as the class name
            //                  Can be used to assign arguments to fields when creating an object
            //
            // overloaded constructors =    techinque to create multiple constructors,
            //                              with a different set of parameters.
            //                              name + parameters = signature

            Human human1 = new Human("Rick", 65);
            Human human2 = new Human("Morty", 16);

            human1.Eat();
            human2.Sleep();

            Car c1 = new Car("Ford", "F150", 2019, "grey");
            c1.Drive();

            Console.ReadKey();
        }

    }

    class Human
    {
        public string name;
        public int age;
        public double height;

        // constructor
        public Human(String name, int age)
        {
            this.name = name;
            this.age = age;
        }

        // overloaded constructor
        public Human(String name, int age, double height)
        {
            this.name = name;
            this.age = age;
            this.height = height;
        }

        public void Eat()
        {
            Console.WriteLine(name + " is eating.");
        }

        public void Sleep()
        {
            Console.WriteLine(name + " is sleeping.");
        }



    }

    class Car
    {
        string make;
        string model;
        int year;
        string color;

        // constructor
        public Car(string make, string model, int year, string color) 
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.color = color;
        }

        // overloaded constructor
        public Car(string make, string model, int year)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            color = null;
        }

        public void Drive() 
        {
            Console.WriteLine("You drive the "+color+" "+make+" "+model+" "+year);
        }
    }
}
