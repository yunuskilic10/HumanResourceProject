using HumanResource.Domain.Entities.Abstract;
using HumanResource.Domain.Enums;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.Domain.Entities.Concrete
{
	public class Company : IGeneralEntity, IBaseEntity
	{
		public Company() 
		{
			AppUsers = new List<AppUser>();
			Departments = new List<Department>();
			CreateDate = DateTime.Now;
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
        public DateTime? CreateDate { get; set; }
		public DateTime? UpdateDate { get; set; }
		public DateTime? DeleteDate { get; set; }
        public ICollection<AppUser> AppUsers { get; set; }
		public ICollection<Department> Departments { get; set; }
    }
}
