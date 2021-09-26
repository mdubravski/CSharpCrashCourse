﻿using System;

namespace EnumsTutorial
{
    class Program
    {

        public static double Volume(PlanetRadius radius) 
        {
            double volume = (4.0 / 3.0) * Math.PI * Math.Pow((int)radius,3);
            return volume;
        }


        static void Main(string[] args)
        {
            // enums =  special "class" that contains a set of name integer constatns.
            //          Use enums when you have values that you know will not change,
            //          to get the integer value from an item, you must explicitly conbver to an int

            //          name = integer

            //return name of enum
            Console.WriteLine(Planets.Pluto + " is a planet.");

            //return number of enum
            Console.WriteLine(Planets.Mercury + " is planet # " + (int)Planets.Mercury);

            String name = PlanetRadius.Earth.ToString();
            int radius = (int)PlanetRadius.Earth;
            double volume = Volume(PlanetRadius.Earth);
            Console.WriteLine("Planet: "+ name);
            Console.WriteLine("Radius: " + radius);
            Console.WriteLine("Volume: " + volume);

            Console.ReadKey();
        }
    }

    enum Planets 
    {
        Mercury = 1,    
        Venus = 2,      
        Earth = 3,      
        Mars  = 4, 
        Jupiter = 5, 
        Saturn = 6, 
        Uranus = 7, 
        Neptune = 8,
        Pluto = 9
    }

    enum PlanetRadius
    {
        Mercury = 2439,
        Venus = 6051,
        Earth = 6371,
        Mars = 3389,
        Jupiter = 69911,
        Saturn = 58232,
        Uranus = 25362,
        Neptune = 24622,
        Pluto =1188
    }
}
