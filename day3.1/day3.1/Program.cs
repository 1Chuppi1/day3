using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3._1
{
    class Employee
    {
        public string FullName { get; set; }
        public int Department { get; set; }
        public double Salary { get; set; }
        public int Id { get; private set; }

        private static int counter = 0;
        public Employee(string fullName, int department, double salary)
        {
            FullName = fullName;
            Department = department;
            Salary = salary;

            Id = ++counter;
        }
        public static Employee[] employees = new Employee[10];
        public static void AddEmployee(Employee employee)
        {
            for (int i = 0; i < employees.Length; i++)
            {
                if (employees[i] == null)
                {
                    employees[i] = employee;
                    break;
                }
            }
        }
        public static void PrintAllEmployees()
        {
            foreach (Employee employee in employees)
            {
                if (employee != null)
                {
                    Console.WriteLine("Employee ID: {0}", employee.Id);
                    Console.WriteLine("Full Name: {0}", employee.FullName);
                    Console.WriteLine("Department: {0}", employee.Department);
                    Console.WriteLine("Salary: {0}", employee.Salary);
                    Console.WriteLine();
                }
            }
        }
        public static double GetTotalSalary()
        {
            double totalSalary = 0;

            foreach (Employee employee in employees)
            {
                if (employee != null)
                {
                    totalSalary += employee.Salary;
                }
            }

            return totalSalary;
        }

        public static Employee GetEmployeeWithMinSalary()
        {
            Employee minSalaryEmployee = null;
            double minSalary = double.MaxValue;

            foreach (Employee employee in employees)
            {
                if (employee != null && employee.Salary < minSalary)
                {
                    minSalary = employee.Salary;
                    minSalaryEmployee = employee;
                }
            }

            return minSalaryEmployee;
        }

        public static Employee GetEmployeeWithMaxSalary()
        {
            Employee maxSalaryEmployee = null;
            double maxSalary = double.MinValue;

            foreach (Employee employee in employees)
            {
                if (employee != null && employee.Salary > maxSalary)
                {
                    maxSalary = employee.Salary;
                    maxSalaryEmployee = employee;
                }
            }

            return maxSalaryEmployee;
        }
        public static double GetAvgSalary()
        {
            return GetTotalSalary() / GetNumOfEmployees();
        }

        public static int GetNumOfEmployees()
        {
            int count = 0;

            foreach (Employee employee in employees)
            {
                if (employee != null)
                {
                    count++;
                }
            }

            return count;
        }

        public static void PrintAllFullNames()
        {
            foreach (Employee employee in employees)
            {
                if (employee != null)
                {
                    Console.WriteLine(employee.FullName);
                }
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Employee.AddEmployee(new Employee("блоб джоб", 1, 1000));
                Employee.AddEmployee(new Employee("Курл Чарл", 2, 2000));
                Employee.AddEmployee(new Employee("Хлоп Чек", 3, 3000));
                Employee.AddEmployee(new Employee("Оля Лун", 4, 4000));
                Employee.AddEmployee(new Employee("Вон Там", 5, 5000));

                Employee.PrintAllEmployees();
                Console.WriteLine("Total Salary: {0}", Employee.GetTotalSalary());
                Console.WriteLine("Employee with Min Salary: {0}", Employee.GetEmployeeWithMinSalary().FullName);
                Console.WriteLine("Employee with Max Salary: {0}", Employee.GetEmployeeWithMaxSalary().FullName);
                Console.WriteLine("Average Salary: {0}", Employee.GetAvgSalary());
                Console.WriteLine("Number of Employees: {0}", Employee.GetNumOfEmployees());
                Console.WriteLine("All Full Names:");
                Employee.PrintAllFullNames();


                Console.ReadKey();
            }
        }

    }
}