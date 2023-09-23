using FluentValidation;
using HumanResource.Applications.Models.DTOs.AdvanceDTO;
using HumanResource.Applications.Models.DTOs.DemandDTO;
using HumanResource.Domain.Entities.Concrete;
using HumanResource.Domain.Enums;
using Org.BouncyCastle.Math.EC.Rfc7748;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HumanResource.Applications.Validators.Advance
{
    public class CreateAdvanceValidator : AbstractValidator<CreateAdvanceDTO>
    {
        public CreateAdvanceValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Description is required").
              MinimumLength(5).WithMessage("Description must be at least 5 characters").
              MaximumLength(200).WithMessage("Description must be maximum length 200 characters");

            RuleFor(x => x.Price)
              .NotEmpty().WithMessage("Field is required.")
               .Must(ContainsOnlyDecimal2).WithMessage("Amount must be digits.");

            RuleFor(x => x.Price).GreaterThanOrEqualTo(5000).WithMessage("You should take an advance min 5000");

            RuleFor(x => x.Price).Must((model, price) => MaxInstitutionalPrice(model.AdvanceType, price)).WithMessage("you should take an advance max 1000000");
        }
        private bool ContainsOnlyDecimal2(decimal price)
        {
            string input = price.ToString();
            if (string.IsNullOrWhiteSpace(input))
            {
                return false;
            }
            string pattern = @"^\d+(\.\d+)?$";

            return Regex.IsMatch(input, pattern);
        }

        private bool MaxInstitutionalPrice(AdvanceType advanceType, decimal price)
        {
            if (advanceType == AdvanceType.Institutional)
            {
                return price <= 1000000;
            }
            return true;
        }
    }
}
