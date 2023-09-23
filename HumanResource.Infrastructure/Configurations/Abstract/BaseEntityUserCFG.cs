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
	public abstract class BaseEntityUserCFG<T> : IEntityTypeConfiguration<T> where T : class, IBaseEntity,IGodEntity
	{
		public virtual void Configure(EntityTypeBuilder<T> builder)
		{

			builder.Property(x => x.UpdateDate)
				   .IsRequired(false);


            builder.Property(x => x.Status)
                    .HasDefaultValue(Domain.Enums.Status.Passive)
                    .IsRequired(false);

            builder.Property(x => x.DeleteDate)
				   .IsRequired(false);
		}
	}
}
