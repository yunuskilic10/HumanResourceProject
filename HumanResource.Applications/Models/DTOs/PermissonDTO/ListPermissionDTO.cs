using HumanResource.Domain.Entities.Concrete;
using HumanResource.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.Applications.Models.DTOs.PermissonDTO
{
    public class ListPermissionDTO
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public MalePermissionType? MalePermissionType { get; set; }
        public FemalePermissionType? FemalePermissionType { get; set; }
        public Status Status { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime BeginingDate { get; set; }
        public DateTime FinishDate { get; set; }
        public DateTime? ResponseDate { get; set; }
        public int? AppUserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}
