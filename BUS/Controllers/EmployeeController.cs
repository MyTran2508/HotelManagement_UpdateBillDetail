using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DTO;
using DTO.Entities;

namespace BUS.Controllers
{
    public class EmployeeController
    {
        // Create Employee Instance 
        private Employee CreateEmployee(string Id, string EmployeeName, string Phonenumber, string Address)
        {
            Employee employee = new Employee
            {
                Id = Id,
                Name = EmployeeName,
                Phonenumber = Phonenumber,
                Address = Address
            };
            return employee;
        }

        // Get Employees
        public List<Employee> GetAllEmployees(ref string error)
        {
            using (var context = new Context())
            {
                try
                {
                    var employee = context.Employees.ToList();
                    error = "Get All Employee Success!!!";
                    return employee;
                }
                catch 
                {
                    error = "Sonething Was Wrong When Get Employees!!!";
                    return null;
                }
            }
        }

        // Get Emoloyee By Id
        public Employee GetEmployeeById(string Id, ref string error)
        {
            try
            {
                using (var context = new Context())
                {
                    var employee = context.Employees.
                        Where(emp => emp.Id == Id).FirstOrDefault();
                    if (employee != null)
                    {
                        error = "Get Employee Success!!!";
                    }
                    error = "Employee Is Not Exsit!!!";
                    return employee;
                }
            }
            catch
            {
                error = "Something Was Wrong When Get Employee!!!";
                return null;
            }
        }

        // Insert Employee
        public bool InsertEmployee
        (
            string EmployeeId, 
            string EmployeeName, 
            string PhoneNumber, 
            string Address, 
            ref string error)
        {
            try
            {
                using (var context = new Context())
                {
                   
                    var employee = this.
                        CreateEmployee(EmployeeId, EmployeeName, PhoneNumber, Address);

                    /*var acc = new Account
                    {
                        EmployeeId = EmployeeId,
                        Username = "admin",
                        Password = "1",
                    };
                    employee.Account = acc;*/
                    //var acc = this.GetAccount(EmployeeId, UserName, PassWord);
                    if (employee != null)
                    {
                        context.Employees.Add(employee);
                        context.SaveChanges();
                        error = $"Add Employee Success!!!";
                        return true;
                    }
                    error = "Employee Invalid!!!";
                    return false;
                }
            }
            catch
            {
                error = "Something Was Wrong When Add Employee!!!";
                return false;
            }
        }

        // Remove Employee By Id


        // Update Employee By Id
        public bool UpdateEmployeeById(string Id, string NewEmployeeName, string NewPhoneNumber, string NewAddress, ref string error)
        {
            try
            {
                using (var context = new Context())
                {
                    var employee = context.
                        Employees.SingleOrDefault(e => e.Id == Id);
                    if (employee != null)
                    {
                        employee.Name = NewEmployeeName;
                        employee.Phonenumber = NewPhoneNumber;
                        employee.Address = NewAddress;
                        context.SaveChanges();
                        error = "Update Employee Success!!!";
                        return true;
                    }
                    error = "Employee Is Not Exsit!!!";
                    return false;
                }
            }
            catch
            {
                error = "Something Was Wrong When Update Employee!!!";
                return false;
            }
        }

        public bool Search(string textSearch)
        {
            try
            {
                using (var context = new Context())
                {

                }
            }
            catch
            {

            }
            return false;
        }
    }
}
