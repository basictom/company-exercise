using System;

namespace company
{
    class Program
    {
        static void Main(string[] args)
        {

            var nss = new Company("Nashville Software School", DateTime.Now);

            var martin = new Employee
            {
                Name = "Martin", 
                JobTitle = "TA", 
                StartDate = DateTime.Parse("7/10/2017")
            };

            nss.AddEmployee(martin);

            Console.WriteLine($"{nss.Name} was created on {nss.CreatedOn}");

        }
    }
}
