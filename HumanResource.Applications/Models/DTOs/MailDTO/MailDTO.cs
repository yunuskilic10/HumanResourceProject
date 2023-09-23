using HumanResource.Applications.Validators.CustomValidator;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.Applications.Models.DTOs.MailDTO
{
    public  class MailDTO
    {
        public string Email { get; set; }
        public int? ConfirmCode { get; set; }

    }
}
