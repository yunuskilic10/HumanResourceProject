using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.Applications.Models.DTOs.PersonnelDTO
{
    public class UpdateDTO
    {
		public UpdateDTO()
		{
			UpdateDate = DateTime.Now;
		}
		public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? SecondName { get; set; }
        public string? SecondLastName { get; set; }
        public IFormFile? FormPhotoFile { get; set; }
        public string? PhotoFile { get; set; }
        public string? JobName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
		public DateTime? UpdateDate { get; set; }
	}
}
