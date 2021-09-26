using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // interfaces = defiens a "contract" that all the classes inheriting from should follow

            //              an interface declares "what a class should have"
            //              an inheriting  class defines "how it should be used"

            //              Benefit = security + multiple inheritance + "plug and play"

            Rabbit r = new Rabbit();
            Fish f = new Fish();
            Hawk h = new Hawk();
            r.flee();
            f.flee();
            h.hunt();
            f.hunt();

            Console.ReadKey();
        }
    }

    // creating interfaces
    interface IPrey 
    {
        void flee();
    }

    interface IPredator
    {
        void hunt();
    }

    class Rabbit : IPrey
    {
        public void flee()
        {
            Console.WriteLine("The rabbit runs away");
        }
    }

    class Hawk : IPredator
    {
        public void hunt()
        {
            Console.WriteLine("The hawk hunts");
        }
    }

    class Fish : IPrey, IPredator 
    {
        public void flee()
        {
            Console.WriteLine("The fish flees");
        }

        public void hunt() 
        {
            Console.WriteLine("The fish hunts");
        }
    }

}
