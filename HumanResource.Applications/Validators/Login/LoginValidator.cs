using FluentValidation;
using HumanResource.Applications.Models.DTOs.LoginDTO;
using HumanResource.Applications.Services.Login.Concrete;
using HumanResource.Domain.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.Applications.Validators.Login
{
    public class LoginValidator : AbstractValidator<LoginDTO>
    {
        public LoginValidator()
        {

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email address is required.")
                .Must(SpaceAddress).WithMessage("Email cannot start with a space");

            RuleFor(password => password.Password).NotEmpty().WithMessage("Password is required.");

         
        }

        private bool SpaceAddress(string address)
        {
            if (string.IsNullOrEmpty(address))
            {
                return false;
            }

            return !char.IsWhiteSpace(address[0]) && !string.IsNullOrEmpty(address.Substring(1).Trim());
        }
    }
}
