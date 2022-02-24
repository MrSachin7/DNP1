namespace Polymorphism;

public class Company
{
    public List<Employee> AllEmployees { get; set; }

    public Company()
    {
        AllEmployees = new List<Employee>();
    }

    public double GetMonthlySalaryTotal()
    { 
        return AllEmployees.Sum(employee => employee.GetMonthlySalary());
    }

    public void HireNewEmployee(Employee employee)
    {
        AllEmployees.Add(employee);
    }

}