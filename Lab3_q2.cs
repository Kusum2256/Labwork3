using System;
using System.Collections.Generic;
using System.Linq;

namespace Labwork
{
    internal class Lab3_q2
    {
        class Employee
        {
            public string Name { get; set; }
            public string Address { get; set; }
            public int Salary { get; set; }
        }

       /* static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee { Name = "Kusum", Address = "Kathmandu", Salary = 60000 },
                new Employee { Name = "Rita", Address = "Lalitpur", Salary = 45000 },
                new Employee { Name = "Sita", Address = "Kathmandu", Salary = 52000 }
            };*

            var result = from e in employees
                         where e.Salary > 50000 && e.Address == "Kathmandu"
                         select e;

            foreach (var emp in result)
            {
                Console.WriteLine($"{emp.Name} - {emp.Address} - {emp.Salary}");
            }
        }*/
    }
}

