using System;

namespace TypeCasting
{
    /*
     * type casting =   Converting a value to a different data type 
     *                  Useful when we accept user input(string)
     *                  Different data types can do different things
     *                  
     *                  
     */


    class Program
    {
        static void Main(string[] args)
        {
            double a = 3.14;
            int b = Convert.ToInt32(a);

            Console.WriteLine(a.GetType());
            Console.WriteLine(b.GetType());

            int c = 1223;
            double d = Convert.ToDouble(c);
            Console.WriteLine(d);
            Console.WriteLine(d.GetType());

            int e = 321;
            String f = Convert.ToString(e);
            Console.WriteLine(f);
            Console.WriteLine(f.GetType());

            String g = "g";
            char h = Convert.ToChar(g);
            Console.WriteLine(h);
            Console.WriteLine(h.GetType());

            String toBool = "true";
            bool myBool = Convert.ToBoolean(toBool);
            Console.WriteLine(myBool);
            Console.WriteLine(myBool.GetType());


            Console.ReadKey();
        }
    }
}
