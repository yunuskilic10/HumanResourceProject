using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.Applications.Models.DTOs.MailDTO
{
    public class NewPasswordDTO
    {
        public string Email { get; set; }
        public int? ConfirmCode { get; set; }
        public string? Password { get; set; }
        public string? ConfirmNewPassword { get; set; }
    }
}
