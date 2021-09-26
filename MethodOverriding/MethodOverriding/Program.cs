using System;

namespace MethodOverriding
{
    class Program
    {
        static void Main(string[] args)
        {
            // method overriding =  provides a new version of a method inherited from a parent class
            //                      inherited method must be: abstract, virtual, or already overridden
            //                      use with ToString(), polymorphism

            Dog dog = new Dog();
            Cat cat = new Cat();

            dog.Speak();
            cat.Speak();

            Console.ReadKey();
        }
    }

    class Animal
    {
        public virtual void Speak() 
        {
            Console.WriteLine("The animal makes a noise");
        }
    }

    class Dog : Animal 
    {
        // overridden method
        public override void Speak() 
        {
            Console.WriteLine("the dog barks");
        }
    }

    class Cat : Animal 
    {

        // overridden method
        public override void Speak() 
        {
            Console.WriteLine("the cat meows");
        }
    }

}
