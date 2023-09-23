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
	public class DepartmentCFG:BaseEntityCFG<Department>
	{
		public override void Configure(EntityTypeBuilder<Department> builder)
		{
			builder.HasOne(x => x.Company)
				   .WithMany(x => x.Departments)
				   .HasForeignKey(x => x.CompanyId)
				   .OnDelete(DeleteBehavior.SetNull);

			builder.Property(x => x.Description)
				   .HasMaxLength(255)
				   .HasColumnType("nvarchar");

			builder.HasData(
				new Department() { Id = 1, Name = "IT", CreateDate = DateTime.Now, CompanyId = 1 , Description = "Generate secure random user identities with hashed passwords and salts using this code snippet." },
				new Department() { Id = 2, Name = "IT", CreateDate = DateTime.Now, CompanyId = 2, Description = "Generate secure random user identities with hashed passwords and salts using this code snippet." },
				new Department() { Id = 3, Name = "IT", CreateDate = DateTime.Now, CompanyId = 3, Description = "Generate secure random user identities with hashed passwords and salts using this code snippet." },
				new Department() { Id = 4, Name = "Human Resources", CreateDate = DateTime.Now, CompanyId = 1, Description = "Human Resources (HR) is a critical function that oversees personnel activities, including recruitment, training, benefits, and workplace policies." },
				new Department() { Id = 5, Name = "Human Resources", CreateDate = DateTime.Now, CompanyId = 2, Description = "Human Resources (HR) is a critical function that oversees personnel activities, including recruitment, training, benefits, and workplace policies." },
				new Department() { Id = 6, Name = "Human Resources", CreateDate = DateTime.Now, CompanyId = 3, Description = "Human Resources (HR) is a critical function that oversees personnel activities, including recruitment, training, benefits, and workplace policies." },
				new Department() { Id = 7, Name = "Services Departmants", CreateDate = DateTime.Now, CompanyId = 1, Description = "The Services Department ensures efficient business operations by offering essential support functions such as customer assistance, technical help, maintenance, and issue resolution." },
				new Department() { Id = 8, Name = "Services Departmants", CreateDate = DateTime.Now, CompanyId = 2, Description = "The Services Department ensures efficient business operations by offering essential support functions such as customer assistance, technical help, maintenance, and issue resolution." },
				new Department() { Id = 9, Name = "Services Departmants", CreateDate = DateTime.Now, CompanyId = 3, Description = "The Services Department ensures efficient business operations by offering essential support functions such as customer assistance, technical help, maintenance, and issue resolution." }
				);
			base.Configure(builder);
		}
	}
}
