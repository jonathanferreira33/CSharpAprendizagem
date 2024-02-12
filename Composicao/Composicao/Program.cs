using Composicao.Entities;
using Composicao.Entities.Enums;
using System;
using System.Collections.Generic;

namespace Composicao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string deptName = "TI";
            string name = "Jonathan";
            WorkerLevel level = Enum.Parse<WorkerLevel>("MidLevel") ;
            double baseSalary = 720.50;

            Department dept = new Department(deptName);
            Worker worker = new Worker(name, level, baseSalary, dept);

            worker.AddContract(new HourContract(new DateTime(2021, 5, 30), 40.00, 40));                
            worker.AddContract(new HourContract(new DateTime(2020, 7, 22), 35.00, 20));                
            worker.AddContract(new HourContract(new DateTime(2019, 11, 30), 70.00, 50));
            worker.AddContract(new HourContract(new DateTime(2019, 11, 1), 25.00, 80));

            Console.WriteLine("Enter month and year to calculate income (MM/yyyy) ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));
            Console.WriteLine($"Name: {worker.Name} \nDepartment: {worker.Departament.Name} \nIncome for {monthAndYear} = {worker.Income(year, month)} ");
        }
    }
}