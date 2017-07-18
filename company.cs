using System;
using System.Collections.Generic;

namespace company {
    public class Company
    {
        /*
            Some readonly properties
        */
        public string Name { get; }
        public DateTime CreatedOn { get; }

        // Create a property for holding a list of current employees
        List<Employee> Employees { get; set; }

        // Create a method that allows external code to add an employee
        public void AddEmployee(Employee newEmployee)
        {
            Employees.Add(newEmployee);
        }

        public Company(string name, DateTime createdDate)
        {
            Name = name;
            CreatedOn = createdDate;
        }

        // Create a method that allows external code to remove an employee

        public void ListEmployees()
        {
            foreach (var employee in Employees)
            {
                Console.WriteLine($"{employee.Name} has worked at {Name} as a {employee.JobTitle} since {employee.StartDate}");
            }
        }

        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties
        */
    }
}