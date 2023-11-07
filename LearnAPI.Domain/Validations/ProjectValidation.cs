using FluentValidation;
using LearnAPI.Domain.Models;

namespace LearnAPI.Domain.Validations;

public class ProjectValidation: AbstractValidator<Project>
{
    public ProjectValidation()
    {
        RuleFor(p => p.Name)
            .NotEmpty()
            .WithMessage("O campo {PropertyName} precisa ser fornecido")
            .Length(2, 100)
            .WithMessage("O campo {PropertyName} precisa ter entre {MinLenght} e {MaxLength caracteres}");
        
        RuleFor(p => p.Description)
            .NotEmpty()
            .WithMessage("O campo {PropertyName} precisa ser fornecido")
            .MaximumLength(500)
            .WithMessage("O campo {PropertyName} pode ter no máximo {MaxLength caracteres}");

        RuleFor(p => p.MentorId)
            .NotEmpty();
        
        RuleFor(p => p.ClassroomId)
            .NotEmpty();
    }
    
}