using HumanResource.Applications.Models.DTOs.DepartmendDTO;
using HumanResource.Applications.Models.DTOs.JobDTO;
using HumanResource.Applications.Models.DTOs.PersonnelDTO;
using HumanResource.Applications.Services.Admin.Abstact;
using HumanResource.Applications.Services.Admin.Concrete;
using HumanResource.Applications.Services.Personnel.Abstract;
using HumanResource.Domain.Entities.Concrete;
using HumanResource.Domain.Enums;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Org.BouncyCastle.Ocsp;
using System.Collections.Generic;
using System.Data;

namespace HumanResource.PresentationLayer.Areas.CompanyManager.Controllers
{
    [Area("CompanyManager")]
    [Authorize(Roles = "CompanyManager")]
    public class ManagerTransectionController : Controller
    {
        private readonly UserManager<AppUser> userManager;
        private readonly IPersonnelService personnelService;
        private readonly IDepartmendService departmendService;
        private readonly IJobService jobService;
        private readonly ICompanyService companyService;

        public ManagerTransectionController(UserManager<AppUser> userManager, IPersonnelService personnelService, IDepartmendService departmendService, IJobService jobService, ICompanyService companyService)
        {
            this.userManager = userManager;
            this.personnelService = personnelService;
            this.departmendService = departmendService;
            this.jobService = jobService;
            this.companyService = companyService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> CreateDepartmend()
        {
            CreateDepartmendDTO model = new CreateDepartmendDTO();
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> CreateDepartmend(CreateDepartmendDTO model)
        {
            if (ModelState.IsValid)
            {
                var id = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
                AppUser appUser = await userManager.FindByIdAsync(id);
                var result = await departmendService.CreateDepartmendPost(model, (int)appUser.CompanyId);

                if (result)
                {
                    return RedirectToAction("DepartmendList", "ManagerTransection", new { area = "CompanyManager" });
                }
            }

            return View(model);
        }

        public async Task<IActionResult> DepartmendList()
        {
            var id = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
            AppUser appUser = await userManager.FindByIdAsync(id);
            var list = await departmendService.ListDepartmend((int)appUser.CompanyId);
            return View(list);
        }

        public async Task<IActionResult> CreateJob(int id)
        {
            var sid = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
            AppUser appUser = await userManager.FindByIdAsync(sid);
            CreateJobDTO model = new();
            //model.Department.CompanyId = appUser.CompanyId;
            model.Department = appUser.Department;
            model.DepartmentId = id;
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> CreateJob(CreateJobDTO model)
        {
            if (ModelState.IsValid)
            {
                Department department = await departmendService.GetByIdAsync((int)model.DepartmentId);
                var id = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
                AppUser appUser = await userManager.FindByIdAsync(id);
                Company company = await companyService.GetByIdAsync((int)appUser.CompanyId);
                department.CompanyId = company.Id;
                department.Company = company;
                model.Department = department;
                model.DepartmentId = department.Id;
                var result = await jobService.CreateJobPost(model, (int)model.DepartmentId);

                if (result)
                {
                    return RedirectToAction("Summary", "ManagerMain", new { area = "CompanyManager" });
                }
            }

            return View(model);
        }

        public async Task<IActionResult> Joblist()
        {
            var managerid = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
            AppUser appUser = await userManager.FindByIdAsync(managerid);

            var list = await jobService.AllJobList((int)appUser.CompanyId);
            return View(list);
        }

        public async Task<IActionResult> CreatePersonnel(int id, int depid)
        {
            var sid = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
            AppUser appUser = await userManager.FindByIdAsync(sid);
            CreateDTO createDTO = new CreateDTO();
            createDTO.CompanyId = appUser.CompanyId;

            Job job = await jobService.GetByIdAsync(id);
            createDTO.Job = job;
            createDTO.JobId = id;
            createDTO.Job.DepartmentId = depid;
            Department department = await departmendService.GetByIdAsync(depid);
            createDTO.Department = department;
            createDTO.DepartmentId = depid;

            var gender = GetEnumSelectList<Gender>();
            ViewBag.Gender = gender;
            return View(createDTO);
        }

        [HttpPost]
        public async Task<IActionResult> CreatePersonnel(CreateDTO model, int depid, int id)
        {
            if (ModelState.IsValid)
            {
                var sid = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
                AppUser appUser = await userManager.FindByIdAsync(sid);
                AppUser appuser2 = new();
                model.Id = appuser2.Id;
                model.CompanyId = appUser.CompanyId;

                Job job = await jobService.GetByIdAsync(id);
                model.Job = job;
                model.JobId = id;
                depid = (int)model.Job.DepartmentId;

                Department department = await departmendService.GetByIdAsync(depid);
                model.Department = department;
                model.DepartmentId = depid;
                try
                {
                    var result = await personnelService.CreatePersonnelPost(model, (int)model.CompanyId, (int)model.DepartmentId, (int)model.JobId);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Joblist", "ManagerTransection", new { area = "CompanyManager" });
                    }
                }
                catch (Exception ex)
                {

                    ModelState.AddModelError("", ex.Message);
                }
            }
            var gender = GetEnumSelectList<Gender>();
            ViewBag.Gender = gender;
            return View(model);

        }

        public async Task<IActionResult> PersonnelList(int id)
        {

            var managerid = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
            AppUser appUser = await userManager.FindByIdAsync(managerid);

            var list = await personnelService.GetPersonelList((int)appUser.CompanyId, id);
            var department = await departmendService.GetByIdAsync(id);
            ViewBag.departmentName = department.Name;
            return View(list);
        } 
        public async Task<IActionResult> PersonnelJobList(int id)
        {

            var managerid = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
            AppUser appUser = await userManager.FindByIdAsync(managerid);

            var list = await personnelService.GetPersonelJobList((int)appUser.CompanyId, id);
            var job = await jobService.GetByIdAsync(id);
            ViewBag.jobName = job.Name;
            return View(list);
        }
        public async Task<IActionResult> AllPersonnelList()
        {

            var managerid = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
            AppUser appUser = await userManager.FindByIdAsync(managerid);
            var list = await personnelService.GetCompanyPersonels((int)appUser.CompanyId);
            return View(list);
        }
        public async Task<IActionResult> PersonnelDetails(int id)
        {

            return View(await personnelService.DetailPost(id));
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
    }
}
