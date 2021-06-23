using AutoMapper;

namespace Avanade.Sub.TCSE.Projeto.Application.AutoMapperConfigs.Profiles.EmployeeRole
{
    public class EmployeeRoleProfile : Profile
    {
        public EmployeeRoleProfile()
        {
            CreateMap<Dtos.EmployeeRole.EmployeeRoleDto, SubTCSE.Projeto.Domain.Aggregates.EmployeeRole.Entities.EmployeeRole>()
                  .ForCtorParam("roleName", opt => opt.MapFrom(src => src.Cargo));

            CreateMap<SubTCSE.Projeto.Domain.Aggregates.EmployeeRole.Entities.EmployeeRole, Dtos.EmployeeRole.EmployeeRoleDto>()
                .ForMember(dest => dest.Identificador, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Cargo, opt => opt.MapFrom(src => src.RoleName))
                .ForAllOtherMembers(i => i.Ignore());

        }
    }
}
