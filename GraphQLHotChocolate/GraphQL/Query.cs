using GraphQLHotChocolate.Models;
using GraphQLHotChocolate.Services;

namespace GraphQLHotChocolate.GraphQL
{
    public class Query
    {
        private readonly IEmployeeService _employeeService;

        public Query(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        public IQueryable<Employee> Employees => _employeeService.GetAll();
        public IQueryable<Employee> Get(GetByIdVM getByIdVM) => _employeeService.GetById(getByIdVM);

    }
}
