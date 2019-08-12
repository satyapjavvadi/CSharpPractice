using System;
using System.Collections.Generic;

public delegate void HelloFuntionDelegate(string Message);

namespace DelegateTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // A delegate is a type safe function pointer

            HelloFuntionDelegate hd = new HelloFuntionDelegate(Hello);
            hd("Hello from delegate");


            List<Employee> empList = new List<Employee>();

            empList.Add(new Employee() { ID = 101, Name = "John", Salary = 5000, Experience = 5 });
            empList.Add(new Employee() { ID = 102, Name = "Mary", Salary = 4000, Experience = 4 });
            empList.Add(new Employee() { ID = 103, Name = "Sam", Salary = 3000, Experience = 3 });
            empList.Add(new Employee() { ID = 104, Name = "Edward", Salary = 6000, Experience = 6 });
            Employee.PromoteEmployee(empList);



        }

        public static void Hello(string strMessage)
        {
            Console.WriteLine(strMessage);

        }
    }
}
