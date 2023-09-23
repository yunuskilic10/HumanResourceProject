using HumanResource.Domain.Entities.Concrete;
using HumanResource.Domain.Repositories.Concrete;
using HumanResource.Infrastructure.Context;
using HumanResource.Infrastructure.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.Infrastructure.Repositories.Concrete
{
    public class DepartmentRepository:BaseEntityRepository<Department>, IDepartmentRepository
    {
        public DepartmentRepository(HumanResourceDB resourceDB) : base(resourceDB)
        {
            
        }
    }
}
