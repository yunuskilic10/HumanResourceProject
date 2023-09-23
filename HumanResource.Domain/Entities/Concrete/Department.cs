using HumanResource.Domain.Entities.Abstract;
using HumanResource.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.Domain.Entities.Concrete
{
	public class Department : IGeneralEntity, IBaseEntity
	{
		public Department() 
		{
			AppUsers = new List<AppUser>();
			Jobs = new List<Job>();
			CreateDate = DateTime.Now;
		}
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public DateTime? CreateDate { get; set; }
		public DateTime? UpdateDate { get; set; }
		public DateTime? DeleteDate { get; set; }
		public ICollection<AppUser> AppUsers { get; set; }
		public ICollection<Job> Jobs { get; set; }
		public int? CompanyId { get; set; }
		public Company? Company { get; set; }
        public Status? Status { get; set; }
    }
}
