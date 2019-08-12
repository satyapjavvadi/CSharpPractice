using System;
//using System.Collections.Generic;
//using System.Text;

namespace Practice1
{
    class MethodTest
    { 
        public int Add(int FN, int SN)
        {
            return FN + SN;
        }

        public static void EvenNumbers(int Target)
        {
            int Start = 0;
            while (Start <= Target)
            {
                Console.WriteLine(Start);
                Start = Start + 2;
            }
        }
    }
}
