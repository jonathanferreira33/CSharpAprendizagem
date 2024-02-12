// See https://aka.ms/new-console-template for more information

using Empresa.Entities;
using System.Globalization;

List<object> list = new List<object>();
//int n = int.Parse(Console.ReadLine());

//for (int i = 1; i <= n; i++)
//{
//    Console.WriteLine($"Employee {i} data:");
//    Console.WriteLine($"Outsourced (y/n)?");
//    char c = char.Parse(Console.ReadLine());
//    Console.WriteLine("Name:");
//    string name = Console.ReadLine();
//    Console.WriteLine("Hours: ");
//    int hours = int.Parse(Console.ReadLine());
//    Console.WriteLine("Value per hours: ");
//    double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//    if(c == 'y')
//    {
//        Console.WriteLine("Value additional change: ");
//        double additionalChange = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//        list.Add(new OutsourcedEmployee(name: name, hours: hours, valuePerHours: valuePerHour, additionalChange: additionalChange));
//    }
//    else
//    {
//        list.Add(new Employee(name, hours, valuePerHour));
//    }
//}



Employee employee01 = new Employee("Ingrid", 10, 0.20);
Employee employee02 = new Employee("Catarina", 10, 150.00);
OutsourcedEmployee outEmployee02 = new OutsourcedEmployee("Ferreira", 10, 150.0, 300.0);

list.Add(employee01);
list.Add(employee02);
list.Add(outEmployee02);


Console.WriteLine("Payments:");
foreach (BaseEmployee emp in list)
{
    Console.WriteLine($"{emp.Name} - $ {emp.Payment().ToString("F2", CultureInfo.InvariantCulture)}");
}
