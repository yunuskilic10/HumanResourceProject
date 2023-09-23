
using HumanResource.Applications.Models.DTOs.AdvanceDTO;
using HumanResource.Applications.Models.DTOs.PermissonDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.Applications.Services.Personnel.Abstract
{
	public interface IPermissionService
	{
		Task<bool> CreatePermissionPost(CreatePermissionDTO model);
		Task CreatePermission();

		Task<ICollection<ListPermissionDTO>> ListPermission(int Id);
		bool DeletePermission(int Id);

        Task<bool> ActivePermissionPost(int Id);
        Task<bool> PassivePermissionPost(int Id);
        Task<ICollection<ListPermissionDTO>> ListPermissionActive(Expression<Func<ListPermissionDTO, bool>> predicate);
        Task<ICollection<ListPermissionDTO>> ListPermissionApproval(Expression<Func<ListPermissionDTO, bool>> predicate);
        Task<ICollection<ListPermissionDTO>> ListPermissionPassive(Expression<Func<ListPermissionDTO, bool>> predicate);
        Task<ICollection<ListPermissionDTO>> ListPermissionInculudeUser(int Id);
        Task<ICollection<ListPermissionDTO>> ListPermissionActiveInculudeUser(int Id);
        Task<ICollection<ListPermissionDTO>> ListPermissionApprovalUserId(int id);
        Task<ICollection<ListPermissionDTO>> ListPermissionActiveUserId(int id);
        Task<bool> CreatePermission2(CreatePermissionDTO createPermissionDTO, int userId);

    }
}
