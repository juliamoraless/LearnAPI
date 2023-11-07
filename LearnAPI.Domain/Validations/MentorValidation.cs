using FluentValidation;
using LearnAPI.Domain.Models;

namespace LearnAPI.Domain.Validations;

public class MentorValidation: AbstractValidator<Mentor>
{
    public MentorValidation()
    {
        RuleFor(m=>m.Name)
            .NotEmpty()
            .WithMessage("O campo {PropertyName} precisa ser fornecido")
            .Length(2, 100)
            .WithMessage("O campo {PropertyName} precisa ter entre {MinLenght} e {MaxLength caracteres}");

        RuleFor(m => m.ClassroomId)
            .NotEmpty();
    }
}