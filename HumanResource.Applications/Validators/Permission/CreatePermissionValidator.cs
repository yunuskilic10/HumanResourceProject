using FluentValidation;
using HumanResource.Applications.Models.DTOs.AdvanceDTO;
using HumanResource.Applications.Models.DTOs.PermissonDTO;
using HumanResource.Domain.Entities.Concrete;
using HumanResource.Domain.Enums;
using Org.BouncyCastle.Math.EC.Rfc7748;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.Applications.Validators.Permission
{
    public class CreatePermissionValidator : AbstractValidator<CreatePermissionDTO>
    {
        public CreatePermissionValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Description is required.").
             MinimumLength(5).WithMessage("Description must be at least 5 characters.").
             MaximumLength(200).WithMessage("Description must be maximum length 200 characters.");

            RuleFor(x => x.FinishDate).NotEmpty().WithMessage("Finish date is required.").Must((model, finishDate) => !finishDate.HasValue || !model.BeginingDate.HasValue || finishDate > model.BeginingDate).WithMessage("Finish date must be greater than begining date.").Must(date => date >= DateTime.Today.AddDays(1)).WithMessage("Finish date must be greater than begining date.");
            RuleFor(x => x.BeginingDate).NotEmpty().WithMessage("Beginning date is required.").Must(date => date >= DateTime.Today.AddDays(1)).WithMessage("You can request leave as early as tomorrow.");



            //RuleFor(x => x.FinishDate)
            //    .NotEmpty().WithMessage("Finish date is required.");
            //.Must((demand, finishDate) => BeWithinMaximumDaysForMale(demand.MalePermissionType, demand.BeginingDate, finishDate))
            //.WithMessage("Invalid leave type or permission period.");

            //RuleFor(x => x.BeginingDate)
            //    .NotEmpty().WithMessage("Beginning date is required");
            //    .Must((demand, finishDate) => BeWithinMaximumDaysForFemale(demand.FemalePermissionType, demand.BeginingDate, finishDate))
            //    .WithMessage("Invalid leave type or permission period.");


            RuleFor(x => x.FemalePermissionType).Must((x, value) =>
        {

            if (x.FemalePermissionType == FemalePermissionType.SicknessandSickLeave && (int)(x.FinishDate.Value - x.BeginingDate.Value).TotalDays >21)
            {
                return false;
            }
            return true;
        }).WithMessage("Maximum 20 days of sick leave can be granted.");




            RuleFor(x => x.MalePermissionType).Must((x, value) =>
            {

                if (x.MalePermissionType == MalePermissionType.SicknessandSickLeave && (int)(x.FinishDate.Value - x.BeginingDate.Value).TotalDays > 20)
                {
                    return false;
                }

                return true;
            }).WithMessage("Maximum 20 days of sick leave can be granted.");


            RuleFor(x => x.MalePermissionType).Must((x, value) =>
            {

                if (x.MalePermissionType == MalePermissionType.PaternityLeave && (int)(x.FinishDate.Value - x.BeginingDate.Value).TotalDays > 5)
                {
                    return false;
                }
                return true;
            }).WithMessage("Maximum 5 days of sick leave can be granted.");

            RuleFor(x => x.MalePermissionType).Must((x, value) =>
            {



                if (x.MalePermissionType == MalePermissionType.MarriageLeave && (int)(x.FinishDate.Value - x.BeginingDate.Value).TotalDays > 5)
                {
                    return false;
                }

                return true;
            }).WithMessage("Maximum 5 days of sick leave can be granted.");

            RuleFor(x => x.MalePermissionType).Must((x, value) =>
            {

                if (x.MalePermissionType == MalePermissionType.BereavementLeave && (int)(x.FinishDate.Value - x.BeginingDate.Value).TotalDays > 7 || x.FinishDate == null || x.BeginingDate == null)
                {
                    return false;
                }
                return true;
            }).WithMessage("Maximum 7 days of sick leave can be granted.");

            RuleFor(x => x.FemalePermissionType).Must((x, value) =>
            {

                if (x.FemalePermissionType == FemalePermissionType.MaternityLeave && (int)(x.FinishDate.Value - x.BeginingDate.Value).TotalDays > 15)
                {
                    return false;
                }
                return true;
            }).WithMessage("Maximum 15 days of sick leave can be granted.");


            RuleFor(x => x.FemalePermissionType).Must((x, value) =>
            {

                if (x.FemalePermissionType == FemalePermissionType.MarriageLeave && (int)(x.FinishDate.Value - x.BeginingDate.Value).TotalDays > 5)
                {
                    return false;
                }
                return true;
            }).WithMessage("Maximum 5 days of sick leave can be granted.");


            RuleFor(x => x.FemalePermissionType).Must((x, value) =>
            {

                if (x.FemalePermissionType == FemalePermissionType.BereavementLeave && (int)(x.FinishDate.Value - x.BeginingDate.Value).TotalDays > 7)
                {
                    return false;
                }
                return true;
            }).WithMessage("Maximum 7 days of sick leave can be granted.");




        }
        //private bool BeWithinMaximumDaysForMale(MalePermissionType? type, DateTime? beginDate, DateTime? finishDate)
        //{
        //    if (type.HasValue && beginDate.HasValue && finishDate.HasValue)
        //    {
        //        return type switch
        //        {
        //            //MalePermissionType.PaternityLeave => (finishDate.Value - beginDate.Value).Days <= 5,
        //            //MalePermissionType.MarriageLeave => (finishDate.Value - beginDate.Value).Days <= 5,
        //            //MalePermissionType.BereavementLeave => (finishDate.Value - beginDate.Value).Days <= 7,
        //            //MalePermissionType.SicknessandSickLeave => (finishDate.Value - beginDate.Value).Days <= 20,

        //            _ => true,
        //        };
        //    }
        //    return true;


        //}

        //private bool BeWithinMaximumDaysForFemale(FemalePermissionType? type, DateTime? beginDate, DateTime? finishDate)
        //{
        //    if (type.HasValue && beginDate.HasValue && finishDate.HasValue)
        //    {
        //        return type switch
        //        {
        //            FemalePermissionType.MaternityLeave => (finishDate.Value - beginDate.Value).Days <= 15,
        //            //FemalePermissionType.SicknessandSickLeave => (finishDate.Value - beginDate.Value).Days <= 20,
        //            FemalePermissionType.BereavementLeave => (finishDate.Value - beginDate.Value).Days <= 7,
        //            FemalePermissionType.MarriageLeave => (finishDate.Value - beginDate.Value).Days <= 5,

        //            _ => true,
        //        };
        //    }
        //    return true;
        //}
    }
}
