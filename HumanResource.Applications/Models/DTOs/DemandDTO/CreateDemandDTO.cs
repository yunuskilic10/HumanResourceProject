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
    public class CreateDemandDTO
    {
        public CreateDemandDTO()
        {
            CreateDate = DateTime.Now;
             
        }
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal? SalaryDemandAmount { get; set; }
        public DemandType? DemandType { get; set; }
        public Status Status { get; set; } 
        public Currency? Currency { get; set; }
        [NotMapped]
        public IFormFile DemandFile { get; set; }
        public string? BillExtension { get; set; }
        public DateTime? CreateDate { get; set; }
        public int AppUserId { get; set; }

    }
}
