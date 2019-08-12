using System;
using System.Collections.Generic;
using System.Text;

namespace Practice1
{
    class DoWhileTest
    {
        public static void Test()
        {
            string UserChoice = string.Empty;
            do
            {
                Console.WriteLine("Please enter your target number");
                int UserTarget = int.Parse(Console.ReadLine());
                int Start = 0;

                while (Start <= UserTarget)
                {
                    Console.WriteLine(Start);
                    Start += 2;
                }


                do
                {
                    Console.WriteLine("Do you want to continue Yes or No?");
                    UserChoice = Console.ReadLine().ToUpper();

                    if (UserChoice != "YES" && UserChoice != "NO")
                    {
                        Console.WriteLine("Invalid choice. Please say Yes or No");
                    }
                } while (UserChoice != "YES" && UserChoice != "NO");
            } while (UserChoice == "YES");
        }
    }
}
