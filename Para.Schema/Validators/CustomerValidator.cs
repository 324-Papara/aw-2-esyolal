using FluentValidation;
using Para.Schema;


namespace Para.Data.Validators
{
    public class CustomerValidator : AbstractValidator<CustomerRequest>
    {
        public CustomerValidator()
        {
            RuleFor(customer => customer.FirstName)
                .NotEmpty().WithMessage("First name is required.");

            RuleFor(customer => customer.LastName)
                .NotEmpty().WithMessage("Last name is required.");

            RuleFor(customer => customer.Email)
                .NotEmpty().WithMessage("Email address is required.")
                .EmailAddress().WithMessage("Invalid email address.");

            RuleFor(customer => customer.IdentityNumber)
                .NotEmpty().WithMessage("Identity number is required.")
                .Length(11).WithMessage("Identity number must be 11 characters.");

           RuleFor(x => x.CustomerNumber)
                .NotEmpty()
                .WithMessage("Number is required")
                .InclusiveBetween(1, 10000)
                .WithMessage("Customer number must be between 1-10000");

            RuleFor(customer => customer.DateOfBirth)
                .NotEmpty().WithMessage("Date of birth is required.");
        }
    }
}
