using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateTest
{
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set;}
        public static void PromoteEmployee(List<Employee> employeeList)
        {
            foreach(Employee employee in employeeList )
            {
                if (employee.Experience >= 5)
                {
                    Console.WriteLine($"{employee.Name} promoted");
                }
            }
        }
    }
}
