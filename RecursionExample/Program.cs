using System;

namespace RecursionExample
{
    class Recursion
    {
        public int FactorialofNumber(int num)
        {
            int result;
            if (num ==1)
            {
                return 1;
            }
            else
            {
                result = FactorialofNumber(num - 1) * num;
                return result;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int a = Convert.ToInt32(Console.ReadLine());
            Recursion r = new Recursion();
            Console.WriteLine($"Factorial of {a} is : {r.FactorialofNumber(a)}");

        }
    }
}
