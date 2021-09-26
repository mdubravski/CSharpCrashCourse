using System;

namespace MultiDimensionalArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // multidimensional array = array of arrays

            String[,] parkingLot = { { "f150", "mustang", "corvette" }, 
                                    { "forrester", "explorer", "ranger" }, 
                                    { "silverado", "camero", "corolla" } };

            parkingLot[0, 1] = "civic";

            foreach (String s in parkingLot) 
            {
                Console.WriteLine(s);
            }

            for (int i = 0; i < parkingLot.GetLength(0); i++) 
            {
                for (int j = 0; j < parkingLot.GetLength(1); j++)
                {
                    Console.Write(parkingLot[i,j] + " ");
                }
                Console.WriteLine();
            }
            {

            }
        }
    }
}
