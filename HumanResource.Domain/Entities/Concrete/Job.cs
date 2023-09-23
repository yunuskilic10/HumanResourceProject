using HumanResource.Domain.Entities.Abstract;
using HumanResource.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.Domain.Entities.Concrete
{
	public class Job : IGeneralEntity, IBaseEntity
	{
		public Job() 
		{
			AppUsers = new List<AppUser>();
			CreateDate = DateTime.Now;
		}
		public int Id { get; set; }
		public string Name { get; set; }
		public string? Description { get; set; }
		public DateTime? CreateDate { get; set; }
		public DateTime? UpdateDate { get; set; }
		public DateTime? DeleteDate { get; set; }
		public ICollection<AppUser> AppUsers { get; set; }
		public int? DepartmentId { get; set; }
		public Department? Department { get; set; }
        public Status? Status { get; set; }
    }
}
