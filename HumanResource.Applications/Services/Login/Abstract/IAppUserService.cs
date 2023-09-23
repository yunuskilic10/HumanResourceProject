using HumanResource.Applications.Models.DTOs.LoginDTO;
using HumanResource.Applications.Models.DTOs.MailDTO;
using HumanResource.Domain.Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.Applications.Services.Login.Abstract
{
    public interface IAppUserService
    {
        Task<SignInResult> LoginAsync(LoginDTO model);
        Task LogOutAsync();
        Task<AppUser> ConfirmEmail(MailDTO mailDTO);
        Task<AppUser> UpdateCodeAsync(MailDTO mailDTO);

    }
}
