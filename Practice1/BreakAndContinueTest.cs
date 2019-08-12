using System;
using System.Collections.Generic;
using System.Text;

namespace Practice1
{
    class BreakAndContinueTest
    {
        // Prints 1 to 10
        public static void Test()
        {
            for (int i=0; i <= 20; i++)
            {
                Console.WriteLine(i);
                if (i == 10)
                    break;  
            }

            // Prints even numbers

            for (int j =0; j <= 20; j++)
            {
                if (j % 2 == 1)
                    continue;

                Console.WriteLine(j);
            }
        }
    }
}
