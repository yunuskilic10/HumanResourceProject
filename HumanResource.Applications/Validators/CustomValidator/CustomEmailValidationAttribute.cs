using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.Applications.Validators.CustomValidator
{
    public class CustomEmailValidationAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var email = value as string;
            if (email == null)
                return false;

            return email.EndsWith(".com", StringComparison.OrdinalIgnoreCase);
        }
    }
}
