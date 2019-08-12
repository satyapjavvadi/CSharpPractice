using System;

namespace LooptestContinue
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            do
            {
                if (a == 15)
                {
                    a += 1;
                    break;
                }
                Console.WriteLine($"Value of a is : {a}");
                a++;
            } while (a < 20);

            while (a < 30)
            {
                Console.WriteLine($"Value of a {a}");
                a++;
            }

            Console.WriteLine("Program done");
        }
    }
}
