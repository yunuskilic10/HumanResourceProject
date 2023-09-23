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
    public class CreateDTO
    {
        public CreateDTO()
        {
            CreateDate = DateTime.Now;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? SecondName { get; set; }
        public string? SecondLastName { get; set; }
        public Gender Gender { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }
        public string? PrivateMail { get; set; }
        public string? Password { get; set; }
        public DateTime BirthDate { get; set; }
        public string BirthCity { get; set; }
        public string IdentityNumber { get; set; }
        public DateTime WorkStartDate { get; set; }
        public decimal Salary { get; set; }
        public string? PhoneNumber { get; set; }
       
        [NotMapped]
        public IFormFile FormPhotoFile { get; set; }
        public string PhotoFile { get; set; }
        public Status? Status { get; set; }
        public DateTime? CreateDate { get; set; }

        //Relations
        public int? JobId { get; set; }
        public Job? Job { get; set; }
        public int? DepartmentId { get; set; }
        public Department? Department { get; set; }
        public int? CompanyId { get; set; }
        public Company? Company { get; set; }

    }
}
