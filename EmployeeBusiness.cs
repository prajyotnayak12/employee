using EmployeeBusiness.Contract;
using EmployeeModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeBusiness.Business
{
     public class EmployeeBusiness : IEmployeeBussiness
    {
        private List<EmployeeMaster> _employee = new List<EmployeeMaster>;
        public EmployeeBusiness() 
        {
            new EmployeeMaster { EmployeeId = 1, Name = "Manas", Position = "JD", Salary = 60000, JoinDate = new DateTime(2024, 5, 15) };
            new EmployeeMaster { EmployeeId = 2, Name = "Rajat", Position = "Hr", Salary = 55000, JoinDate = new DateTime(2024, 5, 10) };
            new EmployeeMaster { EmployeeId = 3, Name = "Ashutosh", Position = "SD", Salary = 50000, JoinDate = new DateTime(2024, 5, 20) };
            new EmployeeMaster { EmployeeId = 4, Name = "Rakesh", Position = "Marketing", Salary = 48000, JoinDate = new DateTime(2024, 5, 5) };
            new EmployeeMaster { EmployeeId = 5, Name = "Saloni", Position = "Sd", Salary = 52000, JoinDate = new DateTime(2024, 5, 1) };

        }
        public IEnumerable<EmployeeMaster> GetEmployee()
        {
            var result = _employee;
            return result;
        }
    }
}
