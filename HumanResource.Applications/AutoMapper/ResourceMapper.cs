using AutoMapper;
using HumanResource.Applications.Models.DTOs.AdminDTO;
using HumanResource.Applications.Models.DTOs.AdvanceDTO;
using HumanResource.Applications.Models.DTOs.DemandDTO;
using HumanResource.Applications.Models.DTOs.DepartmendDTO;
using HumanResource.Applications.Models.DTOs.JobDTO;
using HumanResource.Applications.Models.DTOs.PermissonDTO;
using HumanResource.Applications.Models.DTOs.PersonnelDTO;
using HumanResource.Domain.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.Applications.AutoMapper
{
    public class ResourceMapper : Profile
    {
        public ResourceMapper()
        {
            //UseDestinatiınValue() methodu yapılacak değişiklik olmadığında bir onceki veriyi null'a çekmemek için kullanılmıştır.
            CreateMap<DetailDTO, AppUser>().ReverseMap().ForAllMembers(x => x.UseDestinationValue());
            CreateMap<SummaryDTO, AppUser>().ReverseMap().ForAllMembers(x => x.UseDestinationValue());
            CreateMap<UpdateDTO, AppUser>().ReverseMap().ForAllMembers(x => x.UseDestinationValue()); 
            CreateMap<CreateDemandDTO, SalaryRequest>().ReverseMap().ForAllMembers(x => x.UseDestinationValue());
            CreateMap<DeleteDemandDTO, SalaryRequest>().ReverseMap().ForAllMembers(x => x.UseDestinationValue());
            CreateMap<ListDemandDTO, SalaryRequest>().ReverseMap().ForAllMembers(x => x.UseDestinationValue());
			CreateMap<CreateAdvanceDTO, AdvanceDemand>().ReverseMap().ForAllMembers(x => x.UseDestinationValue());
			CreateMap<DeleteAdvanceDTO, AdvanceDemand>().ReverseMap().ForAllMembers(x => x.UseDestinationValue());
			CreateMap<ListAdvanceDTO, AdvanceDemand>().ReverseMap().ForAllMembers(x => x.UseDestinationValue());
			CreateMap<CreatePermissionDTO, PermissionDemand>().ReverseMap().ForAllMembers(x => x.UseDestinationValue());
			CreateMap<DeletePermissionDTO, PermissionDemand>().ReverseMap().ForAllMembers(x => x.UseDestinationValue());
			CreateMap<ListPermissionDTO, PermissionDemand>().ReverseMap().ForAllMembers(x => x.UseDestinationValue());
			CreateMap<AdminAddCompanyDTO, Company>().ReverseMap().ForAllMembers(x => x.UseDestinationValue());
			CreateMap<AdminListCompanyDTO, Company>().ReverseMap().ForAllMembers(x => x.UseDestinationValue());
			CreateMap<AdminDetailCompanyDTO, Company>().ReverseMap().ForAllMembers(x => x.UseDestinationValue());
            CreateMap<CreateDTO, AppUser>().ReverseMap().ForAllMembers(x => x.UseDestinationValue());
            CreateMap<ListDTO, AppUser>().ReverseMap().ForAllMembers(x => x.UseDestinationValue());
            CreateMap<CreateDepartmendDTO, Department>().ReverseMap().ForAllMembers(x => x.UseDestinationValue());
            CreateMap<CreateJobDTO, Job>().ReverseMap().ForAllMembers(x => x.UseDestinationValue());
            CreateMap<JobListDTO, Job>().ReverseMap().ForAllMembers(x => x.UseDestinationValue());
            CreateMap<DepartmendListDTO, Department>().ReverseMap().ForAllMembers(x => x.UseDestinationValue());


        }
    }
}
