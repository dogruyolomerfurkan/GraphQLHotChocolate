using GraphQLHotChocolate.Models;

namespace GraphQLHotChocolate.Services;

public interface IEmployeeService
{
    Task<Employee> Create(Employee employee);
    Task<bool> Delete(DeleteVM deleteVM);
    IQueryable<Employee> GetAll();
    IQueryable<Employee> GetById(GetByIdVM getByIdVM);
}
