using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HumanResource.Domain.Enums
{
    public enum FemalePermissionType
    {
        [Display(Name = "Annual Paid Leave")]
        AnnualPaidLeave = 1,
        [Display(Name = "Maternity Leave")]
        MaternityLeave,
        [Display(Name = "Sickness and Sick Leave")]
        SicknessandSickLeave,
        [Display(Name = "Bereavement Leave")]
        BereavementLeave,
        [Display(Name = "Marriage Leave")]
        MarriageLeave
    }
}
