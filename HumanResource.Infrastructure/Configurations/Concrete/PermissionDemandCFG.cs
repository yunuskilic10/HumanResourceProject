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
    public class PermissionDemandCFG : RequestEntityCFG<PermissionDemand>
    {
        public override void Configure(EntityTypeBuilder<PermissionDemand> builder)
        {
            builder.HasOne(x => x.AppUser)
                   .WithMany(x => x.PermissionDemands)
                   .HasForeignKey(x => x.AppUserId)
                   .OnDelete(DeleteBehavior.SetNull);

            builder.Property(x => x.Name)
                   .HasMaxLength(255)
                   .HasColumnType("nvarchar");

            builder.HasData(
                new PermissionDemand() { Id = 1, Name = "I want to paternity leave", CreateDate = DateTime.Now, BeginingDate = DateTime.Now.AddDays(1), FinishDate = DateTime.Now.AddDays(4), AppUserId = 1, MalePermissionType = Domain.Enums.MalePermissionType.PaternityLeave, Status = Domain.Enums.Status.Approval},
                new PermissionDemand() { Id = 2, Name = "I want to marriage leave", CreateDate = DateTime.Now, BeginingDate = DateTime.Now.AddDays(-4), FinishDate = DateTime.Now.AddDays(-7), AppUserId = 2, MalePermissionType = Domain.Enums.MalePermissionType.MarriageLeave, Status = Domain.Enums.Status.Active },
                 new PermissionDemand() { Id = 3, Name = "I want to adoption leave", CreateDate = DateTime.Now, BeginingDate = DateTime.Now, FinishDate = DateTime.Now.AddDays(7), AppUserId = 3, MalePermissionType = Domain.Enums.MalePermissionType.BereavementLeave, Status = Domain.Enums.Status.Passive }
                );
            base.Configure(builder);
        }
    }
}
