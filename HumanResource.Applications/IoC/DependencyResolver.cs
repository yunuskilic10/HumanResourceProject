using Autofac;
using AutoMapper;
using FluentValidation;
using HumanResource.Applications.AutoMapper;
using HumanResource.Applications.Models.DTOs.AdminDTO;
using HumanResource.Applications.Models.DTOs.AdvanceDTO;
using HumanResource.Applications.Models.DTOs.DemandDTO;
using HumanResource.Applications.Models.DTOs.LoginDTO;
using HumanResource.Applications.Models.DTOs.MailDTO;
using HumanResource.Applications.Models.DTOs.PermissonDTO;
using HumanResource.Applications.Models.DTOs.PersonnelDTO;
using HumanResource.Applications.Services.Admin.Abstact;
using HumanResource.Applications.Services.Admin.Concrete;
using HumanResource.Applications.Services.Login.Abstract;
using HumanResource.Applications.Services.Login.Concrete;
using HumanResource.Applications.Services.Personnel.Abstract;
using HumanResource.Applications.Services.Personnel.Concrete;
using HumanResource.Applications.Validators.Advance;
using HumanResource.Applications.Validators.Company;
using HumanResource.Applications.Validators.CustomValidator;
using HumanResource.Applications.Validators.Demand;
using HumanResource.Applications.Validators.Login;
using HumanResource.Applications.Validators.Permission;
using HumanResource.Applications.Validators.Personnel;
using HumanResource.Domain.Repositories.Abstract;
using HumanResource.Domain.Repositories.Concrete;
using HumanResource.Infrastructure.Repositories.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace HumanResource.Applications.IoC
{
    public class DependencyResolver : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //Add Service
            builder.RegisterType<PersonnelService>().As<IPersonnelService>().InstancePerLifetimeScope();
            builder.RegisterType<AppUserService>().As<IAppUserService>().InstancePerLifetimeScope();
            builder.RegisterType<DemandService>().As<IDemandService>().InstancePerLifetimeScope();
            builder.RegisterType<PermissionService>().As<IPermissionService>().InstancePerLifetimeScope();
            builder.RegisterType<AdvanceService>().As<IAdvanceService>().InstancePerLifetimeScope();
            builder.RegisterType<CompanyService>().As<ICompanyService>().InstancePerLifetimeScope();
            builder.RegisterType<DepartmendService>().As<IDepartmendService>().InstancePerLifetimeScope();
            builder.RegisterType<JobService>().As<IJobService>().InstancePerLifetimeScope();





            //Add Repository
            builder.RegisterType<AppUserRepository>().As<IPersonnelRepository>().InstancePerLifetimeScope();
            builder.RegisterType<DemandRepository>().As<IDemandRepository>().InstancePerLifetimeScope();
            builder.RegisterType<PermissionRepository>().As<IPermissionRepository>().InstancePerLifetimeScope();
            builder.RegisterType<AdvanceRepository>().As<IAdvanceRepository>().InstancePerLifetimeScope();
            builder.RegisterType<CompanyRepository>().As<ICompanyRepository>().InstancePerLifetimeScope();
            builder.RegisterType<DepartmentRepository>().As<IDepartmentRepository>().InstancePerLifetimeScope();
            builder.RegisterType<JobRepository>().As<IJobRepository>().InstancePerLifetimeScope();

            //Add Validators
            builder.RegisterType<PersonnelUpdateValidator>().As<IValidator<UpdateDTO>>().InstancePerLifetimeScope();
            builder.RegisterType<NewPasswordValidator>().As<IValidator<NewPasswordDTO>>().InstancePerLifetimeScope();
            builder.RegisterType<MailValidator>().As<IValidator<MailDTO>>().InstancePerLifetimeScope();
            builder.RegisterType<LoginValidator>().As<IValidator<LoginDTO>>().InstancePerLifetimeScope();
            builder.RegisterType<ChangePasswordValidator>().As<IValidator<ChangePasswordDTO>>().InstancePerLifetimeScope();
            builder.RegisterType<CreateDemandValidator>().As<IValidator<CreateDemandDTO>>().InstancePerLifetimeScope();
            builder.RegisterType<CreateAdvanceValidator>().As<IValidator<CreateAdvanceDTO>>().InstancePerLifetimeScope();
            builder.RegisterType<CreatePermissionValidator>().As<IValidator<CreatePermissionDTO>>().InstancePerLifetimeScope();
            builder.RegisterType<PersonnelCreateValidator>().As<IValidator<CreateDTO>>().InstancePerLifetimeScope();
            builder.RegisterType<CompanyCreateValidator>().As<IValidator<AdminAddCompanyDTO>>().InstancePerLifetimeScope();



            //Add Mapper
            builder.Register(context => new MapperConfiguration(cfg =>
            {
                //Register Mapper Profile
                cfg.AddProfile<ResourceMapper>();
            }
           )).AsSelf().SingleInstance();



            builder.Register(c =>
            {
                //This resolves a new context that can be used later.
                var context = c.Resolve<IComponentContext>();
                var config = context.Resolve<MapperConfiguration>();
                return config.CreateMapper(context.Resolve);
            })
            .As<IMapper>()
            .InstancePerLifetimeScope();



            base.Load(builder);
        }
    }
}