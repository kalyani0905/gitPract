using System;
using System.Collections.Generic;

namespace GitPract
{
    class Program
    {
        static void Main(string[]args)
        {
            Employee employee = new Employee{Id= 1001, Name= "kalyani", Salary = 99000};
            Console.WriteLine(employee);

            List<Employee> employees = new List<Employee>{
            new Employee{Id = 1002, Name = "Sujana", Salary = 98000.00},
    new Employee{Id= 1003, Name= "Mounika", Salary = 96000.00}
    
};
foreach(Employee emp in employees)
Console.WriteLine(emp);
    }g
}