using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.Domain.Entities.Abstract
{
	public interface IBaseEntity : IGodEntity
	{
		public DateTime? CreateDate { get; set; }
		public DateTime? DeleteDate { get; set; }
		public DateTime? UpdateDate { get; set; }
	}
}
