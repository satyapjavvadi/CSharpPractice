using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ExceptionHandlingTest
{
    class InnerException
    {
        public static void Test()
        {
            try
            {
                try
                {
                    Console.WriteLine("Enter your first number");
                    int FN = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter your second number");
                    int SN = Convert.ToInt32(Console.ReadLine());
                    int Result = FN / SN;
                    Console.WriteLine($"Result : {Result}");
                }
                catch (Exception ex)
                {
                    string filePath = @"D:\INDU\C#\Log1.txt";
                    if (File.Exists(filePath))
                    {
                        StreamWriter sw = new StreamWriter(filePath);
                        sw.Write(ex.GetType().Name);
                        sw.WriteLine();
                        sw.Write(ex.Message);
                        sw.Close();
                        Console.WriteLine("There is a problem. Please try later");
                    }
                    else
                    {
                        throw new FileNotFoundException($"{filePath} is not present", ex);
                    }
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
