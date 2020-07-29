using BlazorApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
    public class EmployeeService : IEmployeeService
    {
        private readonly ISqlDataAccess _db;

        public EmployeeService(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<Employee>> GetEmployees()
        {
            string sql = "Select * from dbo.Employee";
            return _db.LoadData<Employee, dynamic>(sql, new { });
        }
        public Task InsertEmployee(Employee employee)
        {
            string sql = @"Insert into dbo.Employee (ID,Name,FatherName,PhoneNo,Email)
                           Values(@ID,@Name,@FatherName,@PhoneNo,@Email)";
            return _db.SaveData(sql, employee);
        }
    }
}
