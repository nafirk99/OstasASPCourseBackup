using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime BirthDate { get; set; }
        public List<Employee> Employees { get; set;}
        public Employee() 
        { 
            Employees = new List<Employee>();
        }

        public static List<Employee> GetEmployee()
        {
            List<Employee> listOfEmployee = new List<Employee>();
            Random random = new Random();
            for (int i = 0; i<50; i++)
            {
                
                Employee employee = new Employee();
                employee.Name = "Employee-" + i.ToString();
                int a = random.Next(21,50);
                employee.Age =a; 
                employee.BirthDate = DateTime.Now;
                listOfEmployee.Add(employee);
            }
            return listOfEmployee;
        }
    }
}