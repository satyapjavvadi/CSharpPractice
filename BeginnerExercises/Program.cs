using System;
using System.Collections;
using System.Collections.Generic;

namespace BeginnerExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var b = 2;
            var i = 4;
            var f = 3.245f;
            var c = 'D';
            var s = "Abhi";

            Console.WriteLine($"Byte :{b}");
            Console.WriteLine($"int :{i}");
            Console.WriteLine($"float :{f}");
            Console.WriteLine($"Char : {c}");
            Console.WriteLine($"String :{s}");

            Console.WriteLine($"Byte MinVale :{byte.MinValue},Byte MaxValue :{byte.MaxValue}");
            Console.WriteLine($"float Minvalue :{float.MinValue}, float MaxValue :{float.MaxValue}");
            Console.WriteLine($"int MinValue :{int.MinValue}, int MAxValue :{int.MaxValue}");

            //Implicit conversion

            var by1 = 1;
            var in1 = b;
            Console.WriteLine($"Byte convertes into int :{in1}");

            var in2 = 2;
            var by2 = in2;
            Console.WriteLine($"int converted into byte :{by2}");

            int in3 = 1000;
            byte by3 = (byte)in3;
            Console.WriteLine($"int converted into byte3 : {by3}");

            // Non compatable conversion using exception

            string number = "12345";
            int in4 = Convert.ToInt32(number);
            Console.WriteLine($"String converted into int4 :{in4}");
            try
            {
                var number4 = "1234";
                byte by4 = Convert.ToByte(number4);
                Console.WriteLine($"String converted into byte :{by4}");

            }
            catch
            {
                Console.WriteLine("The number could not be converted to byte");

            }

            //string to boolean conversion

            try
            {
                string str = "true";
                bool b1 = Convert.ToBoolean(str);
                Console.WriteLine($"string converted into boolean :{b1}");

            }
            catch
            {
                Console.WriteLine($"The string could not be converted into boolean");

            }

            // Post increment operator

            int posta = 1;
            int postb = posta++;
            Console.WriteLine($"a :{posta}, b :{postb}");

            // Pre increment opearator

            int prea = 2;
            int preb = ++prea;
            Console.WriteLine($"a :{prea}, b :{preb}");

            // Operators

            var x = 10;
            var y = 3;
            var z = 2;
            Console.WriteLine($"value: {x + y}");
            Console.WriteLine($"Value :{x - y}");
            Console.WriteLine($"Value : {x / y}");
            Console.WriteLine($"Value : {(float)x / y}");
            Console.WriteLine($"Value of x+y*z : {x + y * z}");
            Console.WriteLine($"Value of x+y*z : {(x + y) * z}");
            Console.WriteLine($"x > y : {x > y}");
            Console.WriteLine($"x == y : {x == y}");
            Console.WriteLine($"x != y : {x != y}");
            Console.WriteLine($"!(x != y) : {!(x != y)}");

            // And operator
            Console.WriteLine($"x > y && y > z : {x > y && y > z}");
            Console.WriteLine($"x > y && z > y : {x > y && z > y}");
            Console.WriteLine($"x < y && y > z : {x < y && y > z}");
            Console.WriteLine($"y > x && z > y : {y > x && z > y}");

            // Or operator
            Console.WriteLine($"x > y || y > z : {x > y || y > z}");
            Console.WriteLine($"x > y || z > y : {x > y || z > y}");
            Console.WriteLine($"x < y || y > z : {x < y || y > z}");
            Console.WriteLine($"y > x || z > y : {y > x || z > y}");

            //Arrays

            int[] numbers = new int[3];
            numbers[0] = 101;
            numbers[1] = 102;
            numbers[2] = 103;
          

            foreach (int n in numbers)
            {
                Console.WriteLine(n);
            }

            //Arraylists

            ArrayList arrayList = new ArrayList(3);
            int index = arrayList.Add("Prasanna");
            arrayList.Add(201);
            arrayList.Add(202);       
                      
            foreach(Object obj in arrayList)
            {
                Console.WriteLine(obj.ToString());
            }

            Console.WriteLine(arrayList[index]);

            // Lists

            List<int> intList = new List<int>(3);
            intList.Add(301);
            intList.Add(302);
            intList.Add(303);
            var enumerator = intList.GetEnumerator();

            foreach(int nu1 in intList)
            {
                Console.WriteLine(nu1);
            }

        }
    }
}
