using System;
using System.IO;
namespace ExceptionHandlingTest
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader st = null;
            try
            {
                st = new StreamReader(@"D:\INDU\C#\Data1.txt");
                Console.WriteLine(st.ReadToEnd());
                st.Close();
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine($"Please check the file {ex.FileName} exists");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (st != null)
                {
                    st.Close();
                }
                Console.WriteLine("In finally block");
            }
            // InnerException.Test();
            //throw new FileNotFoundException("File XYZ is not found");
            /* CustomExceptions ce = new CustomExceptions();
             ce.Test();

            // UserAlreadyLoggedInException UE = new UserAlreadyLoggedInException(); */
            ExceptionHandlingAbuse ea = new ExceptionHandlingAbuse();
            ea.Test();
        }
    }
}
