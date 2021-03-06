using Avanade.SubTCSE.Projeto.Domain.Aggregates.EmployeeRole.Validators;
using FluentValidation;

namespace Avanade.SubTCSE.Projeto.Domain.Aggregates.Employee.Validators
{
    public class EmployeeValidator : AbstractValidator<Entities.Employee>
    {
        public EmployeeValidator()
        {
            RuleSet("new", () =>
            {
                RuleFor(e => e.FirstName)
                .NotEmpty()
                .WithMessage("{PropetyName} can not be empyt");

                RuleFor(e => e.SurName)
                .NotEmpty()
                .WithMessage("{PropetyName} can not be empyt");

                RuleFor(e => e.EmployeeRole)
                .SetValidator(new EmployeeRoleValidator());
            });
        }
    }
}
