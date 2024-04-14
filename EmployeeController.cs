using EmployeeBusiness.Business;
using EmployeeBusiness.Contract;
using EmployeeModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication7.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeBusiness _EmployeeBusiness;
        public EmployeeController(IEmployeeBusiness EmployeeBusiness)
        {
            _EmployeeBusiness = EmployeeBusiness;
        }
        [HttpGet()]
        public IEnumerable<EmployeeMaster> Getemployee()
        {
            var result = _EmployeeBusiness.GetEmployee();
            return result;
        }
    }

    }
