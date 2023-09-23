using FluentValidation;
using HumanResource.Applications.Models.DTOs.PersonnelDTO;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.Applications.Validators.Personnel
{
	public class PersonnelUpdateValidator : AbstractValidator<UpdateDTO>
	{
		public PersonnelUpdateValidator()
		{
			RuleFor(x => x.PhoneNumber).NotEmpty().WithMessage("Please enter Phone Number")
									   .MinimumLength(10).WithMessage("Please enter at least 10 digit Phone Number")
									   .MaximumLength(15).WithMessage("Please enter at least 10 digit Phone Number");
									   


			RuleFor(x => x.Address).NotEmpty().WithMessage("Please enter Address")
											.MinimumLength(10).WithMessage("Please enter at least 10 characters")
											.MaximumLength(200).WithMessage("Please enter an Address with maximum 200 characters")
											.Must(SpaceAddress).WithMessage("Address cannot start with a space and must have characters after");

			RuleFor(x => x.FormPhotoFile).Must(PhotoFileControl).WithMessage("Photo extension must be format {.jpg/.png/.jpeg} & Maximum Size 5 MB");
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
