using HumanResource.Applications.Models.DTOs.DepartmendDTO;
using HumanResource.Applications.Models.DTOs.JobDTO;
using HumanResource.Domain.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.Applications.Services.Personnel.Abstract
{
    public interface IJobService
    {

        Task<bool> CreateJobPost(CreateJobDTO model, int id);
        Task<ICollection<JobListDTO>> ListDepartmend(int id);
        Task<ICollection<JobListDTO>> AllJobList(int id);
        Task<Job> GetByIdAsync(int id);
    }
}
