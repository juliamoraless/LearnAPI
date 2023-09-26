using FluentValidation;
using LearnAPI.Domain.Models;

namespace LearnAPI.Domain.Validations
{
    public class StudentValidation: AbstractValidator<Student>
    {
        public StudentValidation() 
        {
            RuleFor(s => s.Name)
                .NotEmpty()
                .WithMessage("O campo {PropertyName} precisa ser fornecido")
                .Length(2, 100)
                .WithMessage("O campo {PropertyName} precisa ter entre {MinLenght} e {MaxLength caracteres}");

            RuleFor(s => s.Document)
                .NotEmpty()
                .WithMessage("O campo {PropertyName} precisa ser fornecido")
                .MaximumLength(12)
                .WithMessage("O campo {PropertyName} precisa ter no máximo {MaxLenght} caracteres");

            RuleFor(s => s.Classroom)
                .NotEmpty()
                .WithMessage("O campo {PropertyName} precisa ser fornecido");
        }

    }
}
