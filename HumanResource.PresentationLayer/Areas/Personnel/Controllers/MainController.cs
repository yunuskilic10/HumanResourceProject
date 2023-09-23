using HumanResource.Applications.Models.DTOs.PersonnelDTO;
using HumanResource.Applications.Services.Personnel.Abstract;
using HumanResource.Applications.Services.Personnel.Concrete;
using HumanResource.Domain.Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HumanResource.PresentationLayer.Areas.Personnel.Controllers
{
    [Area("Personnel")]
    [Authorize(Roles = "Personnel")]
    public class MainController : Controller
    {
        private readonly IPersonnelService personnelService;
        private readonly UserManager<AppUser> userManager;

        public MainController(IPersonnelService personnelService, UserManager<AppUser> userManager)
        {
            this.personnelService = personnelService;
            this.userManager = userManager;
        }
        public async Task<IActionResult> Summary()
        {
            var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
            AppUser appUser = await userManager.FindByIdAsync(userId);
            return View(await personnelService.SummaryPost(appUser.Id));
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
                return View(await personnelService.Update(id));
            }
            else
            {
                return View(await personnelService.Update(Convert.ToInt32(userId)));
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
                    return RedirectToAction("Summary", "Main");
                }
            }
            return View(model);
        }
    }
}
