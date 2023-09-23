using HumanResource.Applications.Extensions.MailSender;
using HumanResource.Applications.Models.DTOs.LoginDTO;
using HumanResource.Applications.Models.DTOs.MailDTO;
using HumanResource.Applications.Services.Login.Abstract;
using HumanResource.Domain.Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HumanResource.PresentationLayer.Controllers
{
	[AllowAnonymous]

	public class LoginController : Controller
	{
		private readonly IAppUserService appUserService;
		private readonly SignInManager<AppUser> signInManager;
		private readonly UserManager<AppUser> userManager;
		Random rnd;
		public LoginController(IAppUserService appUserService, SignInManager<AppUser> signInManager, UserManager<AppUser> userManager)
		{
			this.appUserService = appUserService;
			this.signInManager = signInManager;
			this.userManager = userManager;
			rnd = new Random();
		}

		public IActionResult Login()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> Login(LoginDTO model)
		{
			if (ModelState.IsValid)
			{
				Microsoft.AspNetCore.Identity.SignInResult result = await appUserService.LoginAsync(model);
				if (result.Succeeded)
				{
					var user = await userManager.FindByEmailAsync(model.Email);
					if (await userManager.IsInRoleAsync(user, "Personnel"))
					{
						return RedirectToAction("Summary", "Main", new { area = "Personnel" });

					}
					else if (await userManager.IsInRoleAsync(user, "CompanyManager"))
					{
						return RedirectToAction("Summary", "ManagerMain", new { area = "CompanyManager" });

					}
					else if (await userManager.IsInRoleAsync(user, "Admin"))
					{
						return RedirectToAction("Summary", "AdminMain", new { area = "Admin" });

					}
					else
					{
						return RedirectToAction("NotFound", "Login", new { area = " " });
					}
				}
				else
				{
					ModelState.AddModelError("Error", "Email or Password incorrect");
				}
			}
			return View(model);
		}
		public async Task<IActionResult> ForgotPassword()
		{
			MailDTO mailDTO = new MailDTO();

			return View(mailDTO);
		}
		[HttpPost]
		public async Task<IActionResult> ForgotPassword(MailDTO mailDTO)
		{
			if (ModelState.IsValid)
			{
				try
				{
					AppUser appUser = await appUserService.ConfirmEmail(mailDTO);

					mailDTO.ConfirmCode = rnd.Next(100_000, 1_000_000);
					await appUserService.UpdateCodeAsync(mailDTO);

					SendMail.EmailSend(mailDTO.Email, "If you have  forgot your password, please enter the code sent to you.Dont share your code with anyone.\n\nNew confirm code:", mailDTO.ConfirmCode);
					 
					return RedirectToAction("ChangePassword", "Login", new { area = "", email = mailDTO.Email });
				}
				catch (Exception ex)
				{
					ModelState.AddModelError("Error", "Sending Code");
					return RedirectToAction("Login", "Login", new { area = "" });
				}
			}
			return View(mailDTO);
		}
		public async Task<IActionResult> ChangePassword(string email)
		{
			AppUser appUser = await userManager.FindByEmailAsync(email);
			ChangePasswordDTO changePasswordDTO = new ChangePasswordDTO();
			if (appUser == null)
			{
				ModelState.AddModelError("Error", "User not founded");
			}
			else
			{
				changePasswordDTO.Email = appUser.Email;
			}
			return View(changePasswordDTO);
		}
		[HttpPost]
		public async Task<IActionResult> ChangePassword(ChangePasswordDTO changePasswordDTO)
		{
			if (ModelState.IsValid)
			{
				AppUser appUser = await userManager.FindByEmailAsync(changePasswordDTO.Email);
				if (appUser == null)
				{
					ModelState.AddModelError("Error", "User not founded");
				}
				else
				{
					if (appUser.ConfirmCode == changePasswordDTO.ConfirmCode)
					{
						return RedirectToAction("NewPassword", "Login", new { area = " ", email = changePasswordDTO.Email });
					}
					else ModelState.AddModelError("Error", "Confirmation code does not match");
				}
			}
			return View(changePasswordDTO);
		}

		public async Task<IActionResult> NewPassword(string email)
		{
			AppUser appUser = await userManager.FindByEmailAsync(email);
			NewPasswordDTO newPasswordDTO = new NewPasswordDTO();
			if (appUser == null)
			{
				TempData["Info"] = "Your password not changed";
			}
			else
			{
				newPasswordDTO.Email = appUser.Email;
				newPasswordDTO.ConfirmCode = (int)appUser.ConfirmCode;
				return View(newPasswordDTO);
			}
			return RedirectToAction("Login", "Login", new { area = " " });
		}
		[HttpPost]
		public async Task<IActionResult> NewPassword(NewPasswordDTO newPasswordDTO)
		{
			if (ModelState.IsValid)
			{
				AppUser appUser = await userManager.FindByEmailAsync(newPasswordDTO.Email);
				if (appUser == null)
				{
					TempData["Info"] = "Your password not changed";
				}
				else
				{
					if (newPasswordDTO.Password == newPasswordDTO.ConfirmNewPassword)
					{
						appUser.Email = newPasswordDTO.Email;
						appUser.PasswordHash = userManager.PasswordHasher.HashPassword(appUser, newPasswordDTO.Password);
						IdentityResult result = await userManager.UpdateAsync(appUser);
						if (result.Succeeded)
						{
							TempData["Info"] = "Your password changed";
							return RedirectToAction("Login", "Login", new { area = " " });
						}
						else
						{
							ModelState.AddModelError("Error", "New error occured");
						}
					}
					else
					{
						ModelState.AddModelError("Error", "Passwords don't match");
					}
				}
			}
			return View(newPasswordDTO);
		}

		public async Task<IActionResult> SignOut()
		{
			await appUserService.LogOutAsync();
			TempData["UserLoggedOut"] = true;
			return RedirectToAction("LoginRepeat", "Login", new { area = " " });
		}
		[ResponseCache(NoStore = true, Location = ResponseCacheLocation.None, Duration = 0)]
		public IActionResult LoginRepeat()
		{
			if (TempData.ContainsKey("UserLoggedOut"))
			{
				TempData.Remove("UserLoggedOut");
				return View();
			}
			else
			{
				return RedirectToAction("RequestTimeOut", "Login", new { area = " " });
			}
		}
		public IActionResult RequestTimeOut()
		{
			return View();
		}
		public IActionResult NotFound()
		{
			return View();
		}
	}
}
