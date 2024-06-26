﻿using System.Globalization;

namespace ListaFixacao
{
    class Program
    {
        static void Main()
        {
            List<Employee> list = new List<Employee>();
            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {

                Console.WriteLine("Emplyoee #" + n);
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Employee(id, name, salary));
                Console.WriteLine();

                


            }
            
            Console.Write("Enter the employee id that will have salary increase: ");
            double searchId = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Employee emp = list.Find(x => x.Id == searchId);
            if (emp != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncreaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees");
            foreach (Employee obj in list)
            {
                Console.WriteLine(obj);
                    
            }

            
            
            
        }
    }
}

