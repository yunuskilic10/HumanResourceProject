using HumanResource.Domain.Entities.Concrete;
using HumanResource.Infrastructure.Configurations.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace HumanResource.Infrastructure.Context
{
	public class HumanResourceDB:IdentityDbContext<AppUser, AppRole, int>
	{
		public HumanResourceDB()
		{

		}

		public HumanResourceDB(DbContextOptions<HumanResourceDB> options) : base(options)
		{

		}
		public DbSet<AppUser> Users { get; set; }
		public DbSet<AppRole> Roles { get; set; }
		public DbSet<Company> Companies { get; set; }
		public DbSet<SalaryRequest> SalaryRequests { get; set; }
		public DbSet<Department> Departmants { get; set; }
		public DbSet<Job> Jobs { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("YourConnectionString");

			base.OnConfiguring(optionsBuilder);
		}
		protected override void OnModelCreating(ModelBuilder builder)
		{
			builder.ApplyConfiguration<AppUser>(new AppUserCFG());
			builder.ApplyConfiguration<AppRole>(new AppRoleCFG());
			builder.ApplyConfiguration<Company>(new CompanyCFG());
			builder.ApplyConfiguration<Department>(new DepartmentCFG());
			builder.ApplyConfiguration<Job>(new JobCFG());

			base.OnModelCreating(builder);
		}
	}
}
