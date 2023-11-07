using FluentValidation;
using FluentValidation.Results;
using LearnAPI.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearnAPI.Application.Notificator;

namespace LearnAPI.Application.Services
{
    public abstract class BaseService
    {
        private readonly INotificator _notificator;

        public BaseService(INotificator notificator)
        {
            _notificator = notificator;
        }
        
        protected void Notificate(ValidationResult validationResult) 
        {
            foreach (var error in validationResult.Errors)
            {
                Notificate(error.ErrorMessage);
            }
        }

        protected void Notificate(string message)
        {
            _notificator.Handle(new Notification(message));
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
