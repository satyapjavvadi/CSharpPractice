using Practice1;
using System;

class Program
{
    static void Main()
    {
        /*Console.WriteLine("Please enter your First name :");
        string FirstName = Console.ReadLine();

        Console.WriteLine("Pease enter your Last name");
        string LastName = Console.ReadLine();

        //Console.WriteLine("Hello" + UserName);
        //Console.WriteLine("Hello{0}", UserName);
        Console.WriteLine($"Hello,{FirstName},{LastName}"); */

        /* int i = 0;
        Console.WriteLine($"Max :{ int.MaxValue}");
        Console.WriteLine($"Min :{int.MinValue}");  */

        // float fl = 4.5f;
        // Console.WriteLine(fl);
        // double d = 3.2444;
        // Console.WriteLine(d);

        /* //String types

         string str = "\"Prasanna \n Satya \n Abhi \n Shreya\"";
         Console.WriteLine(str);
         string str1 = "C:\\programs\\downloads\\indu";
         Console.WriteLine(str1);
         string str2 = @"C:\programs\downloads\indu";
         Console.WriteLine(str2);
         */

        /* // operators

         int n = 10;
         int d = 2;
         int q = n / d;
         Console.WriteLine($"Quotient : {q}");

         int r = n % d;
         Console.WriteLine($"Remainder : {r}");

         int a1 = 10;
         int a2 = 22;

         if (a1 ==10 && a2==20)
         {
             Console.WriteLine("Hello");
         }

         int a3 = 20;
         int a4 = 10;

         if (a3 == 20 || a4 == 30)
         {
             Console.WriteLine("Hi");
         }
         */

        /* // Ternary operator

         int a5 = 10;
         bool a6;

         if (a5 == 10)
         {
             a6 = true;
         }
         else
         {
             a6 = false;
         }

         Console.WriteLine(a6);

         bool a7 = a5 == 10 ? true : false;

         Console.WriteLine(a7);
         */

        // Nullable types
        // NullableTest.Test();
        // Nullcoalescingtest.Test();
        // TypeConversionTest.Test();
        //  ArraysTest.Test();
        // ConditionsTest.Test();
        //SwithStatementTest.Test();
        //CoffeshopTest.Test();
        // WhileLoopTest.Test();
        // DoWhileTest.Test();
        //CoffeeShopwithDowhileLoop.Test();
        //ForLoopTest.Test();
        //BreakAndContinueTest.Test();
        /* MethodTest t = new MethodTest();
         MethodTest.EvenNumbers(20);
         int Total = t.Add(10, 20);
         Console.WriteLine(Total);*/

        ValueTypeTest V = new ValueTypeTest();
    }
}