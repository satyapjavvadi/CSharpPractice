using System;
public class NullableTest
{
        public static void Test()
        {
            /* we cannot assign null to value tupes 
             * we can assign null to reference types 
             * to assign null to value types we have to use ? operator
             */
            // int i = 0;
            // string s = null;
            // int? j = null;

            bool? AreyouMajor = null;
            //int? AreyouMajor = null;


            if (AreyouMajor == true)
            {
                Console.WriteLine("User is major");
            }
           else if (AreyouMajor == false)
            //else if (!AreyouMajor.HasValue) 
           // else if (AreyouMajor != true)
         
            {
                Console.WriteLine("User is not major");
            }
            else
            {
                Console.WriteLine("User did not selelct anything");
            }
        }
    }
