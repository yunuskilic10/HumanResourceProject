using HumanResource.Domain.Entities.Concrete;
using HumanResource.Domain.Enums;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.Domain.Entities.Abstract
{
    public interface IRequestEntity
    {
        public int Id { get; set; }
        //Database entity column name for "Description"
        public string? Name { get; set; }
        public Status Status { get; set; }
        
        //  for DemandCreateDate 
        public DateTime CreateDate { get; set; }
        public DateTime? ResponseDate { get; set; }

    }
}
