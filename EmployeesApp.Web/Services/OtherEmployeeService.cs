using EmployeesApp.Web.Models;

namespace EmployeesApp.Web.Services;

public class OtherEmployeeService : IEmployeeService
{
    readonly List<Employee> employees = new List<Employee>();

    public void Add(Employee employee)
    {
        employee.Id = employees.Count == 0 ? 1 : employees.Max(e => e.Id) + 1;
        employees.Add(employee);
    }

    public Employee[] GetAll() => [.. employees.OrderBy(e => e.Name)];

    public Employee GetById(int id) => employees
        .Single(e => e.Id == id);

    public bool CheckIsVIP(Employee employee) =>
        employee.Email.StartsWith("host", StringComparison.CurrentCultureIgnoreCase);
}
