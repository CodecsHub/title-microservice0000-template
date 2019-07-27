using FluentValidation;
using Microservice00001TemplateAPI.DataAccessLayers;
using Microservice00001TemplateAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservice00001TemplateAPI.Validators
{
    public class ActivityValidator : AbstractValidator<IIV1ActivityPost>
    {
        public ActivityValidator()
        {
            RuleFor(p => p.ActionName)
                .Cascade(CascadeMode.StopOnFirstFailure) // verfiy and one error only and will not continue the validations
                .NotEmpty().WithMessage("Empty {PropertyName} please provide")
                .Length(2,50).WithMessage("the minimum lenght is {TotalLength}2, and the maximum charater is 50")
                .Must(BeAValideAction).WithMessage("Invalid {PropertyName}");

            RuleFor(p => p.SystemName)
                .Cascade(CascadeMode.StopOnFirstFailure) // verfiy and one error only and will not continue the validations
                .NotEmpty().WithMessage("Empty {PropertyName} please provide")
                .Length(2, 50).WithMessage("the minimum lenght is {TotalLength}2, and the maximum charater is 50")
                .Must(BeAValideAction).WithMessage("Invalid {PropertyName}");
        }

        protected bool BeAValideAction(string actionName)
        {
            actionName = actionName.Replace(" ","");
            actionName = actionName.Replace("-", "");

            return actionName.All(Char.IsLetter);
        }
    }
}
