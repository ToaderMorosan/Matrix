using AutoMapper;
using Matrix.Services;
using Matrix.Helpers;
using Matrix.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Matrix.Entities;

namespace Matrix.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly ISkillMatrixRepository _skillMatrixRepository;
        private readonly IMapper _mapper;

        public EmployeesController(ISkillMatrixRepository skillMatrixRepository, IMapper mapper)
        {
            _skillMatrixRepository = skillMatrixRepository ??
                throw new ArgumentNullException(nameof(skillMatrixRepository));
            _mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));
        }
        [HttpGet("")]
        public IActionResult GetEmployees()
        {
            var employeesFromRepo = _skillMatrixRepository.GetEmployees();

            return Ok(_mapper.Map<IEnumerable<EmployeeDto>>(employeesFromRepo));
        }

        [HttpGet("{employeeId}", Name ="GetEmployee")]
        public IActionResult GetEmployee(Guid employeeId)
        {
            var employeeFromRepo = _skillMatrixRepository.GetEmployee(employeeId);
            if (employeeFromRepo == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<EmployeeDto>(employeeFromRepo));
        }

        [HttpPost]
        public ActionResult<EmployeeDto> CreateEmployee(EmployeeForCreationDto employee)
        {
            var employeeEntity = _mapper.Map<Entities.Employee>(employee);
            _skillMatrixRepository.AddEmployee(employeeEntity);
            _skillMatrixRepository.Save();
            var employeeToReturn = _mapper.Map<EmployeeDto>(employeeEntity);
            return CreatedAtRoute("GetEmployee",
                new { employeeId = employeeToReturn.Id },
                employeeToReturn);
        }


        [HttpDelete("{employeeId}")]
        public ActionResult DeleteEmployee(Guid employeeId)
        {
            var employeeFromRepo = _skillMatrixRepository.GetEmployee(employeeId);

            if (employeeFromRepo == null)
            {
                return NotFound();
            }

            _skillMatrixRepository.DeleteEmployee(employeeFromRepo);

            _skillMatrixRepository.Save();

            return NoContent();
        }




    }
}
