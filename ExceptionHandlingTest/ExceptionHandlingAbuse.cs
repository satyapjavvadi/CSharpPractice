using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionHandlingTest
{
    class ExceptionHandlingAbuse
    {
        public void Test()
        {
            try
            {
                Console.WriteLine("Please enter numerator");
                int Numerator = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter denamenator");
                int Denamenator = Convert.ToInt32(Console.ReadLine());

                int Result = Numerator / Denamenator;

                Console.WriteLine($"Result : {Result}");
            }
            catch(FormatException)
            {
                Console.WriteLine("Please enter a number");
            }
            catch(OverflowException)
            {
                Console.WriteLine($"Only numbers between {Int32.MinValue} and {Int32.MaxValue} are allowed");
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Denamenator cannot be zero");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
