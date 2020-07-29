using BlazorApp.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
    public interface IEmployeeService
    {
        Task<List<Employee>> GetEmployees();
        Task InsertEmployee(Employee employee);
    }
}