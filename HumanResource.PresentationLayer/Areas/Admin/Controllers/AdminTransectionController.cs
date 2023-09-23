using HumanResource.Applications.Models.DTOs.AdminDTO;
using HumanResource.Applications.Models.DTOs.DemandDTO;
using HumanResource.Applications.Models.DTOs.PersonnelDTO;
using HumanResource.Applications.Services.Admin.Abstact;
using HumanResource.Applications.Services.Personnel.Abstract;
using HumanResource.Applications.Services.Personnel.Concrete;
using HumanResource.Domain.Entities.Concrete;
using HumanResource.Domain.Enums;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Data;

namespace HumanResource.PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class AdminTransectionController : Controller
    {
        private readonly ICompanyService companyService;
        private readonly IPersonnelService personnelService;
        private readonly UserManager<AppUser> userManager;

        public AdminTransectionController(ICompanyService companyService, IPersonnelService personnelService, UserManager<AppUser> userManager)
        {
            this.companyService = companyService;
            this.personnelService = personnelService;
            this.userManager = userManager;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult NewCompany()
        {
            var companyTypeList = GetEnumSelectList<CompanyType>();
            ViewBag.CompanyType = companyTypeList;
            var taxAdministrationTypeList = GetEnumSelectList<TaxAdminIsTrationType>();
            ViewBag.TaxType = taxAdministrationTypeList;
            AdminAddCompanyDTO adminAddCompanyDTO = new AdminAddCompanyDTO();
            return View(adminAddCompanyDTO);
        }

        [HttpPost]
        public async Task<IActionResult> NewCompany(AdminAddCompanyDTO adminAddCompanyDTO)
        {
            if (ModelState.IsValid)
            {

                try
                {

                    if (await companyService.CreateCompanyPost(adminAddCompanyDTO))
                    {
                        return RedirectToAction("CompanyList", "AdminTransection", new { area = "Admin" });
                    }
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", ex.Message);
                }
            }

            var companyTypeList = GetEnumSelectList<CompanyType>();
            ViewBag.CompanyType = companyTypeList;
            var taxAdministrationTypeList = GetEnumSelectList<TaxAdminIsTrationType>();
            ViewBag.TaxType = taxAdministrationTypeList;
            return View(adminAddCompanyDTO);
        }

        public async Task<IActionResult> CompanyList()
        {
            ICollection<AdminListCompanyDTO> companies = await companyService.GetListCompany();
            return View(companies);
        }

        public async Task<IActionResult> NewCompanyManager()
        {
            var companies = new SelectList(await companyService.GetListCompany(), "Id", "Name");
            ViewBag.CompanyList = companies;
            var gender = GetEnumSelectList<Gender>();
            ViewBag.Gender = gender;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> NewCompanyManager(CreateDTO model)
        {
            if (ModelState.IsValid)
            {
                try
                {

                    var result = await personnelService.CreateCompanyManagerPost(model);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("CompanyManagerList", "AdminTransection", new { area = "Admin" });
                    }


                }
                catch (Exception ex)
                {

                    ModelState.AddModelError("", ex.Message);
                }
            }
            var companies = new SelectList(await companyService.GetListCompany(), "Id", "Name");
            ViewBag.CompanyList = companies;
            var gender = GetEnumSelectList<Gender>();
            ViewBag.Gender = gender;
            return View(model);
        }
        public async Task<IActionResult> CompanyManagerList()
        {
            var roles = await personnelService.GetInRolePersonelList("CompanyManager");
            return View(roles);
        }
        public async Task<IActionResult> CompanyDetails(int id)
        {
            var companyDetails = await companyService.GetCompanyDetails(id);
            var companyPersonels = await personnelService.GetCompanyPersonels(id);
            int personelCount = companyPersonels.Count;
            ViewBag.PersonelCount = personelCount;
            return View(companyDetails);
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
        public async Task<IActionResult> PersonnelDetails(int id)
        {

            return View(await personnelService.DetailCompanyManagerPost(id));
        }
    }
}
