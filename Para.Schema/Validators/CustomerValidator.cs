using FluentValidation;
namespace Para.Schema.Validators
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

            RuleFor(customer => customer.DateOfBirth)
                .NotEmpty().WithMessage("Date of birth is required.");
        }
    }
}
