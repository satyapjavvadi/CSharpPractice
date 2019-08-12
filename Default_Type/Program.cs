using System;

namespace Default_Type
{
    class Program
    {
        static void Main()
        {
            short a;
            int b;
            double c;

            a = 10;
            b = 20;
            c = a + b;

            string s1 = "prasanna";
            string s2 = "satya";
            string s3 = "\"C#\"";
            string s4 = @"""C#""";

            Console.WriteLine($"String1:, {s1} String2:, {s2} String3:, {s3} String4:, {s4}");

            string str = @"Tutorials point";
            Console.WriteLine(str);
            
            Console.WriteLine("a={0}, b={1}, c={2}", a, b, c);
            Console.ReadKey();
      
        }
    }
}
