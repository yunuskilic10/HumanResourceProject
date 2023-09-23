using HumanResource.Applications.Models.DTOs.AdvanceDTO;
using HumanResource.Applications.Models.DTOs.DemandDTO;
using HumanResource.Applications.Models.DTOs.PermissonDTO;
using HumanResource.Applications.Services.Personnel.Abstract;
using HumanResource.Applications.Services.Personnel.Concrete;
using HumanResource.Domain.Entities.Concrete;
using HumanResource.Domain.Enums;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections;
using System.Drawing;

namespace HumanResource.PresentationLayer.Areas.Personnel.Controllers
{
    [Area("Personnel")]
    [Authorize(Roles = "Personnel")]
    public class TransectionController : Controller
    {
        private readonly IDemandService demandService;
        private readonly IPermissionService permissionService;
        private readonly IAdvanceService advanceService;
        private readonly UserManager<AppUser> userManager;

        public TransectionController(IDemandService demandService, IPermissionService permissionService, IAdvanceService advanceService, UserManager<AppUser> userManager)
        {
            this.demandService = demandService;
            this.permissionService = permissionService;
            this.advanceService = advanceService;
            this.userManager = userManager;
        }
        public async Task<IActionResult> DemandList()
        {
            var id = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
            AppUser appUser = await userManager.FindByIdAsync(id);
            ICollection<ListDemandDTO> listDemandDTOs = await demandService.ListDemand(appUser.Id);
            return View(listDemandDTOs);
        }

        [HttpPost]
        public async Task<IActionResult> DemandList(int id)
        {
            bool isDeleted = demandService.DeleteDemandPost(id);
            if (isDeleted)
            {
                TempData["Info"] = "Demand deletion process succesfull";
            }
            else
            {
                TempData["Info"] = "Demand could not be deleted";
            }
            return RedirectToAction("DemandList", "Transection", new { area = "Personnel" });
        }

        public IActionResult AddDemand()
        {
            var currencySelectList = GetEnumSelectList<Currency>();
            ViewBag.Currency = currencySelectList;
            var demandTypeSelectList = GetEnumSelectList<DemandType>();
            ViewBag.DemandType = demandTypeSelectList;
            CreateDemandDTO createDemandDTO = new();
            return View(createDemandDTO);
        }

        [HttpPost]
        public async Task<IActionResult> AddDemand(CreateDemandDTO createDemandDTO)
        {
            if (ModelState.IsValid)
            {
                var id = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
                AppUser appUser = await userManager.FindByIdAsync(id);
                createDemandDTO.AppUserId = appUser.Id;
                if (await demandService.CreateDemandPost(createDemandDTO))
                {
                    return RedirectToAction("DemandList", "Transection", new { area = "Personnel" });
                }
            }
            var currencySelectList = GetEnumSelectList<Currency>();
            ViewBag.Currency = currencySelectList;
            var demandTypeSelectList = GetEnumSelectList<DemandType>();
            ViewBag.DemandType = demandTypeSelectList;
            return View(createDemandDTO);
        }

        private static SelectList GetEnumSelectList<TEnum>()
        {
            var enumType = typeof(TEnum);

            if (!enumType.IsEnum)
            {
                throw new ArgumentException($"{enumType.Name} is not an enum type.");
            }

            var enumValues = Enum.GetValues(enumType).Cast<TEnum>().ToList();
            var selectList = new SelectList(enumValues);

            return selectList;
        }

        //Permission

        public async Task<IActionResult> PermissionList()
        {
            var id = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
            AppUser appUser = await userManager.FindByIdAsync(id);
            ICollection<ListPermissionDTO> listPermissionDTOs = await permissionService.ListPermission(appUser.Id);
            return View(listPermissionDTOs);
        }

        [HttpPost]
        public async Task<IActionResult> PermissionList(int id)
        {
            bool isDeleted = permissionService.DeletePermission(id);
            if (isDeleted)
            {
                TempData["Info"] = "Permission deletion process succesfull";
            }
            else
            {
                TempData["Info"] = "Permission could not be deleted";
            }
            return RedirectToAction("PermissionList", "Transection", new { area = "Personnel" });
        }

