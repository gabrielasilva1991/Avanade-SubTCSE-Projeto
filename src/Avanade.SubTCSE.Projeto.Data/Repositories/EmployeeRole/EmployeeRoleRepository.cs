using Avanade.SubTCSE.Projeto.Infra.Data.Repositories.Base;
using Avanade.SubTCSE.Projeto.Domain.Aggregates.EmployeeRole.Interfaces.Repository;

namespace Avanade.SubTCSE.Projeto.Infra.Data.Repositories.EmployeeRole
{
    public class EmployeeRoleRepository
        : BaseRepository<Domain.Aggregates.EmployeeRole.Entities.EmployeeRole, string>
        , IEmployeeRoleRepository
    {
       
    }
}
