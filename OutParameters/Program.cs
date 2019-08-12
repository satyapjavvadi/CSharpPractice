using System;

namespace OutParameters
{
    class Program
    {
        public void GetValues(out int x, out int y)
        {
            Console.WriteLine("Enter the first value");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second value");
            y = Convert.ToInt32(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            Program p = new Program();

            int a;
            int b;

            p.GetValues(out a, out b);
            Console.WriteLine($"After method call : {a}, {b}");
        
        }
    }
}
