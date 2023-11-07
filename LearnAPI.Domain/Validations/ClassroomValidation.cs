using FluentValidation;
using LearnAPI.Domain.Models;

namespace LearnAPI.Domain.Validations;

public class ClassroomValidation : AbstractValidator<Classroom>
{
    public ClassroomValidation()
    {
        RuleFor(c => c.Name)
            .NotEmpty()
            .WithMessage("O campo {PropertyName} precisa ser fornecido")
            .Length(2, 100)
            .WithMessage("O campo {PropertyName} precisa ter entre {MinLenght} e {MaxLength caracteres}");

        RuleFor(c => c.Turno)
            .NotEmpty()
            .WithMessage("O campo {PropertyName} precisa ser fornecido")
            .Length(5, 12)
            .WithMessage("O campo {PropertyName} precisa ter entre {MinLenght} e {MaxLength caracteres}");
    }
}