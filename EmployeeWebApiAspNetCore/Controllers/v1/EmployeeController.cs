using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using EmployeeWebApiAspNetCore.Dtos;
using EmployeeWebApiAspNetCore.Entities;
using EmployeeWebApiAspNetCore.Helpers;
using EmployeeWebApiAspNetCore.Services;
using EmployeeWebApiAspNetCore.Repositories;
using System.Text.Json;

namespace EmployeeWebApiAspNetCore.Controllers.v1
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IMapper _mapper;
        
        public EmployeeController(
            IEmployeeRepository employeeRepository,
            IMapper mapper
        )
        {
            _employeeRepository = employeeRepository;
            _mapper = mapper;
        }

        [HttpGet(Name = nameof(GetAllEmployees))]
        public ActionResult GetAllEmployees(
            ApiVersion version
           
        )
        {
            List<EmployeeEntity> employees = _employeeRepository.GetAll().ToList();

            Console.WriteLine(employees);

            return Ok(employees);
        }

        [HttpGet]
        [Route("{id:int}", Name = nameof(GetEmployee))]
        public ActionResult GetEmployee(ApiVersion version, int id)
        {
            EmployeeEntity _employee = _employeeRepository.GetEmployee(id);

            if (_employee == null)
            {
                return NotFound();
            }

            EmployeeDto employeeDto = _mapper.Map<EmployeeDto>(_employee);

            return Ok(employeeDto);
        }

        [HttpPost(Name = nameof(AddEmployee))]
        public ActionResult<EmployeeDto> AddEmployee(
            ApiVersion version,
            [FromBody] EmployeeDto employeeCreateDto
        )
        {
            if (employeeCreateDto == null)
            {
                return BadRequest();
            }

            EmployeeEntity toAdd = _mapper.Map<EmployeeEntity>(employeeCreateDto);

            _employeeRepository.Add(toAdd);

            if (!_employeeRepository.Save())
            {
                throw new Exception("Creating a employee failed on save.");
            }

            EmployeeEntity newEmployeeItem = _employeeRepository.GetEmployee(toAdd.Id);
            EmployeeDto employeeDto = _mapper.Map<EmployeeDto>(newEmployeeItem);

            return CreatedAtRoute(
                nameof(GetEmployee),
                new { version = version.ToString(), id = newEmployeeItem.Id },
                employeeDto
            );
        }
    }
}
