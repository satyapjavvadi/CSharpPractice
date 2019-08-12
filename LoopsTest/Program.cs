using System;

namespace LoopsTestbreak
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            while(a<20)
            {
                Console.WriteLine("Value of a is : {0}", a);
                a++;
                if(a>15)
                {
                    break;
                }
            }
        }
    }
}
