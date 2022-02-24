namespace Polymorphism;

public class PartTimeEmployee : Employee
{
    public double HourlyWage { get; set; }
    public int HoursPerMonth { get; set; }


    public override double GetMonthlySalary()
    {
        return HourlyWage * HoursPerMonth;
    }

    public PartTimeEmployee(string name) : base(name)
    {
    }


    public PartTimeEmployee(string name, double hourlyWage, int hoursPerMonth) : base(name)
    {
        this.HourlyWage = hourlyWage;
        this.HoursPerMonth = hoursPerMonth;
    }
}