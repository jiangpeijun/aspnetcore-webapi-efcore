using Microsoft.AspNetCore.Mvc;
using WebApiCrud.Models;
using WebApiCrud.Repositories;

namespace WebApiCrud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _repository;

        public EmployeeController(IEmployeeRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<List<Employee>>> Get()
        {
            var list = await _repository.GetAll();
            return Ok(list);
        }

        [HttpGet("getById/{id}")]
        public async Task<ActionResult<Employee>> GetById(int id)
        {
            var emp = await _repository.GetById(id);
            return Ok(emp);
        }

        [HttpPost]
        public async Task<ActionResult<Employee>> Post([FromBody] Employee Employee)
        {
            var add = await _repository.Add(Employee);
            return Ok(add);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Employee>> Put([FromBody] Employee Employee, int id)
        {
            Employee.Id = id;
            var update = await _repository.Update(Employee, id);
            return Ok(update);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Employee>> Delete(int id)
        {
            var status = await _repository.Delete(id);
            return Ok(status);
        }
    }
}
