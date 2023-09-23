using HumanResource.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.Applications.Models.DTOs.PersonnelDTO
{
    public class DetailDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? SecondName { get; set; }
        public string? SecondLastName { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public string BirthCity { get; set; }
        public string IdentityNumber { get; set; }
        public DateTime WorkStartDate { get; set; }
        public DateTime? WorkFinishDate { get; set; }
        public int? JobId { get; set; }
        public int? DepartmentId { get; set; }
        public string PhotoFile { get; set; }
        public string JobName { get; set; }
        public string DepartmentName { get; set; }
        public string CompanyName { get; set; }
        public Status? Status { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
    }
}
