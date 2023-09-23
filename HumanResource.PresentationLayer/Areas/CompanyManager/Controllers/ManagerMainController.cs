using HumanResource.Applications.Models.DTOs.PersonnelDTO;
using HumanResource.Applications.Services.Personnel.Abstract;
using HumanResource.Domain.Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace HumanResource.PresentationLayer.Areas.CompanyManager.Controllers
{
    [Area("CompanyManager")]
    [Authorize(Roles = "CompanyManager")]
    public class ManagerMainController : Controller
    {

        private readonly IPersonnelService personnelService;
        private readonly UserManager<AppUser> userManager;

        public ManagerMainController(IPersonnelService personnelService, UserManager<AppUser> userManager)
        {
            this.personnelService = personnelService;
            this.userManager = userManager;
        }
        public async Task<IActionResult> Summary()
        {
            var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
            AppUser appUser = await userManager.FindByIdAsync(userId);
            return View(await personnelService.SummaryCompanyPost(appUser.Id));
        }
        public async Task<IActionResult> Detail(int id)
        {
            var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
            if (id == Convert.ToInt32(userId))
            {
                return View(await personnelService.DetailPost(id));
            }
            else
            {
                return View(await personnelService.DetailPost(Convert.ToInt32(userId)));
            }
        }

        public async Task<IActionResult> Update(int id)
        {
            var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
            if (id == Convert.ToInt32(userId))
            {
                return View(await personnelService.ManagerUpdate(id));
            }
            else
            {
                return View(await personnelService.ManagerUpdate(Convert.ToInt32(userId)));
            }
        }
        [HttpPost]
        public async Task<IActionResult> Update(UpdateDTO model)
        {
            if (!ModelState.IsValid)
            {
                var errors = ModelState.Values.SelectMany(x => x.Errors).Select(y => y.ErrorMessage).ToList();
                ViewBag.Errors = errors;
            }
            else
            {
                if (await personnelService.UpdatePost(model))
                {
                    return RedirectToAction("Summary", "ManagerMain", new {area= "CompanyManager" });
                }
            }
            return View(model);
        }
    }
}
