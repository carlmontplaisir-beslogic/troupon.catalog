﻿using FluentValidation;
using Troupon.Catalog.Core.Domain.InputModels;

namespace Troupon.Catalog.Service.Api.Validators
{
    public class CreateDealModelValidator : AbstractValidator<CreateDealModel>
    {
        public CreateDealModelValidator()
        {
            RuleFor(x => x.Major)
                .NotNull()
                .WithMessage("The first name must be at least 2 character long");
            RuleFor(x => x.Minor)
                .MinimumLength(2).
                WithMessage("The first name must be at least 2 character long");

            //RuleFor(x => x.Birthday)
            //    .InclusiveBetween(DateTime.Now.AddYears(-150).Date, DateTime.Now)
            //    .WithMessage("The birthday must not be longer ago than 150 years and can not be in the future");

            //RuleFor(x => x.Age)
            //    .InclusiveBetween(0, 150)
            //    .WithMessage("The minimum age is 0 and the maximum age is 150 years");
        }
    }
}
