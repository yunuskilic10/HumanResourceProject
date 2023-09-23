using FluentValidation;
using HumanResource.Applications.Models.DTOs.MailDTO;
using HumanResource.Applications.Validators.CustomValidator;
using Org.BouncyCastle.Asn1.Cms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.Applications.Validators.Login
{
    public class MailValidator:AbstractValidator<MailDTO>
    {
        CustomEmailValidationAttribute attribute = new CustomEmailValidationAttribute();
        public MailValidator()
        {
            RuleFor(x => x.Email)
            .Custom((email, context) =>
            {
                if (!attribute.IsValid(email))
                {
                    context.AddFailure("Email", "Invalid email format.");
                }
            });
        }
    }
}
