using Autofac;
using Autofac.Extensions.DependencyInjection;
using HumanResource.Applications.IoC;
using FluentValidation.AspNetCore;
using HumanResource.Domain.Entities.Concrete;
using HumanResource.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using HumanResource.PresentationLayer.Utility;
using HumanResource.Applications.Extensions.Curency;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var connectionString = builder.Configuration.GetConnectionString("ConnStr");
builder.Services.AddDbContext<HumanResourceDB>(options =>
    options.UseSqlServer(connectionString));


builder.Services.AddHttpContextAccessor();

builder.Services.AddIdentity<AppUser, AppRole>(options => options.SignIn.RequireConfirmedAccount = false).AddEntityFrameworkStores<HumanResourceDB>();

builder.Host.ConfigureDefaults(args)
    .ConfigureHostConfiguration(hostConfig =>
    {
        hostConfig.SetBasePath(Directory.GetCurrentDirectory());
        hostConfig.AddJsonFile("hostsettings.json", optional: true);
        hostConfig.AddEnvironmentVariables(prefix: "PREFIX_");
        hostConfig.AddCommandLine(args);
    });


//Microsoftun otomatik hata mesajı yazmasının onune gectik
builder.Services.AddFluentValidation(x =>
{
    x.RegisterValidatorsFromAssemblyContaining<Program>();
    x.DisableDataAnnotationsValidation = true;
});


//Autofac Settings...
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
builder.Host.ConfigureContainer<ContainerBuilder>(builder =>
{
    builder.RegisterModule(new DependencyResolver());
});

// Default changes
builder.Services.ConfigureApplicationCookie(options =>
{
    options.Cookie.Name = "Identity";
    options.ExpireTimeSpan = TimeSpan.FromMinutes(5);
    options.LoginPath = "/Login/RequestTimeOut";
    options.SlidingExpiration = true;
    options.Cookie.HttpOnly = true;

});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

//Sablon*****
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );
});



//Personel Summary Actionınına Default olarak git
//app.UseEndpoints(endpoints =>
//{
//	endpoints.MapControllerRoute(
//		name: "personnel",
//		pattern: "{area}/{controller}/{action}/{id?}",
//		defaults: new { area = "Personnel", controller = "Main", action = "Summary" }
//	);
//});

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Login}/{action=Login}/{id?}");

//seed data çalışıp cloud database e veri geldiği için yorum satırına alındı

//var scope = app.Services.CreateScope();
//var userManager = (UserManager<AppUser>)scope.ServiceProvider.GetService(typeof(UserManager<AppUser>));
//SeedDataUser.AddPersonnel(userManager);


//app.UseCurrency();

app.Run();

