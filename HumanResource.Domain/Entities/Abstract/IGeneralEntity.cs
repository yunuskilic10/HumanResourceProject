using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.Domain.Entities.Abstract
{
	public interface IGeneralEntity : IGodEntity
	{
		public int Id { get; set; }
		public string Name { get; set; }
	}
}
