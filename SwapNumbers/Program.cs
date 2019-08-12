using System;

namespace TestValueRefTypes
{
    class Program
    {
        

        static void Main(string[] args)
        {
            NumberManipulator n = new NumberManipulator();
            NumberManipulator m1 = new NumberManipulator();
            NumberManipulator m2 = new NumberManipulator();
            int d = default;
            Console.WriteLine(d);
            int num1 = 100;
            int num2 = 200;
            Console.WriteLine($"Before swapping : a : {num1}, b : {num2}");
            n.Swap(num1, num2);
            Console.WriteLine($"After swapping : a :{num1}, b : {num2}");
            string str1 = "Abhi";
            string str2 = "Shreya";
            Console.WriteLine($"Before swapping strings : string1 : {str1}, string2 : {str2}");
            n.SwapString(str1, str2);
            Console.WriteLine($"After swapping strings : string1 : {str1}, string2 : {str2}");

            int n1 = 100;
            int n2 = n1;
            Console.WriteLine($"n1 : {n1}, n2 : {n2}");
            n2 = 200;
            Console.WriteLine($"n1 : {n1}, n2 :{n2}");

            // string as reference type
            string s1 = "Prasanna";
            string s2 = s1;
            Console.WriteLine($"S1 : {s1}, S2 : {s2}");
            s2 = "Satya";
            Console.WriteLine($"S1 : {s1}, S2 : {s2}");
            m1.Type = "Savings";
            m1.AccountNumber = 1;
            Console.WriteLine($"Type : {m1.Type}, AN : {m1.AccountNumber}");
            m2 = m1;
            Console.WriteLine($"Type : {m2.Type}, AN : {m2.AccountNumber}");

            // Object as reference type
            Account a1 = new Account();
            a1.accountType = "Savings";
            a1.accountNumber = 1;
            Console.WriteLine($"Type1 : {a1.accountType}, AN1 : {a1.accountNumber}");

            Account a2 = a1;
            Console.WriteLine($"Type2 : {a2.accountType}, AN2 : {a2.accountNumber}");

            a2.accountNumber = 2;
            Console.WriteLine($"Account1 : {a1.accountType}, AN2 : {a1.accountNumber}");
            Console.WriteLine($"Account2 : {a2.accountType}, AN1 : {a2.accountNumber}");

            UpdateObject(a1);
            Console.WriteLine($"Account1 : {a1.accountType}, AN2 : {a1.accountNumber}");
            Console.WriteLine($"Account2 : {a2.accountType}, AN1 : {a2.accountNumber}");

            OutParameters p1 = new OutParameters();
            int num = 100;
            Console.WriteLine($"Num : {num}");
            p1.GetValue(out num);
            Console.WriteLine($"Num : {num}");


        }
        static void UpdateObject(Account b)
        {
            b.accountType = "Checking";
        }
    }

    class NumberManipulator
    {
        public string Type;
        public int AccountNumber;
        public void Swap(int a, int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;

        }

        public void SwapString(string s1, string s2)
        {
            String temp;
            temp = s1;
            s1 = s2;
            s2 = temp;
        }
    }

    class Account
    {
        public string accountType;
        public int accountNumber;
    }
    class OutParameters
    {
        public void GetValue(out int a)
        {
            int temp = 5;
            a = temp;
        }
    }

}
