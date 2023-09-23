using HumanResource.Domain.Entities.Concrete;
using HumanResource.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.Applications.Models.DTOs.AdvanceDTO
{
    public class CreateAdvanceDTO
    {
        public CreateAdvanceDTO()
        {
            CreateDate = DateTime.Now;
          
        }
        public decimal TotalAdvanceThisYear { get; set; }
        public int Id { get; set; }
        public decimal MaxAdvance { get; set; }
        public decimal TotalAdvance { get; set; }
        public string? Name { get; set; }
        public Status Status { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? ResponseDate { get; set; }
        public decimal Price { get; set; } //talep
        public Currency Currency { get; set; }
        public AdvanceType AdvanceType { get; set; }
        public AppUser AppUser { get; set; }
        public int? AppUserId { get; set; }
    }
}
