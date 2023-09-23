using HumanResource.Domain.Entities.Abstract;
using HumanResource.Domain.Enums;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.Domain.Entities.Concrete
{
    public class AppUser : IdentityUser<int>, IBaseEntity
	{
		public AppUser()
		{
			CreateDate = DateTime.Now;
			SalaryRequests = new List<SalaryRequest>();
            PermissionDemands=new List<PermissionDemand>();
			AdvanceDemands= new List<AdvanceDemand>();

        }

        public string FirstName { get; set; }
		public string LastName { get; set; }
		public string? SecondName { get; set; }
		public string? SecondLastName { get; set; }
		public Gender Gender { get; set; }
		public string? Address { get; set; }
		public int? ConfirmCode { get; set; }
		public DateTime BirthDate { get; set; }
		public string BirthCity { get; set; }
		public string IdentityNumber { get; set; }
		public string? PrivateMail { get; set; }
		public DateTime WorkStartDate { get; set; }
		public DateTime? WorkFinishDate { get; set; }
		public decimal Salary { get; set; }
		public decimal? NewSalary { get; set; }
		public DateTime? RaiseDate { get; set; }
		public DateTime? ResponseFirstAdvanceDate { get; set; }
        public DateTime? ResponseLastAdvanceDate { get; set; }
        public decimal? MaxAdvanceLimitPerYear { get; set; }
		public decimal? TotalAdvancePerYear { get; set; }
        [NotMapped]
		public IFormFile FormPhotoFile { get; set; }
		public string PhotoFile { get; set; }
		public Status? Status { get; set; }
		public DateTime? CreateDate { get; set; }
		public DateTime? UpdateDate { get; set; }
		public DateTime? DeleteDate { get; set; }

		//Relations
		public int? JobId { get; set; }
		public Job? Job { get; set; }
		public int? DepartmentId { get; set; }
		public Department? Department { get; set; }
		public int? CompanyId { get; set; }
		public Company? Company { get; set; }
		public ICollection<SalaryRequest>? SalaryRequests { get; set; }
		public ICollection<PermissionDemand>? PermissionDemands { get; set; }
        public ICollection<AdvanceDemand>? AdvanceDemands { get; set; }

    }
}
