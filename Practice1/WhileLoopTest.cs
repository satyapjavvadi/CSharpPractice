using System;
using System.Collections.Generic;
using System.Text;

namespace Practice1
{
    class WhileLoopTest
    {
        public static void Test()
        {
            Console.WriteLine("Please enter your target number");
            int UserTarget = int.Parse(Console.ReadLine());
            int Start = 0;
            while(Start <= UserTarget)
            {
                Console.Write(Start +" ");
                Start = Start + 2;
            }

        }
    }
}
