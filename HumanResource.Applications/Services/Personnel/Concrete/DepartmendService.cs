using AutoMapper;
using HumanResource.Applications.Models.DTOs.DemandDTO;
using HumanResource.Applications.Models.DTOs.DepartmendDTO;
using HumanResource.Applications.Services.Personnel.Abstract;
using HumanResource.Domain.Entities.Concrete;
using HumanResource.Domain.Enums;
using HumanResource.Domain.Repositories.Abstract;
using HumanResource.Domain.Repositories.Concrete;
using HumanResource.Infrastructure.Repositories.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.Applications.Services.Personnel.Concrete
{
    public class DepartmendService : IDepartmendService
    {
        private readonly IMapper mapper;
        private readonly IDepartmentRepository departmentRepository;
        private readonly ICompanyRepository companyRepository;

        public DepartmendService(IMapper mapper, IDepartmentRepository departmentRepository, ICompanyRepository companyRepository)
        {
            this.mapper = mapper;
            this.departmentRepository = departmentRepository;
            this.companyRepository = companyRepository;
        }
        public async Task<bool> CreateDepartmendPost(CreateDepartmendDTO model, int id)
        {
            Department department = new();
            //Company company = 
            model.Company = await companyRepository.GetByIdAsync(id);
            model.CompanyId = id;
            model.Description = "a";
            model.Status = Status.Active;
            mapper.Map(model, department);
            return await departmentRepository.CreateAsync(department);
        }

        public async Task<Department> GetByIdAsync(int id)
        {
            Department department = await departmentRepository.GetByIdAsync(id);
            return department;
        }

        public async Task<ICollection<DepartmendListDTO>> ListDepartmend(int id)
        {
            var departmendlist =  await departmentRepository.GetAllFirstOrDefaultsAsync(x => x.CompanyId == id);
            var listDepartmendDTO = mapper.Map<List<DepartmendListDTO>>(departmendlist);
            return listDepartmendDTO;
        }
    }
}
