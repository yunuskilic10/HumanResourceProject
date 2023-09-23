using FluentValidation;
using HumanResource.Applications.Models.DTOs.PersonnelDTO;
using HumanResource.Applications.Validators.CustomValidator;
using HumanResource.Domain.Enums;
using Microsoft.AspNetCore.Http;
using Org.BouncyCastle.Asn1.Cms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HumanResource.Applications.Validators.Personnel
{
    public class PersonnelCreateValidator : AbstractValidator<CreateDTO>
    {
        CustomEmailValidationAttribute attribute = new CustomEmailValidationAttribute();
        public PersonnelCreateValidator()
        {
            RuleFor(x => x.PhoneNumber).NotEmpty().WithMessage("Please enter Phone Number")
                                       .MinimumLength(10).WithMessage("Please enter at least 10 digit Phone Number")
                                       .MaximumLength(15).WithMessage("Please enter at least 10 digit Phone Number");

            RuleFor(x => x.IdentityNumber).NotEmpty().WithMessage("Please enter Identity Number")
                                      .MinimumLength(11).WithMessage("Please enter at least 11 digit Identity Number")
                                      .MaximumLength(11).WithMessage("Please enter at least 11 digit Identity Number")
                                      .Must(IsValidIdentityNumber).WithMessage("Please enter Identity Number is Digit");

            RuleFor(x => x.FirstName).NotEmpty().WithMessage("Please enter First Name")
                                            .MinimumLength(2).WithMessage("Please enter at least 2 characters")
                                            .MaximumLength(15).WithMessage("Please enter an Name with maximum 15 characters")
                                            .Must(SpaceAddress).WithMessage("First name cannot start with a space and must have characters after");

            RuleFor(x => x.LastName).NotEmpty().WithMessage("Please enter Last Name")
                                            .MinimumLength(2).WithMessage("Please enter at least 2 characters")
                                            .MaximumLength(25).WithMessage("Please enter an Last Name with maximum 25 characters")
                                            .Must(SpaceAddress).WithMessage("First name cannot start with a space and must have characters after");

            RuleFor(x => x.SecondLastName).MinimumLength(2).WithMessage("Please enter at least 2 characters")
                                            .MaximumLength(25).WithMessage("Please enter an Last Name with maximum 25 characters");

            RuleFor(x => x.SecondName).MinimumLength(2).WithMessage("Please enter at least 2 characters")
                                            .MaximumLength(15).WithMessage("Please enter an Second Name with maximum 15 characters");
                                           

            RuleFor(x => x.Address).NotEmpty().WithMessage("Please enter Address")
                                            .MinimumLength(5).WithMessage("Please enter at least 10 characters")
                                            .MaximumLength(200).WithMessage("Please enter an Address with maximum 200 characters")
                                            .Must(SpaceAddress).WithMessage("Address cannot start with a space and must have characters after");
            RuleFor(x => x.BirthCity).NotEmpty().WithMessage("Please enter City")
                                            .MinimumLength(3).WithMessage("Please enter at least 3 characters")
                                            .MaximumLength(20).WithMessage("Please enter an Birth City with maximum 20 characters")
                                            .Must(SpaceAddress).WithMessage("Address cannot start with a space and must have characters after");
            RuleFor(x => x.Salary).NotEmpty().WithMessage("Please enter salary")
                                            .InclusiveBetween(11400, 9999999).WithMessage("Minimum salary must be 11400 ₺");
            RuleFor(x => x.BirthDate).Must((x) =>
            {

                if (x > DateTime.Now.AddYears(-18))
                {
                    return false;
                }
                return true;
            })
              .WithMessage("Person can not be under 18 years of age")
             .Must((x) =>
            {

                if (x < DateTime.Now.AddYears(-65))
                {
                    return false;
                }
                return true;
            }).WithMessage("Person can not be older than 65 years of age");


            RuleFor(x=>x.WorkStartDate)
             .Must((x) =>
             {

                 if (x < DateTime.Now.AddYears(-65))
                 {
                     return false;
                 }
                 return true;
             }).WithMessage("An person cannot work for 65 years."); 


            RuleFor(x => x.FormPhotoFile).Must(PhotoFileControl).WithMessage("Photo extension must be format {.jpg/.png/.jpeg} & Maximum Size 5 MB");

            RuleFor(x => x.PrivateMail).NotEmpty().WithMessage("Please enter Mail").EmailAddress().WithMessage("Invalid email address format.")
          .Custom((email, context) =>
          {
              if (!attribute.IsValid(email))
              {
                  context.AddFailure("Email", "Invalid email format.");
              }
          });


        }

        private bool IsValidIdentityNumber(string identityNumber)
        {
            if (string.IsNullOrWhiteSpace(identityNumber))
            {
                return false;
            }
            string pattern = @"^\d{11}$";
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
