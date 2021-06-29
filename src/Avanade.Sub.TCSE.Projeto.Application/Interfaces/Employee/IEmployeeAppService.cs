using Avanade.Sub.TCSE.Projeto.Application.Dtos.Employee;
using System.Threading.Tasks;

namespace Avanade.Sub.TCSE.Projeto.Application.Interfaces.Employee
{
    public interface IEmployeeAppService
    {
        Task<EmployeeDto> AddEmployee(EmployeeDto employeeDto);
    }
}
