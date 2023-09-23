using AutoMapper;
using HumanResource.Applications.Models.DTOs.AdvanceDTO;
using HumanResource.Applications.Models.DTOs.PermissonDTO;
using HumanResource.Applications.Services.Personnel.Abstract;
using HumanResource.Domain.Entities.Concrete;
using HumanResource.Domain.Enums;
using HumanResource.Domain.Repositories.Concrete;
using HumanResource.Infrastructure.Repositories.Concrete;
using Microsoft.AspNetCore.Identity;
using Org.BouncyCastle.Math.EC.Rfc7748;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.Applications.Services.Personnel.Concrete
{
    public class AdvanceService : IAdvanceService
    {
        private readonly IAdvanceRepository advanceRepository;
        private readonly IMapper mapper;
        private readonly UserManager<AppUser> userManager;

        public AdvanceService(IAdvanceRepository advanceRepository, IMapper mapper, UserManager<AppUser> userManager)
        {
            this.advanceRepository = advanceRepository;
            this.mapper = mapper;
            this.userManager = userManager;

        }

        public async Task<bool> ActiveAdvancePost(int Id)
        {
            return  await advanceRepository.AcceptToAsync(Id);

        }
        public async Task<bool> PassiveAdvancePost(int Id)
        {
            return await advanceRepository.PassiveToAsync(Id);
        }

        public Task CreateAdvance()
        {
            throw new NotImplementedException();
        }

        public async Task<bool> CreateAdvancePost(CreateAdvanceDTO model)
        {
            AdvanceDemand advanceDemand = new AdvanceDemand();

            model.Status = Status.Approval;
            mapper.Map(model, advanceDemand);
            return await advanceRepository.CreateAsync(advanceDemand);
        }

        public bool DeleteAdvance(int Id)
        {

            AdvanceDemand advanceDemand = advanceRepository.FindByInlclueAppUser(Id).Result;
            return advanceRepository.Delete(advanceDemand.Id);

        }

        public async Task<ICollection<ListAdvanceDTO>> ListAdvance(int Id)
        {
            var advanceRequestList = await advanceRepository.GetAll(Id);
            var listAdvanceDTOs = mapper.Map<List<ListAdvanceDTO>>(advanceRequestList);

            return listAdvanceDTOs;
        }

        public async Task<ICollection<ListAdvanceDTO>> ListAdvanceActive(Expression<Func<ListAdvanceDTO, bool>> predicate)
        {
            var listAdvanceActive = await advanceRepository.GetAllActiveAsync(x => x.Status == Status.Active);
            var listAdvanceActiveDTO = mapper.Map<List<ListAdvanceDTO>>(listAdvanceActive);
            return listAdvanceActiveDTO;
        }

        public async Task<ICollection<ListAdvanceDTO>> ListAdvanceApproval(Expression<Func<ListAdvanceDTO, bool>> predicate)
        {
            var listAdvanceApproval = await advanceRepository.GetAllApprovalAsync(x => x.Status == Status.Approval);
            var listAdvanceApprovalDTO = mapper.Map<List<ListAdvanceDTO>>(listAdvanceApproval);
            return listAdvanceApprovalDTO;
        }

        public async Task<ICollection<ListAdvanceDTO>> ListAdvancePassive(Expression<Func<ListAdvanceDTO, bool>> predicate)
        {
            var listAdvancePassive = await advanceRepository.GetAllPassiveAsync(x => x.Status == Status.Passive);
            var listAdvancePassiveDTO = mapper.Map<List<ListAdvanceDTO>>(listAdvancePassive);
            return listAdvancePassiveDTO;
        }

        public async Task<ICollection<ListAdvanceDTO>> ListAdvanceInculudeUser(int Id)
        {
            var listAdvanceUserList = await advanceRepository.FindByInlclueAppUserList(Id);
            var listAdvancePassiveDTO = mapper.Map<List<ListAdvanceDTO>>(listAdvanceUserList);

            return listAdvancePassiveDTO;
        }

        public async Task<ICollection<ListAdvanceDTO>> ListAdvanceActiveInculudeUser(int Id)
        {
            var listAdvanceActiveUserList = await advanceRepository.FindByInlclueAppUserApprovelList(Id);
            var listAdvanceActiveDTO = mapper.Map<List<ListAdvanceDTO>>(listAdvanceActiveUserList);

            return listAdvanceActiveDTO;
        }

       public async Task<bool> CreateAdvance2(CreateAdvanceDTO model, int userId)
        {
            if (model.AdvanceType == AdvanceType.Individual)
            {
                var appUser = await userManager.FindByIdAsync(userId.ToString());



                if (model.Price < (appUser.Salary * 3))
                {
                    var userAdvanceDemands = await ListAdvanceInculudeUser(appUser.Id);
                    var userActiveAdvanceDemands = await ListAdvanceActiveInculudeUser(appUser.Id);
                    decimal TotalPrice = userAdvanceDemands.Sum(x => x.Price);
                    decimal TotalActivePricee = userActiveAdvanceDemands.Sum(x => x.Price);



                    if ((TotalPrice + model.Price + TotalActivePricee) > (appUser.Salary * 3))
                    {
                        throw new Exception("Your annual advance has been exceeded.");
                    }



                    else
                    {
                        AdvanceDemand advanceDemand = new AdvanceDemand();
                        model.Status = Status.Approval;
                        mapper.Map(model, advanceDemand);
                        return await advanceRepository.CreateAsync(advanceDemand);
                    }
                }
                else
                {
                    throw new Exception("Your annual advance has been exceeded.");
                }
            }
            else
            {
                AdvanceDemand advanceDemand = new AdvanceDemand();
                model.Status = Status.Approval;
                mapper.Map(model, advanceDemand);
                return await advanceRepository.CreateAsync(advanceDemand);
            }
        }
    }
}
