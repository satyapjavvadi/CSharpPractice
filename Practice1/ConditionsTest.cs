using System;

namespace Practice1
{
    class ConditionsTest
    {
        public static void Test()
        {
            Console.WriteLine("Please enter a number");
            int UserName = int.Parse(Console.ReadLine());

            if (UserName == 1)
            {
                Console.WriteLine("Your number is one");
            }
            else if (UserName == 2)
            {
                Console.WriteLine("Your number is two");
            }
            else if (UserName == 3)
            {
                Console.WriteLine("Your number is three");
            }
            else
            {
                Console.WriteLine("Your number is not between 1 and 3");
            }

            Console.WriteLine("Please enter another number");
            int anumber = int.Parse(Console.ReadLine());

            if (anumber == 10 || anumber == 20)
            {
                Console.WriteLine("Your number is 10 or 20");
            }
            else
            {
                Console.WriteLine("Your number is not either 10 or 20");
            }
        }
    }
}
