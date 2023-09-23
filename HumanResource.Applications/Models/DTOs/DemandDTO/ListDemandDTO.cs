using HumanResource.Domain.Entities.Concrete;
using HumanResource.Domain.Enums;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.Applications.Models.DTOs.DemandDTO
{
    public class ListDemandDTO
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal? SalaryDemandAmount { get; set; }
        public DemandType? DemandType { get; set; }
        public Status Status { get; set; } = Status.Approval;
        public Currency? Currency { get; set; }
        public string? BillExtension { get; set; }
        public DateTime? DeleteDate { get; set; }
        public DateTime? ResponseDate { get; set; }
        public int? AppUserId { get; set; }
        public AppUser? AppUser { get; set; }

    }
}
