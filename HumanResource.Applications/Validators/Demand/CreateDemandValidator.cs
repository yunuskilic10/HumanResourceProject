using FluentValidation;
using HumanResource.Applications.Models.DTOs.DemandDTO;
using HumanResource.Domain.Enums;
using Microsoft.AspNetCore.Http;
using Org.BouncyCastle.Math.EC.Rfc7748;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HumanResource.Applications.Validators.Demand
{
    public class CreateDemandValidator : AbstractValidator<CreateDemandDTO>
    {

        public CreateDemandValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Description is required").
                MinimumLength(5).WithMessage("Description must be at least 5 characters").
                MaximumLength(200).WithMessage("Description must be maximum length 200 characters");

            RuleFor(x => x.SalaryDemandAmount)
              .NotEmpty().WithMessage("Field is required.")
               .Must(ContainsOnlyDecimal).WithMessage("Amount must be digits.");

            RuleFor(x => x.DemandFile).Must(PhotoFileControl).WithMessage("File extension must be format {.jpg/.png/.jpeg/.pdf} & Maximum Size 5 MB")
                .NotEmpty().WithMessage("File is required");

            
            RuleFor(demand => demand.SalaryDemandAmount)
    .Must((demand, salary) =>
    {
        if (demand.DemandType == DemandType.Trip)
        {
            if ((salary > 500 && salary <= 5000 && demand.Currency == Currency.TL) ||
                (salary > 100 && salary <= 1000 && demand.Currency == Currency.DOLLAR) ||
                (salary > 90 && salary <= 900 && demand.Currency == Currency.EURO))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else if (demand.DemandType == DemandType.Accommodation)
        {
            if ((salary > 1000 && salary <= 10000 && demand.Currency == Currency.TL) ||
                (salary > 200 && salary <= 2000 && demand.Currency == Currency.DOLLAR) ||
                (salary > 300 && salary <= 3000 && demand.Currency == Currency.EURO))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else if (demand.DemandType == DemandType.Food)
        {
            if ((salary > 50 && salary <= 450 && demand.Currency == Currency.TL) ||
                (salary > 10 && salary <= 100 && demand.Currency == Currency.DOLLAR) ||
                (salary > 15 && salary <= 150 && demand.Currency == Currency.EURO))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else if (demand.DemandType == DemandType.Other)
        {
            if ((salary > 1000 && salary <= 6000 && demand.Currency == Currency.TL) ||
                (salary > 100 && salary <= 800 && demand.Currency == Currency.DOLLAR) ||
                (salary > 90 && salary <= 1000 && demand.Currency == Currency.EURO))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        return false;
    })
    .WithMessage((demand, salary) =>
    {
        if (demand.DemandType == DemandType.Trip)
        {
            if (demand.Currency == Currency.TL)
            {
                return "Salary should be between 500 and 5000 TL for Food demand.";
            }
            else if (demand.Currency == Currency.DOLLAR)
            {
                return "Salary should be between 100 and 1000 dollars for Food demand.";
            }
            else if (demand.Currency == Currency.EURO)
            {
                return "Salary should be between 90 and 900 euros for Food demand.";
            }
        }
        else if (demand.DemandType == DemandType.Accommodation)
        {
            if (demand.Currency == Currency.TL)
            {
                return "Salary should be between 1000 and 10000 TL for Food demand.";
            }
            else if (demand.Currency == Currency.DOLLAR)
            {
                return "Salary should be between 200 and 2000 dollars for Food demand.";
            }
            else if (demand.Currency == Currency.EURO)
            {
                return "Salary should be between 300 and 3000 euros for Food demand.";
            }
        }
        else if (demand.DemandType == DemandType.Food)
        {
            if (demand.Currency == Currency.TL)
            {
                return "Salary should be between 50 and 450 TL for Food demand.";
            }
            else if (demand.Currency == Currency.DOLLAR)
            {
                return "Salary should be between 10 and 100 dollars for Food demand.";
            }
            else if (demand.Currency == Currency.EURO)
            {
                return "Salary should be between 15 and 150 euros for Food demand.";
            }
        }
        else 
        {
            if (demand.Currency == Currency.TL) 
            {
                return "Salary should be between 1000 and 6000 TL for Other demand.";
            }
            else if (demand.Currency == Currency.DOLLAR)
            {
                return "Salary should be between 100 and 800 dollars for Other demand.";
            }
            else if (demand.Currency == Currency.EURO)
            {
                return "Salary should be between 90 and 1000 euros for Other demand.";
            }
        }

        return "Invalid salary range for the specified demand type and currency.";
    });

        }



        private bool ContainsOnlyDecimal(decimal? salary)
        {
            string input = salary.ToString();
            if (string.IsNullOrWhiteSpace(input))
            {
                return false;
            }
            string pattern = @"^\d+(\.\d+)?$";

            return Regex.IsMatch(input, pattern);
        }

        private bool PhotoFileControl(IFormFile photo)
        {
            if (photo != null)
            {
                var allowedExtensions = new[] { ".jpg", ".jpeg", ".png", ".pdf" };
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
            return false;
        }
    }
}
