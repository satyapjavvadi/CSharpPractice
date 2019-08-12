using System;
using System.Collections.Generic;
using System.Text;

namespace Practice1
{
    class CoffeeShopwithDowhileLoop
    {
        public static void Test()
        {
            int TotalAmount = 0;
            string UserDecision = string.Empty;
            do
            {
                Console.WriteLine("Please select your coffee size 1-small 2-medium 3-large");
                int UserChoice = int.Parse(Console.ReadLine());
                do
                {
                    switch (UserChoice)
                    {
                        case 1:
                            TotalAmount += 1;
                            break;
                        case 2:
                            TotalAmount += 2;
                            break;
                        case 3:
                            TotalAmount += 3;
                            break;
                        default:
                            Console.WriteLine("Your choice is invalid. Please enter correct choice");
                            break;
                    }
                }while(UserChoice != 1 && UserChoice != 2 && UserChoice != 3);

                do
                {
                    Console.WriteLine("Do you want to buy another coffee - Yes or No?");
                    UserDecision = Console.ReadLine().ToUpper();

                    if (UserDecision != "YES" && UserDecision != "NO")
                    {
                        Console.WriteLine($"Your choice {UserDecision} is invalid. Please enter correct choice");
                    }
                } while (UserDecision != "YES" && UserDecision != "NO");

            } while (UserDecision != "NO");
            Console.WriteLine("Thank you for shopping with us");
            Console.WriteLine($"Your Total amount is {TotalAmount}");
        }
    }
}
