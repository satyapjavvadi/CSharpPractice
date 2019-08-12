using System;
using System.Threading;

namespace ThredingTest
{
    class Program
    {

        static void Main(string[] args)
        {
            /* Synchronous
            //Thread th = Thread.CurrentThread;
            //Console.WriteLine(th);

            //work1();
            //work2();   */

            /* // Asynchronous

             Thread th1 = new Thread(work1);
             Thread th2 = new Thread(work2);
             th1.Start();
             th2.Start();
             */

            Thread mj = new Thread(MethodJoin);
            Thread th1 = new Thread(work1);

            mj.Start();
            th1.Start();
            mj.Join();
            Console.WriteLine("work completed");
            
        }

        static void work1()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"work1 is called {i.ToString()}");
            }
        }
        static void work2()
        {
            for(int i =0; i <= 10; i++)
            {
                Console.WriteLine($"work2 is called {i.ToString()}");
            }
        }
        static void MethodJoin()
        {
            for(int i =0; i <= 10; i++)
            {
                Console.WriteLine("In MethodJoin");
            }
        }
    }
}
