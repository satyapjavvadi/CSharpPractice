using System;

namespace Practice1
{
    class TypeConversionTest
    {
        public static void Test()
        {

            // implicit conversion
            int i = 100;
            float f = i;
            Console.WriteLine(f);

            // Explicit conversion
            float f1 = 123.324f;
            int i1 = (int)f1;
           // int i1 = Convert.ToInt32(f1);
            Console.WriteLine(i1);

            //float f2 = 122222222222.3444f;
            //int i2 = (int)f2; it gives the least value of integer as an output
            //int i2 = Convert.ToInt32(f2); it throws an overflow exception while runtime
            // Console.WriteLine(i2);

            // Conversion using parse method

            string str = "100";
            int i5 = int.Parse(str);
            Console.WriteLine(i5);

            string str1 = "100gt";
            int result = 0;
            bool IsConversionTrue = int.TryParse(str1, out result);
            if(IsConversionTrue)
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Please enter a valid number");
            }
        }
    }
}
