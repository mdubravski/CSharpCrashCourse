using System;
using System.Threading;

namespace MultiThreadingTutorial
{
    class Program
    {
        public static void CountUp(String name) 
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Timer #2: "+i+" seconds");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Timer #2 Complete!");
        }

        public static void CountDown(String name) 
        {
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine("Timer #1: "+i+" seconds");
                Thread.Sleep(1000); // 1000 ms = 1 s
            }
            Console.WriteLine("Timer #1 Complete!");
        }


        static void Main(string[] args)
        {
            // thread = an execution path of a program
            //          We can use multiple threads to perform,
            //          different tasks of out program at the same time.
            //          Current thread running is "main" thread
            //          using System.Threading;

            // get main thread
            Thread mainThread = Thread.CurrentThread;
            mainThread.Name = "Main Thread";

            // making new threads using lambda expressions to pass parameters
            Thread thread1 = new Thread(() => CountDown("Count Down"));
            Thread thread2 = new Thread(() => CountUp("Count Up"));

            // start threads
            thread1.Start();
            thread2.Start();

            Console.WriteLine(mainThread.Name+ " is Complete!");





            Console.ReadKey();
        }
    }
}
