using System.Diagnostics;

namespace Polymorphism;

public abstract class Employee
{
    public string Name;

    public Employee(string name)
    {
        this.Name = name;
    }

    public abstract double GetMonthlySalary();
}