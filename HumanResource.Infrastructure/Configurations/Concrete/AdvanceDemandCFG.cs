using HumanResource.Domain.Entities.Concrete;
using HumanResource.Infrastructure.Configurations.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.Infrastructure.Configurations.Concrete
{
    public class AdvanceDemandCFG : RequestEntityCFG<AdvanceDemand>
    {
        public override void Configure(EntityTypeBuilder<AdvanceDemand> builder)
        {
            builder.HasOne(x => x.AppUser)
                   .WithMany(x => x.AdvanceDemands)
                   .HasForeignKey(x => x.AppUserId)
                   .OnDelete(DeleteBehavior.SetNull);

            builder.Property(x => x.Name)
                   .HasMaxLength(255)
                   .HasColumnType("nvarchar");

            builder.HasData(
                new AdvanceDemand() { Id = 1, Name = "Institutional", CreateDate = DateTime.Now, AppUserId = 1,  Status = Domain.Enums.Status.Approval, AdvanceType = Domain.Enums.AdvanceType.Institutional, Currency = Domain.Enums.Currency.TL, Price = 500},
               new AdvanceDemand() { Id = 2, Name = "Institutional", CreateDate = DateTime.Now.AddDays(-8), AppUserId = 2, Status = Domain.Enums.Status.Passive, AdvanceType = Domain.Enums.AdvanceType.Individual, Currency = Domain.Enums.Currency.TL, Price = 15000, ResponseDate =DateTime.Now.AddDays(-4) },
               new AdvanceDemand() { Id = 2, Name = "Institutional", CreateDate = DateTime.Now.AddDays(-10), AppUserId = 3, Status = Domain.Enums.Status.Active, AdvanceType = Domain.Enums.AdvanceType.Individual, Currency = Domain.Enums.Currency.TL, Price = 3000, ResponseDate = DateTime.Now.AddDays(-6) }
                );
            base.Configure(builder);
        }
    }
}
