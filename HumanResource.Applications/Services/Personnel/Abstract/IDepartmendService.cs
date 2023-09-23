using HumanResource.Applications.Models.DTOs.DemandDTO;
using HumanResource.Applications.Models.DTOs.DepartmendDTO;
using HumanResource.Domain.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.Applications.Services.Personnel.Abstract
{
    public interface IDepartmendService
    {
        Task<bool> CreateDepartmendPost(CreateDepartmendDTO model, int id);
        Task<ICollection<DepartmendListDTO>> ListDepartmend(int id);
        Task<Department> GetByIdAsync(int id);
    }
}