        public IActionResult AddPermission()
        {
            var maleSelectList = GetEnumSelectList<MalePermissionType>();
            ViewBag.MalePermissionType = maleSelectList;
            var femaleSelectList = GetEnumSelectList<FemalePermissionType>();
            ViewBag.FemalePermissionType = femaleSelectList;
            CreatePermissionDTO createPermissionDTO = new();
            var id = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
            AppUser appUser = userManager.FindByIdAsync(id).Result;
            createPermissionDTO.AppUser = appUser;
            return View(createPermissionDTO);
        }

        [HttpPost]
        public async Task<IActionResult> AddPermission(CreatePermissionDTO createPermissionDTO)
        {
             if (ModelState.IsValid)
            {
                var id = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
                AppUser appUser = await userManager.FindByIdAsync(id);
                createPermissionDTO.AppUserId = appUser.Id;
                createPermissionDTO.AppUser = appUser;
                try
                {
                    if (await permissionService.CreatePermission2(createPermissionDTO, appUser.Id))

                    {
                        return RedirectToAction("PermissionList", "Transection", new { area = "Personnel" });
                    }




                }
                catch (Exception ex)

                {

                    ModelState.AddModelError("", ex.Message);

                }


            }


            var maleSelectList = GetEnumSelectList<MalePermissionType>();
            ViewBag.MalePermissionType = maleSelectList;
            var femaleSelectList = GetEnumSelectList<FemalePermissionType>();
            ViewBag.FemalePermissionType = femaleSelectList;
            return View(createPermissionDTO);
        }


        //Advance

        public async Task<IActionResult> AdvanceList()
        {
            var id = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
            AppUser appUser = await userManager.FindByIdAsync(id);
            ICollection<ListAdvanceDTO> listAdvanceDTOs = await advanceService.ListAdvance(appUser.Id);
            return View(listAdvanceDTOs);
        }

        [HttpPost]
        public async Task<IActionResult> AdvanceList(int id)
        {
            bool isDeleted = advanceService.DeleteAdvance(id);
            if (isDeleted)
            {
                TempData["Info"] = "Advance deletion process succesfull";
            }
            else
            {
                TempData["Info"] = "Advance could not be deleted";
            }
            return RedirectToAction("AdvanceList", "Transection", new { area = "Personnel" });
        }

        public IActionResult AddAdvance()
        {
            var advanceSelectList = GetEnumSelectList<AdvanceType>();
            ViewBag.AdvanceType = advanceSelectList;
            var currencySelectList = GetEnumSelectList<Currency>();
            //var tlcurrency = (ICollection)currencySelectList;
            //foreach (var item in tlcurrency)
            //{
            //    if(item==Currency.TL)
            //}
            ViewBag.Currency = currencySelectList;
            ViewBag.Tl = Currency.TL;
            CreateAdvanceDTO createAdvanceDTO = new();
            return View(createAdvanceDTO);
        }

        [HttpPost]
        public async Task<IActionResult> AddAdvance(CreateAdvanceDTO createAdvanceDTO)
        {

            if (ModelState.IsValid)

            {

                var id = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;

                AppUser appUser = await userManager.FindByIdAsync(id);

                createAdvanceDTO.AppUserId = appUser.Id;

                try

                {

                    if (await advanceService.CreateAdvance2(createAdvanceDTO, appUser.Id))
                    {

                        return RedirectToAction("AdvanceList", "Transection", new { area = "Personnel" });

                    }


                }

                catch (Exception ex)

                {

                    ModelState.AddModelError("", ex.Message);

                }



            }
            var advanceSelectList = GetEnumSelectList<AdvanceType>();
            ViewBag.AdvanceType = advanceSelectList;
            var currencySelectList = GetEnumSelectList<Currency>();
            ViewBag.Currency = currencySelectList;
            return View(createAdvanceDTO);
        }

    }
}

