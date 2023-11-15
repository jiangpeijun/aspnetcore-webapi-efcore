using Microsoft.EntityFrameworkCore;
using WebApiCrud.ConnectionDatabase;
using WebApiCrud.Models;

namespace WebApiCrud.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly DatabaseConnection _con;

        public EmployeeRepository(DatabaseConnection con)
        {
            _con = con;
        }

        public async Task<List<Employee>> GetAll()
        {
            return await _con.Employees.ToListAsync();
        }

        public async Task<Employee> GetById(int id)
        {
            return await _con.Employees.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Employee> Add(Employee emp)
        {
            await _con.Employees.AddAsync(emp);
            await _con.SaveChangesAsync();

            return emp;
        }

        public async Task<Employee> Update(Employee emp, int id)
        {
            var empById = await GetById(id);

            if (empById == null) throw new Exception($"ID {id} not found!");

            empById.Name = emp.Name;
            empById.LastName = emp.LastName;
            empById.Title = emp.Title;

            _con.Employees.Update(empById);
            await _con.SaveChangesAsync();

            return empById;
        }

        public async Task<bool> Delete(int id)
        {
            var empById = await GetById(id);

            if (empById == null) throw new Exception($"ID {id} not found!");

            _con.Employees.Remove(empById);
            await _con.SaveChangesAsync();

            return true;
        }

    }
}
