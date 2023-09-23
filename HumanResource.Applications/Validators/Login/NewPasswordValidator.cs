using FluentValidation;
using HumanResource.Applications.Models.DTOs.MailDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.Applications.Validators.Login
{
    public class NewPasswordValidator:AbstractValidator<NewPasswordDTO>
    {
        public NewPasswordValidator()
        {
            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email is required.")
                .EmailAddress().WithMessage("Please enter a valid email address.");

            RuleFor(x => x.ConfirmCode)
                .NotNull().WithMessage("Confirmation code is required.");

            RuleFor(password => password.Password).NotEmpty().WithMessage("Password is required.")
                .MinimumLength(6).WithMessage("Password must be at least 6 characters long.")
                .Matches("[A-Z]").WithMessage("Password must contain at least one uppercase letter.")
                .Matches("[a-z]").WithMessage("Password must contain at least one lowercase letter.")
                .Matches("[0-9]").WithMessage("Password must contain at least one digit.")
                .Matches("[^a-zA-Z0-9]").WithMessage("Password must contain at least one special character.");


            RuleFor(x => x.ConfirmNewPassword)
                .NotEmpty().WithMessage("Confirm new password is required.")
                .Equal(x => x.Password).WithMessage("Passwords do not match.");

        }
    }
}
