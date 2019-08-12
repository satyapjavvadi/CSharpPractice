using System;
namespace Practice1
{
    class ArraysTest
    {
        public static void Test()
        {
            int[] i = new int[5] { 1, 2, 3, 4, 5 };
           /* i[0] = 1;
            i[1] = 2;
            i[2] = 3;
            i[3] = 4;
            i[4] = 5; */

            //Console.WriteLine(i[4]);
       

            for (int a = 0; a < 5; a++)
            {
                Console.Write(i[a]);
            }
        }
    }
}
