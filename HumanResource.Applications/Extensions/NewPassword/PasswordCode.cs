using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.Applications.Extensions.NewPassword
{
    public static class PasswordCode
    {
        public static string CreatePassword(string psw)
        {
            Random rnd = new();
            string password = rnd.Next(1000, 9999).ToString();
            string createPassword = $"{psw.ToLower()}"+".A"+$"{password}"; 
            return createPassword;
        }
    }
}
