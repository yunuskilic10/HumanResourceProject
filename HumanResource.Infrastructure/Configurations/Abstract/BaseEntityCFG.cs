using HumanResource.Domain.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.Infrastructure.Configurations.Abstract
{
	public abstract class BaseEntityCFG<T> : IEntityTypeConfiguration<T> where T : class, IBaseEntity, IGeneralEntity
	{
		public virtual void Configure(EntityTypeBuilder<T> builder)
		{

			builder.Property(x => x.UpdateDate)
				   .IsRequired(false);

			builder.Property(x=> x.Status)
					.HasDefaultValue(Domain.Enums.Status.Passive)
					.IsRequired(false);

			builder.Property(x => x.DeleteDate)
				   .IsRequired(false);

			builder.HasKey(x => x.Id);

			builder.Property(x => x.Id)
				   .HasColumnType("int");

			builder.Property(x => x.Name)
				   .IsRequired();

			builder.Property(x => x.Name)
				   .HasMaxLength(100)
				   .HasColumnType("nvarchar");
		}
	}
}
