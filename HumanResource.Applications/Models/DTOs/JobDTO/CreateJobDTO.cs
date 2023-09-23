using HumanResource.Domain.Entities.Concrete;
using HumanResource.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.Applications.Models.DTOs.JobDTO
{
    public class CreateJobDTO
    {
        public CreateJobDTO()
        {
            CreateDate = DateTime.Now;
        }
        //public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? DepartmentId { get; set; }
        public Department? Department { get; set; }
        public Status? Status { get; set; }

    }
}
