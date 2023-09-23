using HumanResource.Domain.Entities.Concrete;
using HumanResource.Infrastructure.Configurations.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.Infrastructure.Configurations.Concrete
{
	public class CompanyCFG:BaseEntityCFG<Company>
	{
		public override void Configure(EntityTypeBuilder<Company> builder)
		{
			builder.HasData(
				new Company() { Id = 1, Name = "BilgeAdam Akademi", CreateDate = DateTime.Now, Address ="Istanbul" },
				new Company() { Id = 2, Name = "Neos Akademi", CreateDate = DateTime.Now, Address ="Ankara" },
				new Company() { Id = 3, Name = "İstanbul Eğitim Akademi", CreateDate = DateTime.Now, Address ="Antalya" }
				);

			base.Configure(builder);
		}
	}
}
