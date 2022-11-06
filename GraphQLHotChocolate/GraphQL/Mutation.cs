using GraphQLHotChocolate.Models;
using GraphQLHotChocolate.Services;

namespace GraphQLHotChocolate.GraphQL
{
    public class Mutation
    {
        private readonly IEmployeeService _employeeService;

        public Mutation(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        public async Task<Employee> Create(Employee employee) => await _employeeService.Create(employee);
        public async Task<bool> Delete(DeleteVM deleteVM) => await _employeeService.Delete(deleteVM);

    }
}
