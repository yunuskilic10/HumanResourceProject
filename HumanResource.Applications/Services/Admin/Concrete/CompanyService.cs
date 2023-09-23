using AutoMapper;
using HumanResource.Applications.Models.DTOs.AdminDTO;
using HumanResource.Applications.Models.DTOs.PermissonDTO;
using HumanResource.Applications.Models.DTOs.PersonnelDTO;
using HumanResource.Applications.Services.Admin.Abstact;
using HumanResource.Domain.Entities.Concrete;
using HumanResource.Domain.Enums;
using HumanResource.Domain.Repositories.Concrete;
using HumanResource.Infrastructure.Repositories.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.Applications.Services.Admin.Concrete
{
    public class CompanyService : ICompanyService
    {

        private readonly ICompanyRepository companyRepository;
        private readonly IMapper mapper;


        public CompanyService(ICompanyRepository companyRepository, IMapper mapper)
        {
            this.companyRepository = companyRepository;
            this.mapper = mapper;
        }
        public async Task<bool> CreateCompanyPost(AdminAddCompanyDTO model)
        {
            Company company = new Company();
            if (await companyRepository.TaxNoIsThere(model.TaxNo) && await companyRepository.CompanyNameIsThere(model.Name))
            {
                if (model.FoundationDate < model.ContractStartDate)
                {

                    if (model.ContractStartDate <= DateTime.Now && model.ContractEndDate > DateTime.Now)
                    {
                        model.Status = Status.Active;
                        model.MersisNo = $"0{model.TaxNo}00019";
                        model.Email = $"{model.Name}@{model.Name}.com";
                        if (model.FormPhotoFile != null)                                                // Yeni resim seçilmişse
                        {
                            string newFileName = model.FormPhotoFile.FileName;

                            FileStream fs = new FileStream("wwwroot/Logos/" + newFileName, FileMode.Create);
                            await model.FormPhotoFile.CopyToAsync(fs);

                            model.LogoFile = newFileName;
                            company.LogoFile = model.LogoFile;
                        }
                        else if (model.FormPhotoFile == null && !string.IsNullOrEmpty(company.LogoFile))
                        {
                            model.LogoFile = company.LogoFile;                                           // Mevcut resmi koru
                        }
                        mapper.Map(model, company);

                        return await companyRepository.CreateAsync(company);
                    }
                    else
                    {
                        model.Status = Status.Approval;
                        model.MersisNo = $"0{model.TaxNo}00019";
                        if (model.FormPhotoFile != null)                                                // Yeni resim seçilmişse
                        {
                            string newFileName = model.FormPhotoFile.FileName;

                            FileStream fs = new FileStream("wwwroot/Logos/" + newFileName, FileMode.Create);
                            await model.FormPhotoFile.CopyToAsync(fs);

                            model.LogoFile = newFileName;
                            company.LogoFile = model.LogoFile;
                        }
                        else if (model.FormPhotoFile == null && !string.IsNullOrEmpty(company.LogoFile))
                        {
                            model.LogoFile = company.LogoFile;                                           // Mevcut resmi koru
                        }
                        mapper.Map(model, company);
                        return await companyRepository.CreateAsync(company);
                    }
                }
                else
                {
                    throw new Exception("founding date cannot be later than contract start date");

                }
            }
            else
            {
                throw new Exception("The company with the entered tax number or name is registered in the system");
            }
        }

        public Task<AdminDetailCompanyDTO> DetailPost(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<AdminListCompanyDTO>> GetAllCompanies(Expression<Func<AdminListCompanyDTO, bool>> predicate)
        {
            var companyList = await companyRepository.GetAllCompaniesAsync(x => x.Status != Status.Approval);
            var listCompanyDto = mapper.Map<List<AdminListCompanyDTO>>(companyList);
            return listCompanyDto;
        }

        public async Task<Company> GetByIdAsync(int id)
        {
            var company = await companyRepository.GetByIdAsync(id); 
            return company;
        }

        public async Task<AdminDetailCompanyDTO> GetCompanyDetails(int id)
        {
            var company=  await companyRepository.GetCompanyDetailsAsync(id);
            var companyDetailsDto = mapper.Map<AdminDetailCompanyDTO>(company);
            return companyDetailsDto;
        }

        public async Task<ICollection<AdminListCompanyDTO>> GetListCompany()
        {
            var permissionRequestList = await companyRepository.GetAll();
            var listPermissionDTOs = mapper.Map<List<AdminListCompanyDTO>>(permissionRequestList);

            return listPermissionDTOs;
        }
    }
}
