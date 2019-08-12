using System;

namespace Practice1
{
    class CoffeshopTest
    {
        public static void Test()
        {
            int TotalAmount = 0;
            Start:
            Console.WriteLine("Please select your coffee size: 1 - Small, 2 - Medium, 3 - Large");
            int UserChoice = int.Parse(Console.ReadLine());
            switch(UserChoice)
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
                    Console.WriteLine($"Your choice {UserChoice} is invalid");
                    goto Start;
            }
            Decide:
            Console.WriteLine("Do you want to buy another coffee- Yes or No?");
            string UserDecision = Console.ReadLine();
            switch (UserDecision.ToUpper())
            {
                case "YES":
                    goto Start;
                case "NO":
                    break;
                default :
                    Console.WriteLine("Your choice is invalid. Please try again");
                        goto Decide;

            }
            Console.WriteLine("Thank you for shopping with us");
            Console.WriteLine($"Your total amount is : {TotalAmount}");
        }
    }
}
