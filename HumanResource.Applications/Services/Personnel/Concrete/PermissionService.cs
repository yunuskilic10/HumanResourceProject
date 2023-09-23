using AutoMapper;
using HumanResource.Applications.Models.DTOs.AdvanceDTO;
using HumanResource.Applications.Models.DTOs.DemandDTO;
using HumanResource.Applications.Models.DTOs.PermissonDTO;
using HumanResource.Applications.Services.Personnel.Abstract;
using HumanResource.Domain.Entities.Concrete;
using HumanResource.Domain.Enums;
using HumanResource.Domain.Repositories.Concrete;
using HumanResource.Infrastructure.Repositories.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Server.IIS.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.Applications.Services.Personnel.Concrete
{
    public class PermissionService : IPermissionService
    {
        private readonly IPermissionRepository permissionRepository;
        private readonly IMapper mapper;
        private readonly UserManager<AppUser> userManager;

        public PermissionService(IPermissionRepository permissionRepository, IMapper mapper, UserManager<AppUser> userManager)
        {
            this.permissionRepository = permissionRepository;
            this.mapper = mapper;
            this.userManager = userManager;
        }

        public async Task<bool> ActivePermissionPost(int Id)
        {
            return await permissionRepository.AcceptToAsync(Id);
        }
        public async Task<bool> PassivePermissionPost(int Id)
        {
            return await permissionRepository.PassiveToAsync(Id);
        }

        public Task CreatePermission()
        {
            throw new NotImplementedException();
        }

        public async Task<bool> CreatePermissionPost(CreatePermissionDTO model)
        {
            PermissionDemand permissionDemand = new PermissionDemand();

            model.Status = Status.Approval;
            mapper.Map(model, permissionDemand);
            return await permissionRepository.CreateAsync(permissionDemand);
        }

        public bool DeletePermission(int Id)
        {
            PermissionDemand permissionDemand = permissionRepository.FindByInlclueAppUser(Id).Result;
            return permissionRepository.Delete(permissionDemand.Id);
        }

        public async Task<ICollection<ListPermissionDTO>> ListPermission(int Id)
        {
            var permissionRequestList = await permissionRepository.GetAll(Id);
            var listPermissionDTOs = mapper.Map<List<ListPermissionDTO>>(permissionRequestList);

            return listPermissionDTOs;
        }

        public async Task<ICollection<ListPermissionDTO>> ListPermissionActive(Expression<Func<ListPermissionDTO, bool>> predicate)
        {
            var listPermissionActive = await permissionRepository.GetAllActiveAsync(x => x.Status == Status.Active);
            var listPermissionActiveDTO = mapper.Map<List<ListPermissionDTO>>(listPermissionActive);
            return listPermissionActiveDTO;
        }
        public async Task<ICollection<ListPermissionDTO>> ListPermissionActiveUserId(int id)
        {
            var listPermissionActive = await permissionRepository.GetAllActiveUserIdAsync(id);
            var listPermissionActiveDTO = mapper.Map<List<ListPermissionDTO>>(listPermissionActive);
            return listPermissionActiveDTO;
        }

        public async Task<ICollection<ListPermissionDTO>> ListPermissionApproval(Expression<Func<ListPermissionDTO, bool>> predicate)
        {
            var listPermissionApproval = await permissionRepository.GetAllApprovalAsync(x => x.Status == Status.Approval);
            var listPermissionApprovalDTO = mapper.Map<List<ListPermissionDTO>>(listPermissionApproval);
            return listPermissionApprovalDTO;
        }
        public async Task<ICollection<ListPermissionDTO>> ListPermissionApprovalUserId(int id)
        {
            var listPermissionApproval = await permissionRepository.GetAllApprovalUserIdAsync(id); 
            var listPermissionApprovalDTO = mapper.Map<List<ListPermissionDTO>>(listPermissionApproval);
            return listPermissionApprovalDTO;
        }

        public async Task<ICollection<ListPermissionDTO>> ListPermissionPassive(Expression<Func<ListPermissionDTO, bool>> predicate)
        {
            var listPermissionPassive = await permissionRepository.GetAllPassiveAsync(x => x.Status == Status.Passive);
            var listPermissionPassiveDTO = mapper.Map<List<ListPermissionDTO>>(listPermissionPassive);
            return listPermissionPassiveDTO;
        }

        public async Task<ICollection<ListPermissionDTO>> ListPermissionInculudeUser(int Id)
        {
            var listPermissionUserList = await permissionRepository.FindByInlclueAppUserActivePermissionList(Id);
            var listPermissionPassiveDTO = mapper.Map<List<ListPermissionDTO>>(listPermissionUserList);

            return listPermissionPassiveDTO;
        }

        public async Task<ICollection<ListPermissionDTO>> ListPermissionActiveInculudeUser(int Id)
        {
            var listPermissionActiveUserList = await permissionRepository.FindByInlclueAppUserApprovalPermissionList(Id);
            var listPermissionActiveDTO = mapper.Map<List<ListPermissionDTO>>(listPermissionActiveUserList);

            return listPermissionActiveDTO;
        }

        public async Task<bool> CreatePermission2(CreatePermissionDTO model, int userId)
        {
            if (model.FemalePermissionType == FemalePermissionType.MaternityLeave || model.MalePermissionType == MalePermissionType.PaternityLeave)
            {
                var appUser = await userManager.FindByIdAsync(userId.ToString());

                if (appUser == null)
                {
                    throw new Exception("User can not found.");
                }

                else
                {
                    var lastPermisson = await permissionRepository.FindByInlclueAppUserMaternitityPermission(appUser.Id);
                    if  (lastPermisson.BeginingDate==null)
                    {
                        PermissionDemand permissionDemand = new PermissionDemand();

                        model.Status = Status.Approval;
                        mapper.Map(model, permissionDemand);
                        return await permissionRepository.CreateAsync(permissionDemand);
                    }
                    else if (lastPermisson.FinishDate.Value.AddDays(550) < model.BeginingDate)
                    {
                        PermissionDemand permissionDemand = new PermissionDemand();
                        
                        model.Status = Status.Approval;
                        mapper.Map(model, permissionDemand);
                        return await permissionRepository.CreateAsync(permissionDemand);
                    }
                    else
                    {

                        throw new Exception("It appears you do not have permission.");
                    }

                }
            }
            else if (model.FemalePermissionType == FemalePermissionType.AnnualPaidLeave || model.MalePermissionType == MalePermissionType.AnnualPaidLeave)
            {
                var appUser = await userManager.FindByIdAsync(userId.ToString());

                if (appUser == null)
                {
                    throw new Exception("User can not found.");
                }

                else if (appUser.WorkStartDate.AddYears(1) <= model.BeginingDate)
                {

                    var userActivePermissionDemands = await ListPermissionActiveUserId((int)model.AppUserId);
                    int activePermission = userActivePermissionDemands.Sum(x => (int)(x.FinishDate - x.BeginingDate).TotalDays);

                    var userApprovalPermissionDemands = await ListPermissionApprovalUserId((int)model.AppUserId);
                    int approvalPermission = userApprovalPermissionDemands.Sum(x => (int)(x.FinishDate - x.BeginingDate).TotalDays);

                    int totalPermission = activePermission + approvalPermission;

                    if (365 < (int)(DateTime.Now - appUser.WorkStartDate).TotalDays && (int)(DateTime.Now - appUser.WorkStartDate).TotalDays < 1825)
                    {
                        if (totalPermission >= 15)
                        {
                            throw new Exception("It appears you do not have permission.");
                        }
                        else
                        {
                            PermissionDemand permissionDemandd = new PermissionDemand();

                            model.Status = Status.Approval;
                            mapper.Map(model, permissionDemandd);
                            return await permissionRepository.CreateAsync(permissionDemandd);
                        }
                    }

                    else if ((int)(DateTime.Now - appUser.WorkStartDate).TotalDays >= 1825 && 5475 > (int)(DateTime.Now - appUser.WorkStartDate).TotalDays)
                    {
                        if (totalPermission >= 20)
                        {
                            throw new Exception("It appears you do not have permission.");
                        }
                        else
                        {
                            PermissionDemand permissionDemandd = new PermissionDemand();

                            model.Status = Status.Approval;
                            mapper.Map(model, permissionDemandd);
                            return await permissionRepository.CreateAsync(permissionDemandd);
                        }

                    }
                    else if (5475 <= (int)(DateTime.Now - appUser.WorkStartDate).TotalDays)
                    {
                        if (totalPermission >= 26)
                        {
                            throw new Exception("It appears you do not have permission.");
                        }
                        else
                        {
                            PermissionDemand permissionDemandd = new PermissionDemand();

                            model.Status = Status.Approval;
                            mapper.Map(model, permissionDemandd);
                            return await permissionRepository.CreateAsync(permissionDemandd);
                        }
                    }
                    else
                    {
                        var lastPermisson = await permissionRepository.FindByInlclueAppUserAnnualPermission(appUser.Id);

                        PermissionDemand permissionDemand = new PermissionDemand();

                        model.Status = Status.Approval;
                        mapper.Map(model, permissionDemand);
                        return await permissionRepository.CreateAsync(permissionDemand);
                    }
                }

                else
                {
                    throw new Exception("It appears you do not have permission.");
                }
            }

            else
            {
                PermissionDemand permissionDemand = new PermissionDemand();

                model.Status = Status.Approval;
                mapper.Map(model, permissionDemand);
                return await permissionRepository.CreateAsync(permissionDemand);
            }
        }
    }
}



