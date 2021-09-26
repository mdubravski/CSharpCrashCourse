using System;

namespace Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            // object = An instance of a class
            //          A class can be used as a blueprint to create objects (OOP)
            //          objects can have fields anda methods (characteristics and actions)



            Human human1 = new Human();
            Human human2 = new Human();
            human1.name = "Rick";
            human1.age = 50;

            human2.name = "Morty";
            human2.age = 16;

            human1.Eat();
            human1.Sleeping();

            human2.Eat();
            human2.Sleeping();

            Console.ReadKey();
        }
    }

    class Human 
    {
        // fields
        public String name;
        public int age;


        // methods
        public void Eat() 
        {
            Console.WriteLine(name + " is eating.");
        }

        public void Sleeping()
        {
            Console.WriteLine(name + " is sleeping.");
        }
    }
}
