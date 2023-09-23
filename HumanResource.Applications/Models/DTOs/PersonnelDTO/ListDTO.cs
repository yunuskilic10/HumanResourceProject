using HumanResource.Domain.Entities.Concrete;
using HumanResource.Domain.Enums;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.Applications.Models.DTOs.PersonnelDTO
{
    public class ListDTO
    {
        public int Id { get; set; } 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? SecondName { get; set; }
        public string? SecondLastName { get; set; }
        public string IdentityNumber { get; set; }
        [NotMapped]
        public IFormFile FormPhotoFile { get; set; }
        public string PhotoFile { get; set; }
        public Status? Status { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }

        //Relations
        public int? JobId { get; set; }
        public Job? Job { get; set; }
        public int? DepartmentId { get; set; }
        public Department? Department { get; set; }
        public int? CompanyId { get; set; }
        public Company? Company { get; set; }
    }
}
