using System;

namespace ReferenceParameters
{
    class SwapReference
    {
        
        public void SwapRefer(ref int a, ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
        }
        static void Main(string[] args)
        {
            int x = 100;
            int y = 200;
            Console.WriteLine($"Before Swapping a: {x}, b :{y}");
            SwapReference r = new SwapReference();
            r.SwapRefer(ref x, ref y);
            Console.WriteLine($"After Swapping a: {x}, b: {y}");

            int? num1 = null;
            int? num2 = 45;
            double? num3 = new double?();
            double? num4 = 3.141517;

            bool? boolval = new bool?();
            Console.WriteLine($"N1 : {num1}, N2 : {num2}, N3 : {num3}, N4 : {num4}, Bool : {boolval}");
        }
    }
}
