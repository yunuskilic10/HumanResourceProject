using HumanResource.Applications.Models.DTOs.AdvanceDTO;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.Applications.Services.Personnel.Abstract
{
    public interface IAdvanceService
    {

        Task<bool> CreateAdvancePost(CreateAdvanceDTO model);
        Task CreateAdvance();
        Task<ICollection<ListAdvanceDTO>> ListAdvance(int Id);
        bool DeleteAdvance(int Id);
        Task<bool> ActiveAdvancePost(int Id);
        Task<bool> PassiveAdvancePost(int Id);

        Task<ICollection<ListAdvanceDTO>> ListAdvanceActive(Expression<Func<ListAdvanceDTO, bool>> predicate);
        Task<ICollection<ListAdvanceDTO>> ListAdvanceApproval(Expression<Func<ListAdvanceDTO, bool>> predicate);
        Task<ICollection<ListAdvanceDTO>> ListAdvancePassive(Expression<Func<ListAdvanceDTO, bool>> predicate);

        Task<ICollection<ListAdvanceDTO>> ListAdvanceInculudeUser(int Id);
        Task<ICollection<ListAdvanceDTO>> ListAdvanceActiveInculudeUser(int Id);
        Task<bool> CreateAdvance2(CreateAdvanceDTO createAdvanceDTO, int userId);

    }
}
