using FluentValidation;
using Para.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Para.Bussiness.Validations
{
    public class CustomerAddressValidator : AbstractValidator<CustomerAddressRequest>
    {
        public CustomerAddressValidator()
        {
            RuleFor(x => x.Country)
                .NotEmpty()
                .WithMessage("Country is required")
                .Length(1, 25)
                .WithMessage("Country must be 1-25 characters!");

            RuleFor(x => x.City)
                .NotEmpty()
                .WithMessage("City is required")
                .Length(1, 50)
                .WithMessage("City must be 1-50 characters!");

            RuleFor(x => x.AddressLine)
                .NotEmpty()
                .WithMessage("Address line is required")
                .MaximumLength(150)
                .WithMessage("Adress line maximum length 150 characters!");

            RuleFor(x => x.ZipCode)
                .NotEmpty()
                .WithMessage("Zip code is required")
                .Length(6)
                .WithMessage("Zip code must be 6 characters!");
        }
    }
}
