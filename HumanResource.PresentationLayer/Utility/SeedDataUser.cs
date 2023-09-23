using HumanResource.Domain.Entities.Concrete;
using Microsoft.AspNetCore.Identity;

namespace HumanResource.PresentationLayer.Utility
{
    public static class SeedDataUser
    {
        public static async void AddPersonnel(UserManager<AppUser> userManager)
        {
          
            AppUser user = new AppUser()
            {
                //mikrosoft;aksini söylemedikce Identity kullanımında mail adreslerini otomatik olarak user name kısmına atar
                //değiştirmek için Areas=> Identity=> register=> OnPost
                //devamı program cs de var ve burayı silebiliriz adminimiz oluştuktan sonra aynı şekilde program cs de de kaldırabiliriz
                FirstName = "Gökalp",
                LastName = "Güler",
                Gender = Domain.Enums.Gender.Male,
                EmailConfirmed = true,
                UserName = "gokalp.guler@bilgeadamboost.com",
                NormalizedUserName = "GOKALP.GULER@BILGEADAMBOOST.COM",
                Email = "gokalp.guler@bilgeadamboost.com",
                NormalizedEmail = "GOKALP.GULER@BILGEADAMBOOST.COM",
                BirthCity = "New York",
                BirthDate = new DateTime(1997, 10, 10),
                IdentityNumber = "11442602079",
                WorkStartDate = DateTime.Now,
                Salary = 500000,
                Status = Domain.Enums.Status.Active,
                JobId = 1,
                CompanyId = 1,
                DepartmentId = 1


            };
            await userManager.CreateAsync(user, "Gokalp123.");
            await userManager.AddToRoleAsync(user, "Personnel");


            AppUser user1 = new AppUser()
            {
                //mikrosoft;aksini söylemedikce Identity kullanımında mail adreslerini otomatik olarak user name kısmına atar
                //değiştirmek için Areas=> Identity=> register=> OnPost
                //devamı program cs de var ve burayı silebiliriz adminimiz oluştuktan sonra aynı şekilde program cs de de kaldırabiliriz
                FirstName = "Burak",
                SecondName = "Fatih",
                LastName = "Kılıçaslan",
                Gender = Domain.Enums.Gender.Male,
                EmailConfirmed = true,
                UserName = "burakfatih.kilicaslan@bilgeadamboost.com",
                NormalizedUserName = "BURAKFATIH.KILICASLAN@BILGEADAMBOOST.COM",
                Email = "burakfatih.kilicaslan@bilgeadamboost.com",
                NormalizedEmail = "BURAKFATIH.KILICASLAN@BILGEADAMBOOST.COM",
                BirthCity = "New York",
                BirthDate = new DateTime(1990, 10, 10),
                IdentityNumber = "11442602019",
                WorkStartDate = DateTime.Now,
                Salary = 500000,
                Status = Domain.Enums.Status.Active,
                JobId = 1,
                CompanyId = 1,
                DepartmentId = 1


            };
            await userManager.CreateAsync(user1, "Burak456.");
            await userManager.AddToRoleAsync(user1, "Admin");



            AppUser user2 = new AppUser()
            {
                //mikrosoft;aksini söylemedikce Identity kullanımında mail adreslerini otomatik olarak user name kısmına atar
                //değiştirmek için Areas=> Identity=> register=> OnPost
                //devamı program cs de var ve burayı silebiliriz adminimiz oluştuktan sonra aynı şekilde program cs de de kaldırabiliriz
                FirstName = "Yunus",
                LastName = "Kılıç",
                Gender = Domain.Enums.Gender.Male,
                EmailConfirmed = true,
                UserName = "yunus.kilic@bilgeadamboost.com",
                NormalizedUserName = "YUNUS.KILIC@BILGEADAMBOOST.COM",
                Email = "yunus.kilic@bilgeadamboost.com",
                NormalizedEmail = "YUNUS.KILIC@BILGEADAMBOOST.COM",
                BirthCity = "New York",
                BirthDate = new DateTime(1990, 10, 10),
                IdentityNumber = "11442202019",
                WorkStartDate = DateTime.Now,
                Salary = 500000,
                Status = Domain.Enums.Status.Active,
                JobId = 1,
                CompanyId = 1,
                DepartmentId = 1


            };
            await userManager.CreateAsync(user2, "Yunus123.");
            await userManager.AddToRoleAsync(user2, "Personnel");



            AppUser user3 = new AppUser()
            {
                //mikrosoft;aksini söylemedikce Identity kullanımında mail adreslerini otomatik olarak user name kısmına atar
                //değiştirmek için Areas=> Identity=> register=> OnPost
                //devamı program cs de var ve burayı silebiliriz adminimiz oluştuktan sonra aynı şekilde program cs de de kaldırabiliriz
                FirstName = "Nazlı",
                SecondName = "Merve",
                LastName = "Kılıç",
                Gender = Domain.Enums.Gender.Female,
                EmailConfirmed = true,
                UserName = "nazlimerve.koc@bilgeadamboost.com",
                NormalizedUserName = "NAZLIMERVE.KOC@BILGEADAMBOOST.COM",
                Email = "nazlimerve.koc@bilgeadamboost.com",
                NormalizedEmail = "NAZLIMERVE.KOC@BILGEADAMBOOST.COM",
                BirthCity = "New York",
                BirthDate = new DateTime(1990, 10, 10),
                IdentityNumber = "11442202011",
                WorkStartDate = DateTime.Now,
                Salary = 500000,
                Status = Domain.Enums.Status.Active,
                JobId = 1,
                CompanyId = 1,
                DepartmentId = 1


            };
            await userManager.CreateAsync(user3, "Nazli123.");
            await userManager.AddToRoleAsync(user3, "CompanyManager");


            AppUser user4 = new AppUser()
            {
                //mikrosoft;aksini söylemedikce Identity kullanımında mail adreslerini otomatik olarak user name kısmına atar
                //değiştirmek için Areas=> Identity=> register=> OnPost
                //devamı program cs de var ve burayı silebiliriz adminimiz oluştuktan sonra aynı şekilde program cs de de kaldırabiliriz
                FirstName = "Emre",
                LastName = "Karaömeroğlu",
                Gender = Domain.Enums.Gender.Male,
                EmailConfirmed = true,
                UserName = "emre.karaomeroglug@bilgeadamboost.com",
                NormalizedUserName = "EMRE.KARAOMEROGLUG@BILGEADAMBOOST.COM",
                Email = "emre.karaomeroglug@bilgeadamboost.com",
                NormalizedEmail = "EMRE.KARAOMEROGLUG@BILGEADAMBOOST.COM",
                BirthCity = "New York",
                BirthDate = new DateTime(1990, 10, 10),
                IdentityNumber = "11442202051",
                WorkStartDate = DateTime.Now,
                Salary = 500000,
                Status = Domain.Enums.Status.Active,
                JobId = 1,
                CompanyId = 1,
                DepartmentId = 1


            };
            await userManager.CreateAsync(user4, "Emre123.");
            await userManager.AddToRoleAsync(user4, "Personnel");
        }
    }
}
