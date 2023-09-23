﻿// <auto-generated />
using System;
using HumanResource.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HumanResource.Infrastructure.Migrations
{
    [DbContext(typeof(HumanResourceDB))]
    [Migration("20230829085655_newmig")]
    partial class newmig
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("HumanResource.Domain.Entities.Concrete.AppRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ConcurrencyStamp = "273e0e2b-d694-459d-af13-8a0d3a1970f8",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = 2,
                            ConcurrencyStamp = "9b9a7182-8a72-4d1d-98fb-2df7f6620ec8",
                            Name = "CompanyManager",
                            NormalizedName = "COMPANYMANAGER"
                        },
                        new
                        {
                            Id = 3,
                            ConcurrencyStamp = "04a9e13b-12c5-443f-acfd-abdb33369120",
                            Name = "Personnel",
                            NormalizedName = "PERSONNEL"
                        });
                });

            modelBuilder.Entity("HumanResource.Domain.Entities.Concrete.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("BirthCity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ConfirmCode")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdentityNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("JobId")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("PhotoFile")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("SecondLastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecondName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(2);

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<DateTime?>("WorkFinishDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("WorkStartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("JobId");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("HumanResource.Domain.Entities.Concrete.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(2);

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Companies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateDate = new DateTime(2023, 8, 29, 11, 56, 55, 144, DateTimeKind.Local).AddTicks(8183),
                            Name = "BilgeAdam Akademi"
                        },
                        new
                        {
                            Id = 2,
                            CreateDate = new DateTime(2023, 8, 29, 11, 56, 55, 144, DateTimeKind.Local).AddTicks(8186),
                            Name = "Neos Akademi"
                        },
                        new
                        {
                            Id = 3,
                            CreateDate = new DateTime(2023, 8, 29, 11, 56, 55, 144, DateTimeKind.Local).AddTicks(8188),
                            Name = "İstanbul Eğitim Akademi"
                        });
                });

            modelBuilder.Entity("HumanResource.Domain.Entities.Concrete.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CompanyId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(2);

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Departmants");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CompanyId = 1,
                            CreateDate = new DateTime(2023, 8, 29, 11, 56, 55, 145, DateTimeKind.Local).AddTicks(564),
                            Description = "Generate secure random user identities with hashed passwords and salts using this code snippet.",
                            Name = "IT"
                        },
                        new
                        {
                            Id = 2,
                            CompanyId = 2,
                            CreateDate = new DateTime(2023, 8, 29, 11, 56, 55, 145, DateTimeKind.Local).AddTicks(567),
                            Description = "Generate secure random user identities with hashed passwords and salts using this code snippet.",
                            Name = "IT"
                        },
                        new
                        {
                            Id = 3,
                            CompanyId = 3,
                            CreateDate = new DateTime(2023, 8, 29, 11, 56, 55, 145, DateTimeKind.Local).AddTicks(569),
                            Description = "Generate secure random user identities with hashed passwords and salts using this code snippet.",
                            Name = "IT"
                        },
                        new
                        {
                            Id = 4,
                            CompanyId = 1,
                            CreateDate = new DateTime(2023, 8, 29, 11, 56, 55, 145, DateTimeKind.Local).AddTicks(571),
                            Description = "Human Resources (HR) is a critical function that oversees personnel activities, including recruitment, training, benefits, and workplace policies.",
                            Name = "Human Resources"
                        },
                        new
                        {
                            Id = 5,
                            CompanyId = 2,
                            CreateDate = new DateTime(2023, 8, 29, 11, 56, 55, 145, DateTimeKind.Local).AddTicks(573),
                            Description = "Human Resources (HR) is a critical function that oversees personnel activities, including recruitment, training, benefits, and workplace policies.",
                            Name = "Human Resources"
                        },
                        new
                        {
                            Id = 6,
                            CompanyId = 3,
                            CreateDate = new DateTime(2023, 8, 29, 11, 56, 55, 145, DateTimeKind.Local).AddTicks(575),
                            Description = "Human Resources (HR) is a critical function that oversees personnel activities, including recruitment, training, benefits, and workplace policies.",
                            Name = "Human Resources"
                        },
                        new
                        {
                            Id = 7,
                            CompanyId = 1,
                            CreateDate = new DateTime(2023, 8, 29, 11, 56, 55, 145, DateTimeKind.Local).AddTicks(577),
                            Description = "The Services Department ensures efficient business operations by offering essential support functions such as customer assistance, technical help, maintenance, and issue resolution.",
                            Name = "Services Departmants"
                        },
                        new
                        {
                            Id = 8,
                            CompanyId = 2,
                            CreateDate = new DateTime(2023, 8, 29, 11, 56, 55, 145, DateTimeKind.Local).AddTicks(579),
                            Description = "The Services Department ensures efficient business operations by offering essential support functions such as customer assistance, technical help, maintenance, and issue resolution.",
                            Name = "Services Departmants"
                        },
                        new
                        {
                            Id = 9,
                            CompanyId = 3,
                            CreateDate = new DateTime(2023, 8, 29, 11, 56, 55, 145, DateTimeKind.Local).AddTicks(581),
                            Description = "The Services Department ensures efficient business operations by offering essential support functions such as customer assistance, technical help, maintenance, and issue resolution.",
                            Name = "Services Departmants"
                        });
                });

            modelBuilder.Entity("HumanResource.Domain.Entities.Concrete.Job", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(2);

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Jobs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateDate = new DateTime(2023, 8, 29, 11, 56, 55, 145, DateTimeKind.Local).AddTicks(3116),
                            DepartmentId = 1,
                            Description = "A Full Stack Developer is a versatile expert in both front-end and back-end web development.",
                            Name = "Full-Stack Developer"
                        },
                        new
                        {
                            Id = 2,
                            CreateDate = new DateTime(2023, 8, 29, 11, 56, 55, 145, DateTimeKind.Local).AddTicks(3119),
                            DepartmentId = 1,
                            Description = "Back-End Development focuses on building and maintaining the server-side components, databases, and APIs that drive the functionality of websites and applications.",
                            Name = "Back-End Developer"
                        },
                        new
                        {
                            Id = 3,
                            CreateDate = new DateTime(2023, 8, 29, 11, 56, 55, 145, DateTimeKind.Local).AddTicks(3121),
                            DepartmentId = 1,
                            Description = "Front-End Development focuses on crafting the user interface of websites and applications using HTML, CSS, and JavaScript for an engaging and accessible user experience.",
                            Name = "Front-End Developer"
                        },
                        new
                        {
                            Id = 4,
                            CreateDate = new DateTime(2023, 8, 29, 11, 56, 55, 145, DateTimeKind.Local).AddTicks(3123),
                            DepartmentId = 7,
                            Description = "Housekeeper is a professional who ensures cleanliness and order in homes or businesses by performing tasks such as cleaning, organizing, and maintaining a tidy environment.",
                            Name = "HouseKeeper"
                        },
                        new
                        {
                            Id = 5,
                            CreateDate = new DateTime(2023, 8, 29, 11, 56, 55, 145, DateTimeKind.Local).AddTicks(3125),
                            DepartmentId = 4,
                            Description = "An office boy, or office assistant, is a support staff member responsible for performing administrative tasks such as filing, photocopying, mail distribution, and office organization",
                            Name = "Office Boy"
                        },
                        new
                        {
                            Id = 6,
                            CreateDate = new DateTime(2023, 8, 29, 11, 56, 55, 145, DateTimeKind.Local).AddTicks(3127),
                            DepartmentId = 4,
                            Description = "A tea maker skillfully brews tea, achieving optimal taste and aroma by selecting leaves, controlling brewing, and catering to preferences.",
                            Name = "Tea Maker & Sailor"
                        },
                        new
                        {
                            Id = 7,
                            CreateDate = new DateTime(2023, 8, 29, 11, 56, 55, 145, DateTimeKind.Local).AddTicks(3129),
                            DepartmentId = 4,
                            Description = "A secretary organizes appointments, manages correspondence, and provides essential administrative support, contributing to efficient communication and smooth operations within an organization.",
                            Name = "Secretary"
                        });
                });

            modelBuilder.Entity("HumanResource.Domain.Entities.Concrete.SalaryRequest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("AppUserId")
                        .HasColumnType("int");

                    b.Property<string>("BillExtension")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Currency")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DemandType")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("SalaryDemandAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.ToTable("SalaryRequests");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("HumanResource.Domain.Entities.Concrete.AppUser", b =>
                {
                    b.HasOne("HumanResource.Domain.Entities.Concrete.Company", "Company")
                        .WithMany("AppUsers")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("HumanResource.Domain.Entities.Concrete.Department", "Department")
                        .WithMany("AppUsers")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("HumanResource.Domain.Entities.Concrete.Job", "Job")
                        .WithMany("AppUsers")
                        .HasForeignKey("JobId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Company");

                    b.Navigation("Department");

                    b.Navigation("Job");
                });

            modelBuilder.Entity("HumanResource.Domain.Entities.Concrete.Department", b =>
                {
                    b.HasOne("HumanResource.Domain.Entities.Concrete.Company", "Company")
                        .WithMany("Departments")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Company");
                });

            modelBuilder.Entity("HumanResource.Domain.Entities.Concrete.Job", b =>
                {
                    b.HasOne("HumanResource.Domain.Entities.Concrete.Department", "Department")
                        .WithMany("Jobs")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Department");
                });

            modelBuilder.Entity("HumanResource.Domain.Entities.Concrete.SalaryRequest", b =>
                {
                    b.HasOne("HumanResource.Domain.Entities.Concrete.AppUser", "AppUser")
                        .WithMany("SalaryRequests")
                        .HasForeignKey("AppUserId");

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("HumanResource.Domain.Entities.Concrete.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("HumanResource.Domain.Entities.Concrete.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("HumanResource.Domain.Entities.Concrete.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("HumanResource.Domain.Entities.Concrete.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HumanResource.Domain.Entities.Concrete.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("HumanResource.Domain.Entities.Concrete.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HumanResource.Domain.Entities.Concrete.AppUser", b =>
                {
                    b.Navigation("SalaryRequests");
                });

            modelBuilder.Entity("HumanResource.Domain.Entities.Concrete.Company", b =>
                {
                    b.Navigation("AppUsers");

                    b.Navigation("Departments");
                });

            modelBuilder.Entity("HumanResource.Domain.Entities.Concrete.Department", b =>
                {
                    b.Navigation("AppUsers");

                    b.Navigation("Jobs");
                });

            modelBuilder.Entity("HumanResource.Domain.Entities.Concrete.Job", b =>
                {
                    b.Navigation("AppUsers");
                });
#pragma warning restore 612, 618
        }
    }
}