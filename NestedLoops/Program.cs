using System;

namespace NestedLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;

            for ( i = 2; i < 100; i++)
            {
                //for (j = 2; j <= (i / j); j++)
                //{
                //    if ((i % j) == 0)
                //    {
                //        break;
                //    }
                //}

                //if (j > (i / j))
                //{
                //    Console.WriteLine($"{i} is prime");
                //}

                for (j = 2; j <= i/2; j++)
                {
                    if ((i % j) == 0)
                        break;
                }

                if (j > i/2)
                {
                    Console.WriteLine($" {i} is a prime number");
                }
            }

        }
    }
}
