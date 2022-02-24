
using System.Threading.Channels;
using Polymorphism;

Company company = new Company();
Employee himal = new PartTimeEmployee("Himal",100,200);
Employee sachin = new FullTimeEmployee("Sachin", 50000);
company.HireNewEmployee(himal);
company.HireNewEmployee(sachin);
Console.WriteLine(company.GetMonthlySalaryTotal());



