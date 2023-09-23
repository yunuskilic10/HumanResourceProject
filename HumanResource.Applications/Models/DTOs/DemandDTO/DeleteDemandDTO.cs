using HumanResource.Domain.Enums;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.Applications.Models.DTOs.DemandDTO
{
    public class DeleteDemandDTO
    {
        public DeleteDemandDTO()
        {
            DeleteDate = DateTime.Now;
        }
        public int Id { get; set; }
        public DateTime? DeleteDate { get; set; }
    }
}
