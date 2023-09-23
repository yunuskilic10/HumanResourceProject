using HumanResource.Domain.Entities.Abstract;
using HumanResource.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.Domain.Entities.Concrete
{
    public class PermissionDemand : IRequestEntity
    {
        public int Id { get; set; }
        public string? Name { get; set ; }
        public MalePermissionType? MalePermissionType { get; set; }
        public FemalePermissionType? FemalePermissionType { get; set; }
        public Status Status { get; set; }
        public DateTime CreateDate { get ; set ; } = DateTime.Now;
        public DateTime? BeginingDate { get; set; }
        public DateTime? FinishDate { get; set; }
        public DateTime? ResponseDate { get; set; }


        public int? AppUserId { get; set; }
        public AppUser? AppUser { get; set; }
    }
}
