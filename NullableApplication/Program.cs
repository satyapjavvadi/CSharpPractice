using System;
using System.Collections.Generic;
using System.Linq;

namespace NullableApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            double? num1 = null;
            double? num2 = 4.234;
            double num3;

            num3 = num1 ?? 5.123;
            Console.WriteLine($"Value of num3 : {num3}");

            num3 = num2 ?? 6.123;
            Console.WriteLine($"Value of num3 : {num3}");

            ArrayProgram a = new ArrayProgram();
            a.ArrayPrint();
            
        }
    }

    class ArrayProgram
    {
        public void ArrayPrint()
        {
            int[] numbers = new int[] { 2, 3, 4, 5, 6 };

            string[] names = new string[] { "prasanna", "satya", "Abhi", "Shreya" };
           

          /*  for (i = 0; i < 10; i++)
            {
                n[i] = i + 100;
                Console.WriteLine($"{n[i]}");
            }
            for (j = 0; j < 10; j++)
            {
                Console.WriteLine($"Number[{j}]:, {n[j]}");
            }
            */

            /*for( int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }*/

            foreach ( int num in numbers)
            {
                Console.WriteLine(num);
            }

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            foreach( string name in names)
            {
                Console.Write(name +",");

            }



            List<int> numbers1 = new List<int>();
            numbers1.Add(3);
            numbers1.Add(5);
            numbers1.Add(6);

            Console.WriteLine(numbers1[0]);

            for (int i =0; i < numbers1.Count; i++)
            {
                Console.WriteLine(numbers1[i]);
            }
            numbers1.Add(8);

            var C = numbers1.Count();
            Console.WriteLine(C);

            int[] A = numbers1.ToArray();
            Console.WriteLine(value: A);

            numbers1.Remove(5);

            for (int i = 0; i < numbers1.Count; i++)
            {
                Console.WriteLine(numbers1[i]);
            }
            
            //string s = null;
            //Console.WriteLine(s.Length);
        }
    }
}

