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
	public class JobCFG:BaseEntityCFG<Job>
	{
		public override void Configure(EntityTypeBuilder<Job> builder)
		{
			builder.HasOne(x => x.Department)
				   .WithMany(x => x.Jobs)
				   .HasForeignKey(x => x.DepartmentId)
				   .OnDelete(DeleteBehavior.SetNull);

			builder.Property(x => x.Description)
				   .HasMaxLength(255)
				   .HasColumnType("nvarchar");

			builder.HasData(
                new Job() { Id = 1, Name = "Full-Stack Developer", CreateDate = DateTime.Now, DepartmentId = 1, Description = "A Full Stack Developer is a versatile expert in both front-end and back-end web development." },
				new Job() { Id = 2, Name = "Back-End Developer", CreateDate = DateTime.Now, DepartmentId = 1, Description = "Back-End Development focuses on building and maintaining the server-side components, databases, and APIs that drive the functionality of websites and applications." },
				new Job() { Id = 3, Name = "Front-End Developer", CreateDate = DateTime.Now, DepartmentId = 1 , Description = "Front-End Development focuses on crafting the user interface of websites and applications using HTML, CSS, and JavaScript for an engaging and accessible user experience." },
				new Job() { Id = 4, Name = "HouseKeeper", CreateDate = DateTime.Now, DepartmentId = 7 , Description = "Housekeeper is a professional who ensures cleanliness and order in homes or businesses by performing tasks such as cleaning, organizing, and maintaining a tidy environment." },
				new Job() { Id = 5, Name = "Office Boy", CreateDate = DateTime.Now, DepartmentId = 4 , Description = "An office boy, or office assistant, is a support staff member responsible for performing administrative tasks such as filing, photocopying, mail distribution, and office organization" },
				new Job() { Id = 6, Name = "Tea Maker & Sailor", CreateDate = DateTime.Now, DepartmentId = 4, Description = "A tea maker skillfully brews tea, achieving optimal taste and aroma by selecting leaves, controlling brewing, and catering to preferences." },
				new Job() { Id = 7, Name = "Secretary", CreateDate = DateTime.Now, DepartmentId = 4, Description = "A secretary organizes appointments, manages correspondence, and provides essential administrative support, contributing to efficient communication and smooth operations within an organization." }
				);
			base.Configure(builder);
		}
	}
}
