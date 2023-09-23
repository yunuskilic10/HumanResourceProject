using HumanResource.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.Domain.Entities.Abstract
{
    public interface IGodEntity
    {
        public Status? Status { get; set; }
    }
}
