using GraphQLHotChocolate.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphQLHotChocolate.Services;

public class EmployeeService : IEmployeeService
{
    private readonly DatabaseContext _dbContext;

    public EmployeeService(DatabaseContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Employee> Create(Employee employee)
    {
        var newEmployee = new Employee
        {
            Id = employee.Id,
            Name = employee.Name,
            Designation = employee.Designation
        };
        await _dbContext.Employees.AddAsync(newEmployee);
        await _dbContext.SaveChangesAsync();
        return newEmployee;
    }

    public async Task<bool> Delete(DeleteVM deleteVM)
    {
        var employee = await _dbContext.Employees.FirstOrDefaultAsync(p => p.Id == deleteVM.Id);
        if (employee is not null)
        {
            _dbContext.Employees.Remove(employee);
            await _dbContext.SaveChangesAsync();
            return true;
        }
        return false;
    }

    public IQueryable<Employee> GetAll()
    {
        return _dbContext.Employees.AsQueryable();
    }

    public IQueryable<Employee> GetById(GetByIdVM getByIdVM)
    {
        return _dbContext.Employees.Where(p => p.Id == getByIdVM.Id).AsQueryable();
    }
}
