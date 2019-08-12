using System;
using System.Collections.Generic;
using System.Text;

namespace Practice1
{
    class ForLoopTest
    {
        public static void Test()
        {
            int[] Numbers = new int[3];
            Numbers[0] = 100;
            Numbers[1] = 101;
            Numbers[2] = 102;
            int i = 0;
            while (i < Numbers.Length)
            {
                Console.WriteLine(Numbers[i]);
                i++;
            }

            for (int j = 0; j < Numbers.Length; j++)
            {
                Console.WriteLine(Numbers[j]);
            }

            foreach (int k in Numbers)
            {
                Console.WriteLine(k);
            }
        }
    }
}
