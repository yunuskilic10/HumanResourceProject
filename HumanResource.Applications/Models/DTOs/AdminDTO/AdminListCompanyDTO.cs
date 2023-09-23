using HumanResource.Domain.Entities.Concrete;
using HumanResource.Domain.Enums;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.Applications.Models.DTOs.AdminDTO
{
    public class AdminListCompanyDTO
    {
        public AdminListCompanyDTO()
        {
            AppUsers = new List<AppUser>();
            Departments = new List<Department>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public CompanyType? CompanyType { get; set; }
        public string? MersisNo { get; set; }
        public string? TaxNo { get; set; }
        public TaxAdminIsTrationType? TaxAdminIsTrationType { get; set; }
        [NotMapped]
        public IFormFile? FormPhotoFile { get; set; }
        public string? LogoFile { get; set; }
        public string? TelephoneNumber { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }
        public int? EmployeeCount { get; set; }
        public DateTime? FoundationDate { get; set; }
        public DateTime? ContractStartDate { get; set; }
        public DateTime? ContractEndDate { get; set; }
        public Status? Status { get; set; }
        public ICollection<AppUser> AppUsers { get; set; }
        public ICollection<Department> Departments { get; set; }
    }
}
