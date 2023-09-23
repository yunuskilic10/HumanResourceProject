using HumanResource.Applications.Models.DTOs.LoginDTO;
using HumanResource.Applications.Models.DTOs.MailDTO;
using HumanResource.Applications.Services.Login.Abstract;
using HumanResource.Domain.Entities.Concrete;
using HumanResource.Domain.Repositories.Abstract;
using HumanResource.Domain.Repositories.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.Applications.Services.Login.Concrete
{
    public class AppUserService : IAppUserService
    {
        private readonly SignInManager<AppUser> signInManager;
        private readonly UserManager<AppUser> userManager;
        private readonly IPersonnelRepository appUserRepository;

        public AppUserService(SignInManager<AppUser> signInManager, UserManager<AppUser> userManager, IPersonnelRepository appUserRepository)
        {
            this.signInManager = signInManager;
            this.userManager = userManager;
            this.appUserRepository = appUserRepository;
        }

        public async Task<AppUser> ConfirmEmail(MailDTO mailDTO)
        {
            AppUser appUser = await userManager.FindByEmailAsync(mailDTO.Email);
            if (appUser == null)
            {
                throw new Exception("User not found");
            }
            else
            {
                return appUser;

            }
        }

        public async Task<SignInResult> LoginAsync(LoginDTO model)
        {
            return await signInManager.PasswordSignInAsync(model.Email, model.Password, false, false);
        }

        public async Task LogOutAsync()
        {
            await signInManager.SignOutAsync();
        }

        public async Task<AppUser> UpdateCodeAsync(MailDTO mailDTO)
        {
            AppUser appUser = await userManager.FindByEmailAsync(mailDTO.Email);
            appUser.ConfirmCode = mailDTO.ConfirmCode;
            if (await appUserRepository.UpdateAsync(appUser))
            {
                return appUser;
            }
            else
            {
                throw new Exception("User not updated");
            }
        }
    }
}
