using System;

namespace GettersAndSetters
{
    class Program
    {
        static void Main(string[] args)
        {
            // getters & setters =  add security to fields by encapsulation
            //                      They're accessors found within properties

            // properties = combine aspects of both fields and methods (share name with a field)
            // get accessor = used to return tthe property value
            // set accessor = used to assign a meew value
            // value keyword = defiones the value being assigned by the set (parameter)

            Car car = new Car(180);



            car.Speed = 10000000;
            Console.WriteLine(car.Speed);

            Console.ReadKey();
        }
    }

    class Car 
    {
        private int speed;

        public Car(int speed) 
        {
            Speed = speed;
        }

        //property
        public int Speed 
        {
            get { return speed; }   //read
            set                     // write
            {
                speed = value;

                if (value > 500)
                {
                    speed = 500;
                }
                else 
                {
                    speed = value;
                }
                    
            }
        }
    }
}
