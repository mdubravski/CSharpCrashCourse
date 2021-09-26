using System;

namespace GenericTutorial
{
    class Program
    {
        public static void DisplayElements<T>(T[] array) 
        {
            foreach(T t in array) 
            {
                Console.Write(t + " ");
            }
        }



        static void Main(string[] args)
        {
            // generics =   "not specific to a particular data type"
            //              add <T> to: classes, methods, fields, etc.
            //              allows for code reuseability for different data types

            int[] iArr = { 1, 2, 3 };
            double[] dArr = { 1.0, 2.0, 3.0 };
            String[] sArr = { "1", "2", "3" };

            DisplayElements(iArr);
            DisplayElements(dArr);
            DisplayElements(sArr);

            Console.ReadKey();
        }
    }
}
