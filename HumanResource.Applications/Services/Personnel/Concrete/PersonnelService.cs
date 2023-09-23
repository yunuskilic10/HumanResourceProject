using AutoMapper;
using HumanResource.Applications.Extensions.MailSender;
using HumanResource.Applications.Extensions.NewEmail;
using HumanResource.Applications.Extensions.NewPassword;
using HumanResource.Applications.Models.DTOs.DemandDTO;
using HumanResource.Applications.Models.DTOs.MailDTO;
using HumanResource.Applications.Models.DTOs.PersonnelDTO;
using HumanResource.Applications.Services.Admin.Concrete;
using HumanResource.Applications.Services.Personnel.Abstract;
using HumanResource.Domain.Entities.Concrete;
using HumanResource.Domain.Enums;
using HumanResource.Domain.Repositories.Abstract;
using HumanResource.Domain.Repositories.Concrete;
using HumanResource.Infrastructure.Repositories.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace HumanResource.Applications.Services.Personnel.Concrete
{
    public class PersonnelService : IPersonnelService
    {
        private readonly IPersonnelRepository personnelRepository;
        private readonly IMapper mapper;
        private readonly UserManager<AppUser> userManager;
        private readonly SignInManager<AppUser> signInManager;
        private readonly ICompanyRepository companyRepository;
        private readonly IJobRepository jobRepository;
        private readonly IDepartmentRepository departmentRepository;

        public PersonnelService(IPersonnelRepository personnelRepository, IMapper mapper, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, ICompanyRepository companyRepository, IJobRepository jobRepository, IDepartmentRepository departmentRepository)
        {
            this.personnelRepository = personnelRepository;
            this.mapper = mapper;
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.companyRepository = companyRepository;
            this.jobRepository = jobRepository;
            this.departmentRepository = departmentRepository;
        }


        public async Task<IdentityResult> CreateCompanyManagerPost(CreateDTO model)
        {
            AppUser appUser = new AppUser();
            Company company = await companyRepository.GetByIdAsync((int)model.CompanyId);

            if (await personnelRepository.UserIdIsThere(model.IdentityNumber) && await personnelRepository.UserMailIsThere(model.PrivateMail) && await personnelRepository.UserPhoneIsThere(model.PhoneNumber))
            {

                if (model.WorkStartDate > model.BirthDate.AddYears(18))
                {
                    if (model.WorkStartDate > company.FoundationDate)
                    {

                        if (model.FormPhotoFile != null)
                        {
                            string newFileName = model.FormPhotoFile.FileName;

                            using (FileStream fs = new FileStream("wwwroot/Pictures/" + newFileName, FileMode.Create))
                            {
                                await model.FormPhotoFile.CopyToAsync(fs);
                            }

                            model.PhotoFile = newFileName;
                            appUser.PhotoFile = model.PhotoFile;
                        }
                        else if (model.FormPhotoFile == null && !string.IsNullOrEmpty(appUser.PhotoFile))
                        {
                            model.PhotoFile = appUser.PhotoFile;
                        }

                        model.Password = PasswordCode.CreatePassword(model.FirstName);

                        model.Email = NewEmail.CreateEmail(model.FirstName, model.SecondName, model.LastName, company.Name);
                        SendMail.CreateMail(model.PrivateMail, "If you have registered the site you should use the mail and password to login.\n\n", model.Password, model.Email);
                        model.Company = company;
                        model.Job = null;

                        model.Status = Status.Active;
                        appUser.UserName = model.Email;
                        appUser.EmailConfirmed = true;

                        mapper.Map(model, appUser);
                        appUser.PasswordHash = userManager.PasswordHasher.HashPassword(appUser, model.Password);

                        var result = await userManager.CreateAsync(appUser, model.Password);

                        if (result.Succeeded)
                        {
                            // Kullanıcı başarıyla oluşturuldu, şimdi rolü ekleyebilirsiniz.
                            await userManager.AddToRoleAsync(appUser, "CompanyManager");
                        }

                        return result;
                    }
                    else
                    {
                        throw new Exception("Work start date must be greater than company foundation date");

                    }
                }
                else
                {
                    throw new Exception("Work start date must be 18 years greater than birth date ");
                }
            }
            else
            {
                throw new Exception("There is a person we are trying to register");

            }



        }


        public async Task<IdentityResult> CreatePersonnelPost(CreateDTO model, int id, int departmentid, int jobid)
        {
            AppUser appUser = new AppUser();

            model.CompanyId = id;
            model.JobId = jobid;
            model.DepartmentId = departmentid;
            Company company = await companyRepository.GetByIdAsync((int)model.CompanyId);
            if (await personnelRepository.UserIdIsThere(model.IdentityNumber) && await personnelRepository.UserMailIsThere(model.PrivateMail) && await personnelRepository.UserPhoneIsThere(model.PhoneNumber))
            {

                if (model.WorkStartDate > model.BirthDate.AddYears(18))
                {
                    if (model.WorkStartDate > company.FoundationDate)
                    {
                        if (model.FormPhotoFile != null)
                        {
                            string newFileName = model.FormPhotoFile.FileName;

                            using (FileStream fs = new FileStream("wwwroot/Pictures/" + newFileName, FileMode.Create))
                            {
                                await model.FormPhotoFile.CopyToAsync(fs);
                            }

                            model.PhotoFile = newFileName;
                            appUser.PhotoFile = model.PhotoFile;
                        }
                        else if (model.FormPhotoFile == null && !string.IsNullOrEmpty(appUser.PhotoFile))
                        {
                            model.PhotoFile = appUser.PhotoFile;
                        }

                        model.Password = PasswordCode.CreatePassword(model.FirstName);

                        Job job = await jobRepository.GetByIdAsync((int)model.JobId);
                        Department department = await departmentRepository.GetByIdAsync((int)model.DepartmentId);

                        model.Email = NewEmail.CreateEmail(model.FirstName, model.SecondName, model.LastName, company.Name);
                        SendMail.CreateMail(model.PrivateMail, "If you have registered the site you should use the mail and password to login.\n\n", model.Password, model.Email);
                        model.Company = company;
                        model.Job = job;
                        model.Department = department;
                        model.Status = Status.Active;

                        appUser.UserName = model.Email;
                        appUser.EmailConfirmed = true;

                        mapper.Map(model, appUser);
                        appUser.PasswordHash = userManager.PasswordHasher.HashPassword(appUser, model.Password);

                        var result = await userManager.CreateAsync(appUser, model.Password);

                        if (result.Succeeded)
                        {
                            // Kullanıcı başarıyla oluşturuldu, şimdi rolü ekleyebilirsiniz.
                            await userManager.AddToRoleAsync(appUser, "Personnel");
                        }

                        return result;
                    }
                    else
                    {
                        throw new Exception("Work start date must be greater than company foundation date");

                    }
                }
                else
                {
                    throw new Exception("Work start date must be 18 years greater than birth date ");
                }
            }
            else
            {
                throw new Exception("There is a person we are trying to register");

            }
        }
        public async Task<DetailDTO> DetailCompanyManagerPost(int id)
        {
            AppUser user = await personnelRepository.FindByIdIncludeDetail(id);
            if (user == null)
            {
                throw new Exception("User not found.");
            }
            else
            {
                DetailDTO detail = new();
                detail.CompanyName = user.Company.Name;
                detail = mapper.Map<DetailDTO>(user);
                return detail;
            }
        }

        public async Task<DetailDTO> DetailPost(int id)
        {
            AppUser user = await personnelRepository.FindByIdIncludeDetail(id);
            if (user == null)
            {
                throw new Exception("User not found.");
            }
            else
            {
                DetailDTO detail = new();
                detail.JobName = user.Job.Name;
                detail.CompanyName = user.Company.Name;
                detail.DepartmentName = user.Department.Name;
                detail = mapper.Map<DetailDTO>(user);
                return detail;
            }
        }

        public async Task<ICollection<ListDTO>> GetCompanyPersonels(int id)
        {
            var personels = await personnelRepository.GetCompanyPersonels(id);
            var listPersonels = mapper.Map<List<ListDTO>>(personels);
            return listPersonels;
        }

        public async Task<ICollection<ListDTO>> GetInRolePersonelList(string rolename)
        {

            var rolePersonels = await personnelRepository.GetCompanyManagerList(rolename);
            var listRolePersonels = mapper.Map<List<ListDTO>>(rolePersonels);
            return listRolePersonels;
        }

        public async Task<ICollection<ListDTO>> GetPersonelJobList(int id, int jobid)
        {
            var personels = await personnelRepository.GetJobPersonellList(id, jobid);
            var listPersonels = mapper.Map<List<ListDTO>>(personels);
            return listPersonels;
        }

        public async Task<ICollection<ListDTO>> GetPersonelList(int id, int departmendId)
        {
            var personels = await personnelRepository.GetDepartmendPersonelList(id, departmendId);
            var listPersonels = mapper.Map<List<ListDTO>>(personels);
            return listPersonels;
        }
        public async Task<SummaryDTO> SummaryCompanyPost(int id)
        {
            AppUser user = await personnelRepository.FindByIdIncludeDetail(id);
            if (user == null)
            {
                throw new Exception("User not found.");
            }
            else
            {
                SummaryDTO summary = new();
                summary.CompanyName = user.Company.Name;
                summary = mapper.Map<SummaryDTO>(user);
                return summary;
            }
        }

        public async Task<SummaryDTO> SummaryPost(int id)
        {
            AppUser user = await personnelRepository.FindByIdIncludeDetail(id);
            if (user == null)
            {
                throw new Exception("User not found.");
            }
            else
            {
                SummaryDTO summary = new();
                summary.JobName = user.Job.Name;
                summary.DepartmentName = user.Department.Name;
                summary.CompanyName = user.Company.Name;
                summary = mapper.Map<SummaryDTO>(user);
                return summary;
            }
        }
        public async Task<UpdateDTO> ManagerUpdate(int id)
        {
            AppUser user = await personnelRepository.FindByIdIncludeDetail(id);
            if (user == null)
            {
                throw new Exception("User not found.");
            }
            else
            {
                UpdateDTO update = new();
                update = mapper.Map<UpdateDTO>(user);
                return update;
            }
        }
        public async Task<UpdateDTO> Update(int id)
        {
            AppUser user = await personnelRepository.FindByIdIncludeDetail(id);
            if (user == null)
            {
                throw new Exception("User not found.");
            }
            else
            {
                UpdateDTO update = new();
                update.JobName = user.Job.Name;
                update = mapper.Map<UpdateDTO>(user);
                return update;
            }
        }

        public async Task<bool> UpdatePost(UpdateDTO model)
        {
            AppUser user = await personnelRepository.FindByIdIncludeDetail(model.Id);               //Degisebilir..
            if (user is not null)
            {
                if (model.FormPhotoFile != null)                                                // Yeni resim seçilmişse
                {
                    string newFileName = model.FormPhotoFile.FileName;

                    FileStream fs = new FileStream("wwwroot/Pictures/" + newFileName, FileMode.Create);
                    await model.FormPhotoFile.CopyToAsync(fs);

                    model.PhotoFile = newFileName;
                    user.PhotoFile = model.PhotoFile;
                }
                else if (model.FormPhotoFile == null && !string.IsNullOrEmpty(user.PhotoFile))
                {
                    model.PhotoFile = user.PhotoFile;                                           // Mevcut resmi koru
                }

                user = mapper.Map<UpdateDTO, AppUser>(model, user);
                return await personnelRepository.UpdateAsync(user);
            }
            else
            {
                throw new Exception("User Not Found");
            }
        }
    }
}
