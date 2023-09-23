using HumanResource.Domain.Entities.Concrete;
using HumanResource.Infrastructure.Configurations.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.Infrastructure.Configurations.Concrete
{
	public class AppRoleCFG : IEntityTypeConfiguration<AppRole>
	{
		public void Configure(EntityTypeBuilder<AppRole> builder)
		{
			builder.HasData(
				new AppRole() { Id = 1, Name = "Admin", NormalizedName = "ADMIN" },
				new AppRole() { Id = 2, Name = "CompanyManager", NormalizedName = "COMPANYMANAGER" },
				new AppRole() { Id = 3, Name = "Personnel", NormalizedName = "PERSONNEL" }
				);
		}
	}
}
