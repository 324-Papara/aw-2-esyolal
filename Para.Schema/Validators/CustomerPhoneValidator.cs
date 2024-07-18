using FluentValidation;
using Para.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Para.Bussiness.Validations
{
    public class CustomerPhoneValidator : AbstractValidator<CustomerPhoneRequest>
    {
        public CustomerPhoneValidator()
        {
            RuleFor(x => x.CountyCode)
                .NotEmpty()
                .WithMessage("Country code is required")
                .MaximumLength(3)
                .WithMessage("Country code must be up to 3 characters long");

            RuleFor(x => x.Phone)
                .NotEmpty()
                .WithMessage("Phone number is required")
                .MaximumLength(10)
                .WithMessage("Phone number must be up to 10 characters long");
        }
    }
}
