using System;

namespace RecursionPractice
{
    class Program
    {
        //Summation of a given number
        public static int Summation(int n)
        {
            //Base case
            if (n <= 0)
            {
                return n;
            }
            //Recursive case
            else
            {
                return n + Summation(n - 1);
            }
        }

        public static int Factorial(int n)
        {
            //Base case
            if (n <= 1)
            {
                return 1;
            }
            // recursive case
            else
            {
                return n * Factorial(n - 1);
            }
        }

        public static int FactorialIterative(int n)
        {
            int result = 1;
            while (n != 1)
            {
                result = result * n;
                n = n - 1;
            }
            return result;
        }

        public static int Exponentiation(int n, int p)
        {
            //Base case
            if (p <= 0)
            {
                return 1;
            }
            //recursive case
            else
            {
                return n * Exponentiation(n, p - 1);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Summation(3));
            Console.WriteLine(Factorial(5));
            Console.WriteLine(FactorialIterative(5));
            Console.WriteLine(Exponentiation(5, 3));
        }
    }
}
