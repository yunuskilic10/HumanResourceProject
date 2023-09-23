using HumanResource.Domain.Entities.Abstract;
using HumanResource.Domain.Enums;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.Domain.Entities.Concrete
{
	public class SalaryRequest : IRequestEntity
	{
		public int Id { get; set; }
		//Database entity column name for "Description"
		public string? Name { get; set; }
		public decimal? SalaryDemandAmount { get; set; }
		public DemandType? DemandType { get; set; }
		// Awaiting Approval, Approved, Rejection for SalaryRequest
		public Status Status { get; set; }
		public Currency? Currency { get; set; }
		[NotMapped]
		public IFormFile? DemandFile { get; set; }
		public string? BillExtension { get; set; }

		//  for DemandCreateDate 
		public DateTime CreateDate { get; set; } = DateTime.Now;
		// for DemandDeleteDate 
		public DateTime? DeleteDate { get; set; }

		//Relations
		public int? AppUserId { get; set; }
		public virtual AppUser? AppUser { get; set; }
        public DateTime? ResponseDate { get; set; }
    }
}
