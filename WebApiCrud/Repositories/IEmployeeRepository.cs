using WebApiCrud.Models;

namespace WebApiCrud.Repositories
{
    public interface IEmployeeRepository
    {
        Task<List<Employee>> GetAll();

        Task<Employee> GetById(int id);

        Task<Employee> Add(Employee emp);

        Task<Employee> Update(Employee emp, int id);

        Task<bool> Delete(int id);
    }
}
