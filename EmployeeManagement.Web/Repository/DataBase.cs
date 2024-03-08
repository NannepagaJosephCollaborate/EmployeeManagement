using EmployeeManagement.Web.Models;

namespace EmployeeManagement.Web.Repository
{
    public class DataBase
    {
        public static List<Employee> Employees { get; } = new();
    }
}
