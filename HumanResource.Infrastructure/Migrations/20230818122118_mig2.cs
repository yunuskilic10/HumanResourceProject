using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HumanResource.Infrastructure.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Companies_CompanyId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Departmants_DepartmantId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Jobs_JobId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Departmants_Companies_CompanyId",
                table: "Departmants");

            migrationBuilder.DropForeignKey(
                name: "FK_Jobs_Departmants_DepartmantId",
                table: "Jobs");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Jobs",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Jobs",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Departmants",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Departmants",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Companies",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PhotoFile",
                table: "AspNetUsers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "AspNetUsers",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, "169f2ddd-b6cb-43f4-8c85-72e12472069e", "Admin", "ADMIN" },
                    { 2, "13b00cee-edbf-4b94-b40e-0f77eb1a8dd3", "CompanyManager", "COMPANYMANAGER" },
                    { 3, "47df9f86-f79b-4aa2-b565-3defb6ddab6a", "Personnel", "PERSONNEL" }
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "CreateDate", "DeleteDate", "Name", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 18, 15, 21, 18, 436, DateTimeKind.Local).AddTicks(1121), null, "BilgeAdam Akademi", null },
                    { 2, new DateTime(2023, 8, 18, 15, 21, 18, 436, DateTimeKind.Local).AddTicks(1123), null, "Neos Akademi", null },
                    { 3, new DateTime(2023, 8, 18, 15, 21, 18, 436, DateTimeKind.Local).AddTicks(1125), null, "İstanbul Eğitim Akademi", null }
                });

            migrationBuilder.InsertData(
                table: "Departmants",
                columns: new[] { "Id", "CompanyId", "CreateDate", "DeleteDate", "Description", "Name", "UpdateDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 8, 18, 15, 21, 18, 436, DateTimeKind.Local).AddTicks(6074), null, "Generate secure random user identities with hashed passwords and salts using this code snippet.", "IT", null },
                    { 2, 2, new DateTime(2023, 8, 18, 15, 21, 18, 436, DateTimeKind.Local).AddTicks(6078), null, "Generate secure random user identities with hashed passwords and salts using this code snippet.", "IT", null },
                    { 3, 3, new DateTime(2023, 8, 18, 15, 21, 18, 436, DateTimeKind.Local).AddTicks(6080), null, "Generate secure random user identities with hashed passwords and salts using this code snippet.", "IT", null },
                    { 4, 1, new DateTime(2023, 8, 18, 15, 21, 18, 436, DateTimeKind.Local).AddTicks(6082), null, "Human Resources (HR) is a critical function that oversees personnel activities, including recruitment, training, benefits, and workplace policies.", "Human Resources", null },
                    { 5, 2, new DateTime(2023, 8, 18, 15, 21, 18, 436, DateTimeKind.Local).AddTicks(6085), null, "Human Resources (HR) is a critical function that oversees personnel activities, including recruitment, training, benefits, and workplace policies.", "Human Resources", null },
                    { 6, 3, new DateTime(2023, 8, 18, 15, 21, 18, 436, DateTimeKind.Local).AddTicks(6088), null, "Human Resources (HR) is a critical function that oversees personnel activities, including recruitment, training, benefits, and workplace policies.", "Human Resources", null },
                    { 7, 1, new DateTime(2023, 8, 18, 15, 21, 18, 436, DateTimeKind.Local).AddTicks(6091), null, "The Services Department ensures efficient business operations by offering essential support functions such as customer assistance, technical help, maintenance, and issue resolution.", "Services Departmants", null },
                    { 8, 2, new DateTime(2023, 8, 18, 15, 21, 18, 436, DateTimeKind.Local).AddTicks(6093), null, "The Services Department ensures efficient business operations by offering essential support functions such as customer assistance, technical help, maintenance, and issue resolution.", "Services Departmants", null },
                    { 9, 3, new DateTime(2023, 8, 18, 15, 21, 18, 436, DateTimeKind.Local).AddTicks(6095), null, "The Services Department ensures efficient business operations by offering essential support functions such as customer assistance, technical help, maintenance, and issue resolution.", "Services Departmants", null }
                });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "CreateDate", "DeleteDate", "DepartmantId", "Description", "Name", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 18, 15, 21, 18, 436, DateTimeKind.Local).AddTicks(8886), null, 1, "A Full Stack Developer is a versatile expert in both front-end and back-end web development.", "Full-Stack Developer", null },
                    { 2, new DateTime(2023, 8, 18, 15, 21, 18, 436, DateTimeKind.Local).AddTicks(8891), null, 1, "Back-End Development focuses on building and maintaining the server-side components, databases, and APIs that drive the functionality of websites and applications.", "Back-End Developer", null },
                    { 3, new DateTime(2023, 8, 18, 15, 21, 18, 436, DateTimeKind.Local).AddTicks(8894), null, 1, "Front-End Development focuses on crafting the user interface of websites and applications using HTML, CSS, and JavaScript for an engaging and accessible user experience.", "Front-End Developer", null },
                    { 4, new DateTime(2023, 8, 18, 15, 21, 18, 436, DateTimeKind.Local).AddTicks(8898), null, 7, "Housekeeper is a professional who ensures cleanliness and order in homes or businesses by performing tasks such as cleaning, organizing, and maintaining a tidy environment.", "HouseKeeper", null },
                    { 5, new DateTime(2023, 8, 18, 15, 21, 18, 436, DateTimeKind.Local).AddTicks(8901), null, 4, "An office boy, or office assistant, is a support staff member responsible for performing administrative tasks such as filing, photocopying, mail distribution, and office organization", "Office Boy", null },
                    { 6, new DateTime(2023, 8, 18, 15, 21, 18, 436, DateTimeKind.Local).AddTicks(8905), null, 4, "A tea maker skillfully brews tea, achieving optimal taste and aroma by selecting leaves, controlling brewing, and catering to preferences.", "Tea Maker & Sailor", null },
                    { 7, new DateTime(2023, 8, 18, 15, 21, 18, 436, DateTimeKind.Local).AddTicks(8909), null, 4, "A secretary organizes appointments, manages correspondence, and provides essential administrative support, contributing to efficient communication and smooth operations within an organization.", "Secretary", null }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Companies_CompanyId",
                table: "AspNetUsers",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Departmants_DepartmantId",
                table: "AspNetUsers",
                column: "DepartmantId",
                principalTable: "Departmants",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Jobs_JobId",
                table: "AspNetUsers",
                column: "JobId",
                principalTable: "Jobs",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Departmants_Companies_CompanyId",
                table: "Departmants",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Jobs_Departmants_DepartmantId",
                table: "Jobs",
                column: "DepartmantId",
                principalTable: "Departmants",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Companies_CompanyId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Departmants_DepartmantId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Jobs_JobId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Departmants_Companies_CompanyId",
                table: "Departmants");

            migrationBuilder.DropForeignKey(
                name: "FK_Jobs_Departmants_DepartmantId",
                table: "Jobs");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "Address",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Jobs",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Jobs",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Departmants",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Departmants",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "PhotoFile",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Companies_CompanyId",
                table: "AspNetUsers",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Departmants_DepartmantId",
                table: "AspNetUsers",
                column: "DepartmantId",
                principalTable: "Departmants",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Jobs_JobId",
                table: "AspNetUsers",
                column: "JobId",
                principalTable: "Jobs",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Departmants_Companies_CompanyId",
                table: "Departmants",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Jobs_Departmants_DepartmantId",
                table: "Jobs",
                column: "DepartmantId",
                principalTable: "Departmants",
                principalColumn: "Id");
        }
    }
}
