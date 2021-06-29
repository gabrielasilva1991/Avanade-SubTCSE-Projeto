using Avanade.Sub.TCSE.Projeto.Application.Dtos.EmployeeRole;
using System.Threading.Tasks;

namespace Avanade.Sub.TCSE.Projeto.Application.Interfaces.EmployeeRole
{
    public interface IEmployeeRoleAppService
    {
       Task<EmployeeRoleDto> AddEmployeeRole(EmployeeRoleDto employeeRoleDto);
    }
}
