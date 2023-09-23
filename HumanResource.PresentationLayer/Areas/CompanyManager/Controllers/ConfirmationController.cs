using HumanResource.Applications.Models.DTOs.AdvanceDTO;
using HumanResource.Applications.Models.DTOs.DemandDTO;
using HumanResource.Applications.Models.DTOs.PermissonDTO;
using HumanResource.Applications.Services.Personnel.Abstract;
using HumanResource.Domain.Entities.Concrete;
using HumanResource.Domain.Enums;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace HumanResource.PresentationLayer.Areas.CompanyManager.Controllers
{
    [Area("CompanyManager")]
    [Authorize(Roles = "CompanyManager")]
    public class ConfirmationController : Controller
    {
        private readonly IDemandService demandService;
        private readonly IPermissionService permissionService;
        private readonly IAdvanceService advanceService;
        private readonly UserManager<AppUser> userManager;

        public ConfirmationController(IDemandService demandService, IPermissionService permissionService, IAdvanceService advanceService, UserManager<AppUser> userManager)
        {
            this.demandService = demandService;
            this.permissionService = permissionService;
            this.advanceService = advanceService;
            this.userManager = userManager;
        }

        public async Task<IActionResult> DemandActiveList()
        {

            ICollection<ListDemandDTO> listDemandDTOs = await demandService.ListDemandActive(x=> x.Status==Status.Active);
            return View(listDemandDTOs);
        }
   

        public async Task<IActionResult> DemandApprovalList()
        {
            ICollection<ListDemandDTO> listDemandDTOs = await demandService.ListDemandApproval(x => x.Status == Status.Approval);
            return View(listDemandDTOs);
        }
        public async Task<IActionResult> DemandPassiveList()
        {
            ICollection<ListDemandDTO> listDemandDTOs = await demandService.ListDemandPassive(x => x.Status == Status.Passive);
            return View(listDemandDTOs);
        }

        [HttpPost]
        public async Task<IActionResult> ApprovalToPassiveList(int id)
        {
            bool isDeleted = await demandService.PassiveDemandPost(id);
            if (isDeleted)
            {
                TempData["Info"] = "Demand deletion process succesfull";
            }
            else
            {
                TempData["Info"] = "Demand could not be deleted";
            }
            return RedirectToAction("DemandApprovalList", "Confirmation", new { area = "CompanyManager" });
        }

        [HttpPost]
        public async Task<IActionResult> ApprovalToActiveList(int id)
        {
            bool isActiveted = await demandService.ActiveDemandPost(id);
            if (isActiveted)
            {
                TempData["Info"] = "Demand activation process succesfull";
            }
            else
            {
                TempData["Info"] = "Demand could not be activated";
            }
            return RedirectToAction("DemandApprovalList", "Confirmation", new { area = "CompanyManager" });
        }

        //permission controller
        public async Task<IActionResult> PermissionActiveList()
        {
            ICollection<ListPermissionDTO> listPermissionDTOs = await permissionService.ListPermissionActive(x => x.Status == Status.Active);
            return View(listPermissionDTOs);
        }
        public async Task<IActionResult> PermissionApprovalList()
        {
            ICollection<ListPermissionDTO> listPermissionDTOs = await permissionService.ListPermissionApproval(x => x.Status == Status.Approval);
            return View(listPermissionDTOs);
        }
        public async Task<IActionResult> PermissionPassiveList()
        {
            ICollection<ListPermissionDTO> listPermissionDTOs = await permissionService.ListPermissionPassive(x => x.Status == Status.Passive);
            return View(listPermissionDTOs);
        }

        [HttpPost]
        public async Task<IActionResult> PermissionApprovalToPassiveList(int id)
        {
            bool isDeleted = await permissionService.PassivePermissionPost(id);
            if (isDeleted)
            {
                TempData["Info"] = "Permission deletion process succesfull";
            }
            else
            {
                TempData["Info"] = "Permission could not be deleted";
            }
            return RedirectToAction("PermissionApprovalList", "Confirmation", new { area = "CompanyManager" });
        }

        [HttpPost]
        public async Task<IActionResult> PermissionApprovalToActiveList(int id)
        {
            bool isActiveted = await permissionService.ActivePermissionPost(id);
            if (isActiveted)
            {
                TempData["Info"] = "Permission activation process succesfull";
            }
            else
            {
                TempData["Info"] = "Permission could not be activated";
            }
            return RedirectToAction("PermissionApprovalList", "Confirmation", new { area = "CompanyManager" });
        }

        //advance controller
        public async Task<IActionResult> AdvanceActiveList()
        {
            ICollection<ListAdvanceDTO> listAdvanceDTOs = await advanceService.ListAdvanceActive(x => x.Status == Status.Active);
            return View(listAdvanceDTOs);
        }
        public async Task<IActionResult> AdvanceApprovalList()
        {
            ICollection<ListAdvanceDTO> listAdvanceDTOs = await advanceService.ListAdvanceApproval(x => x.Status == Status.Approval);
            return View(listAdvanceDTOs);
        }
        public async Task<IActionResult> AdvancePassiveList()
        {
            ICollection<ListAdvanceDTO> listAdvanceDTOs = await advanceService.ListAdvancePassive(x => x.Status == Status.Passive);
            return View(listAdvanceDTOs);
        }

        [HttpPost]
        public async Task<IActionResult> AdvanceApprovalToPassiveList(int id)
        {
            bool isDeleted = await advanceService.PassiveAdvancePost(id);
            if (isDeleted)
            {
                TempData["Info"] = "Advance deletion process succesfull";
            }
            else
            {
                TempData["Info"] = "Advance could not be deleted";
            }
            return RedirectToAction("AdvanceApprovalList", "Confirmation", new { area = "CompanyManager" });
        }

        [HttpPost]
        public async Task<IActionResult> AdvanceApprovalToActiveList(int id)
        {
            bool isActiveted = await advanceService.ActiveAdvancePost(id);
            if (isActiveted)
            {
                TempData["Info"] = "Advance activation process succesfull";
            }
            else
            {
                TempData["Info"] = "Advance could not be activated";
            }
            return RedirectToAction("AdvanceApprovalList", "Confirmation", new { area = "CompanyManager" });
        }
    }
}
