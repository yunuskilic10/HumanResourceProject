using FluentValidation;
using HumanResource.Applications.Models.DTOs.AdminDTO;
using HumanResource.Applications.Models.DTOs.DemandDTO;
using HumanResource.Applications.Validators.CustomValidator;
using HumanResource.Applications.Validators.Personnel;
using Microsoft.AspNetCore.Http;
using Org.BouncyCastle.Asn1.Cms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HumanResource.Applications.Validators.Company
{
    public class CompanyCreateValidator : AbstractValidator<AdminAddCompanyDTO>
    {
        public CompanyCreateValidator()
        {
            RuleFor(x => x.TelephoneNumber).NotEmpty().WithMessage("Please enter Phone Number")
                                       .MinimumLength(10).WithMessage("Please enter at least 10 digit Phone Number")
                                       .MaximumLength(15).WithMessage("Please enter at least 10 digit Phone Number");

            RuleFor(x => x.TaxNo).NotEmpty().WithMessage("Please enter Tax No")
                                      .MinimumLength(10).WithMessage("Please enter at least 10 digit Tax No ")
                                      .MaximumLength(10).WithMessage("Please enter at least 10 digit Tax No")
                                      .Must(IsValidIdentityNumber).WithMessage("Please enter Tax No is Digit");

            RuleFor(x => x.Name).NotEmpty().WithMessage("Please enter  Name")
                                            .MinimumLength(2).WithMessage("Please enter at least 2 characters")
                                            .MaximumLength(15).WithMessage("Please enter an Name with maximum 15 characters")
                                            .Must(SpaceAddress).WithMessage("First name cannot start with a space and must have characters after");


            RuleFor(x => x.Address).NotEmpty().WithMessage("Please enter Address")
                                            .MinimumLength(10).WithMessage("Please enter at least 10 characters")
                                            .MaximumLength(200).WithMessage("Please enter an Address with maximum 200 characters")
                                            .Must(SpaceAddress).WithMessage("Address cannot start with a space and must have characters after");
           

            RuleFor(x => x.FormPhotoFile).NotEmpty().WithMessage("Please upload Logo").NotNull().WithMessage("Please upload Logo").Must(PhotoFileControl).WithMessage("Logo extension must be format {.jpg/.png/.jpeg} & Maximum Size 5 MB");
          
        }

        private bool IsValidIdentityNumber(string identityNumber)
        {
            if (string.IsNullOrWhiteSpace(identityNumber))
            {
                return false;
            }
            string pattern = @"^\d{10}$";
            return Regex.IsMatch(identityNumber, pattern);
        }

        private bool PhotoFileControl(IFormFile photo)
        {
            if (photo == null || photo.Length == 0)
            {
                return true;
            }
            var allowedExtensions = new[] { ".jpg", ".jpeg", ".png" };
            var maxFileSize = 5 * 1024 * 1024;
            var fileExtension = Path.GetExtension(photo.FileName)?.ToLowerInvariant();

            if (string.IsNullOrEmpty(fileExtension) || !allowedExtensions.Contains(fileExtension))
            {
                return false;
            }
            if (photo.Length > maxFileSize)
            {
                return false;
            }

            return true;
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
