using FluentValidation;
using FluentValidation.Results;
using LearnAPI.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnAPI.Application.Services
{
    public abstract class Service
    {
        protected void Notificate(ValidationResult validationResult) 
        {
            foreach (var error in validationResult.Errors)
            {
                Notificate(error.ErrorMessage);
            }
        }

        protected void Notificate(string message)
        {
            //Propagar esse erro até a camada de apresentação
        }

        protected bool ExecuteValidation<TV, TE>(TV validation, TE entity) where TV : AbstractValidator<TE> where TE: BaseEntity
        {
            var validator = validation.Validate(entity);

            if (validator.IsValid) return true;

            Notificate(validator);
            return false;
        }
    }
}
