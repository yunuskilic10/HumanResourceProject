using FluentValidation;
using HumanResource.Applications.Models.DTOs.MailDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.Applications.Validators.Login
{
    public class ChangePasswordValidator : AbstractValidator<ChangePasswordDTO>
    {
        public ChangePasswordValidator() 
        {

            RuleFor(x => x.ConfirmCode)
                .Must(BeSixDigits).WithMessage("Confirmation code must be 6 digits.");
        }
        private bool BeSixDigits(int? confirmCode)
        {
            string codeAsString = confirmCode.ToString();
            return codeAsString.Length == 6 && codeAsString.All(char.IsDigit);
        }
    }
}
