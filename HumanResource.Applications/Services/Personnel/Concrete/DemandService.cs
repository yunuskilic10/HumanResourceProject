using AutoMapper;
using HumanResource.Applications.Models.DTOs.AdvanceDTO;
using HumanResource.Applications.Models.DTOs.DemandDTO;
using HumanResource.Applications.Services.Personnel.Abstract;
using HumanResource.Domain.Entities.Concrete;
using HumanResource.Domain.Enums;
using HumanResource.Domain.Repositories.Concrete;
using HumanResource.Infrastructure.Repositories.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.Applications.Services.Personnel.Concrete
{
    public class DemandService : IDemandService
    {
        private readonly IDemandRepository demandRepository;
        private readonly IMapper mapper;
        private readonly UserManager<AppUser> userManager;

        public DemandService(IDemandRepository demandRepository, IMapper mapper,UserManager<AppUser> userManager)
        {
            this.demandRepository = demandRepository;
            this.mapper = mapper;
            this.userManager = userManager;
        }

        public async Task<bool> ActiveDemandPost(int Id)
        {
            return await demandRepository.AcceptToAsync(Id);
        }

        public Task CreateDemand()
        {
            throw new NotImplementedException();
        }

        public async Task<bool> CreateDemandPost(CreateDemandDTO model)
        {
            SalaryRequest salaryRequest = new();

            if (model.DemandFile != null)                                                // Yeni resim seçilmişse
            {
                string newFileName = model.DemandFile.FileName;

                FileStream fs = new FileStream("wwwroot/Bills/" + newFileName, FileMode.Create);
                await model.DemandFile.CopyToAsync(fs);
                model.BillExtension = newFileName;
                salaryRequest.BillExtension = model.BillExtension;
            }
            else if (model.DemandFile == null && !string.IsNullOrEmpty(salaryRequest.BillExtension))
            {
                model.BillExtension = salaryRequest.BillExtension;                                           // Mevcut resmi koru
            }
            model.Status = Status.Approval;
            mapper.Map(model, salaryRequest);
            return await demandRepository.CreateAsync(salaryRequest);

        }

        public bool DeleteDemandPost(int Id)
        {
            SalaryRequest salaryRequest = demandRepository.FindByInlclueAppUser(Id).Result;
            return demandRepository.Delete(salaryRequest.Id);

        }

        public async Task<ICollection<ListDemandDTO>> ListDemand(int Id)
        {
            var salaryRequestList = await demandRepository.GetAll(Id);
            var listDemandDTOs = mapper.Map<List<ListDemandDTO>>(salaryRequestList);
            return listDemandDTOs;
        }

        public async Task<ICollection<ListDemandDTO>> ListDemandActive(Expression<Func<ListDemandDTO, bool>> predicate)
        {
            var listDemandActive = await demandRepository.GetAllActiveAsync(x=> x.Status == Status.Active);
            var listDemandActiveDTO = mapper.Map<List<ListDemandDTO>>(listDemandActive);
            return listDemandActiveDTO;
        }

        public async Task<ICollection<ListDemandDTO>> ListDemandApproval(Expression<Func<ListDemandDTO, bool>> predicate)
        {
            var listDemandApproval = await demandRepository.GetAllApprovalAsync(x => x.Status == Status.Approval);
            var listDemandApprovalDTO = mapper.Map<List<ListDemandDTO>>(listDemandApproval);
            return listDemandApprovalDTO;
        }

        public async Task<ICollection<ListDemandDTO>> ListDemandPassive(Expression<Func<ListDemandDTO, bool>> predicate)
        {
            var listDemandPassive = await demandRepository.GetAllPassiveAsync(x => x.Status == Status.Passive);
            var listDemandPassiveDTO = mapper.Map<List<ListDemandDTO>>(listDemandPassive);
            return listDemandPassiveDTO;
        }

        public async Task<bool> PassiveDemandPost(int Id)
        {
            return await demandRepository.PassiveToAsync(Id);
        }
    }
}
