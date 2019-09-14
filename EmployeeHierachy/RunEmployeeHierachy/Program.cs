using System;

using EmployeeHierachy;

namespace RunEmployeeHierachy
{
    class Program
    {
        static void Main(string[] args)
        {
            Employees employee = new Employees(
                "john,manager1,100" +
                "\n" +
                "peter,manager1," +
                "1900\ngidraf,manager2,100" +
                "\n" +
                "orenja,manager3,1900" +
                "\nCEO,,1000 \n " +
                "manager1,CEO,1900" +
                "\n" +
                "manager3,CEO,1900\nsalasia,manager1,1900\nmanager2,CEO,1900");

            int budget =  employee.managerSalaryBudget("manager3");

            Console.WriteLine(budget);
        }
    }
}
