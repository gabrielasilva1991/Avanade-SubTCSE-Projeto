using AutoMapper;

namespace Avanade.Sub.TCSE.Projeto.Application.AutoMapperConfigs.Profiles.EmployeeRole
{
    public class EmployeeRoleProfile : Profile
    {
        public EmployeeRoleProfile()
        {
          CreateMap<Dtos.EmployeeRole.EmployeeRoleDto, SubTCSE.Projeto.Domain.Aggregates.EmployeeRole.Entities.EmployeeRole>()
                .ForCtorParam("roleName", opt => opt.MapFrom(src => src.Cargo));
        }
    }
}
