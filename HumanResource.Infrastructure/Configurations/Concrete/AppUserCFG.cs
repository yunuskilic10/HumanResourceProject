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
	public class AppUserCFG : BaseEntityUserCFG<AppUser>
	{
		public override void Configure(EntityTypeBuilder<AppUser> builder)
		{
			builder.Property(x => x.PhotoFile)
				   .IsRequired(false)
				   .HasMaxLength(50);

			builder.Property(x => x.Address)
				   .HasMaxLength(200)
				   .HasColumnType("nvarchar");

			builder.HasOne(x => x.Company)
				   .WithMany(x => x.AppUsers)
				   .HasForeignKey(x => x.CompanyId)
				   .OnDelete(DeleteBehavior.SetNull);

			builder.HasOne(x => x.Job)
				   .WithMany(x => x.AppUsers)
				   .HasForeignKey(x => x.JobId)
				   .OnDelete(DeleteBehavior.SetNull);

			builder.HasOne(x => x.Department)
				   .WithMany(x => x.AppUsers)
				   .HasForeignKey(x => x.DepartmentId)
				   .OnDelete(DeleteBehavior.SetNull);

			//builder.HasData(
			//	new AppUser() { Id = 1, FirstName = "John", LastName = "DOE", CompanyId = 1, DepartmentId = 1, JobId = 1, Email = "john.doe@bilgeadamboost.com", NormalizedEmail = "JOHN.DOE@BILGEADAMBOOST.COM", EmailConfirmed = true, TwoFactorEnabled = true, }
			//	);

			base.Configure(builder);
		}
	}
}
