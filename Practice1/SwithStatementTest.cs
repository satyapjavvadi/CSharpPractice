using System;

namespace Practice1
{
    class SwithStatementTest
    {
        public static void Test()
        {
            Console.WriteLine("Please enter a number");
            int UserName = int.Parse(Console.ReadLine());

            switch(UserName)
            {
                /* case 10:
                     Console.WriteLine("Your number is 10");
                     break;
                 case 20:
                     Console.WriteLine("Your number is 20");
                     break;
                 case 30:
                     Console.WriteLine("Your number is 30");
                     break;
                 default:
                     Console.WriteLine("Your number is not 10, 20 or 30");
                         break;   */
                case 10:
                case 20:
                case 30:
                    Console.WriteLine($"Your number is : {UserName}");
                    break;
                default:
                    Console.WriteLine("Your number is not 10, 20 or 30");
                    break;

            }
        }
    }
}
