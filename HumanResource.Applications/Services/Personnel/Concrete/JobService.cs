using AutoMapper;
using HumanResource.Applications.Models.DTOs.DepartmendDTO;
using HumanResource.Applications.Models.DTOs.JobDTO;
using HumanResource.Applications.Services.Personnel.Abstract;
using HumanResource.Domain.Entities.Concrete;
using HumanResource.Domain.Enums;
using HumanResource.Domain.Repositories.Concrete;
using HumanResource.Infrastructure.Repositories.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.Applications.Services.Personnel.Concrete
{
    public class JobService : IJobService
    {

        private readonly IDepartmentRepository departmentRepository;
        private readonly IMapper mapper;
        private readonly IJobRepository jobRepository;

        public JobService(IDepartmentRepository departmentRepository, IMapper mapper, IJobRepository jobRepository)
        {
            this.departmentRepository = departmentRepository;
            this.mapper = mapper;
            this.jobRepository = jobRepository;
        }

        public async Task<ICollection<JobListDTO>> AllJobList(int id)
        {
            Department department = await departmentRepository.GetByIdAsync(id);
            var joblist = await jobRepository.GetAllFirstOrDefaultsAsync(x=> x.Department.CompanyId == department.CompanyId);
            var listJobDTO = mapper.Map<List<JobListDTO>>(joblist);
            return listJobDTO;
        }

        public async Task<bool> CreateJobPost(CreateJobDTO model, int id)
        {
            Job job = new();
            //Company company = 
            model.Department = await departmentRepository.GetByIdAsync(id);
            model.DepartmentId = id;
            model.Description = "Job";
            model.Status = Status.Active;
            mapper.Map(model, job);
            return await jobRepository.CreateAsync(job);
        }

        public async Task<Job> GetByIdAsync(int id)
        {
            Job job = await jobRepository.GetByIdAsync(id);
            return job;
        }

        public async Task<ICollection<JobListDTO>> ListDepartmend(int id)
        {
            var jobList = await jobRepository.GetAllFirstOrDefaultsAsync(x => x.DepartmentId == id);
            var listJobDTO = mapper.Map<List<JobListDTO>>(jobList);
            return listJobDTO;
        }
    }
}
