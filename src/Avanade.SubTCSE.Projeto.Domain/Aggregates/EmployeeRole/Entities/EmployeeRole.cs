namespace Avanade.SubTCSE.Projeto.Domain.Aggregates.EmployeeRole.Entities
{
    public class EmployeeRole
    {
        public EmployeeRole(string id, string roleName)
        {
            Id = id; //ctrl + . - clica em generate constructor abre janela pick members - clica ok
            RoleName = roleName;
        }

        public EmployeeRole(string roleName)
        {
            RoleName = roleName;
        }

        public string Id { get; private set; } //escreve prop e da 2 tab - vai auto completar

        public string RoleName { get; set; }
    }
} //ctrl + k + e identa o código
