using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HumanResource.Infrastructure.Migrations
{
    public partial class mig12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CompanyType",
                table: "Companies",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ContractEndDate",
                table: "Companies",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ContractStartDate",
                table: "Companies",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeCount",
                table: "Companies",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FoundationDate",
                table: "Companies",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LogoFile",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MersisNo",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TaxAdminIsTrationType",
                table: "Companies",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TaxNo",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TelephoneNumber",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "3b382b00-74d4-4069-ac02-b44c62855ef6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "81f43ef6-dfbc-4fb2-9290-57636d689ce6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "34da642d-978d-435d-b039-bd7a45e7352e");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "CreateDate" },
                values: new object[] { "Istanbul", new DateTime(2023, 9, 5, 13, 26, 3, 645, DateTimeKind.Local).AddTicks(7945) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "CreateDate" },
                values: new object[] { "Ankara", new DateTime(2023, 9, 5, 13, 26, 3, 645, DateTimeKind.Local).AddTicks(7949) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "CreateDate" },
                values: new object[] { "Antalya", new DateTime(2023, 9, 5, 13, 26, 3, 645, DateTimeKind.Local).AddTicks(7951) });

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 9, 5, 13, 26, 3, 646, DateTimeKind.Local).AddTicks(742));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 9, 5, 13, 26, 3, 646, DateTimeKind.Local).AddTicks(745));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 9, 5, 13, 26, 3, 646, DateTimeKind.Local).AddTicks(754));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 9, 5, 13, 26, 3, 646, DateTimeKind.Local).AddTicks(756));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2023, 9, 5, 13, 26, 3, 646, DateTimeKind.Local).AddTicks(759));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2023, 9, 5, 13, 26, 3, 646, DateTimeKind.Local).AddTicks(761));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2023, 9, 5, 13, 26, 3, 646, DateTimeKind.Local).AddTicks(763));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2023, 9, 5, 13, 26, 3, 646, DateTimeKind.Local).AddTicks(765));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2023, 9, 5, 13, 26, 3, 646, DateTimeKind.Local).AddTicks(767));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 9, 5, 13, 26, 3, 646, DateTimeKind.Local).AddTicks(4579));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 9, 5, 13, 26, 3, 646, DateTimeKind.Local).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 9, 5, 13, 26, 3, 646, DateTimeKind.Local).AddTicks(4584));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 9, 5, 13, 26, 3, 646, DateTimeKind.Local).AddTicks(4587));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2023, 9, 5, 13, 26, 3, 646, DateTimeKind.Local).AddTicks(4589));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2023, 9, 5, 13, 26, 3, 646, DateTimeKind.Local).AddTicks(4591));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2023, 9, 5, 13, 26, 3, 646, DateTimeKind.Local).AddTicks(4593));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "CompanyType",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "ContractEndDate",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "ContractStartDate",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "EmployeeCount",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "FoundationDate",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "LogoFile",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "MersisNo",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "TaxAdminIsTrationType",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "TaxNo",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "TelephoneNumber",
                table: "Companies");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "d9e0a7d2-8e14-444e-b434-24e51c5a234c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "e575c592-9a9a-4b61-88f9-2a35365f952b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "48811f15-8331-40b6-8126-259069188520");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 9, 5, 10, 40, 16, 177, DateTimeKind.Local).AddTicks(8849));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 9, 5, 10, 40, 16, 177, DateTimeKind.Local).AddTicks(8851));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 9, 5, 10, 40, 16, 177, DateTimeKind.Local).AddTicks(8853));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 9, 5, 10, 40, 16, 178, DateTimeKind.Local).AddTicks(941));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 9, 5, 10, 40, 16, 178, DateTimeKind.Local).AddTicks(943));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 9, 5, 10, 40, 16, 178, DateTimeKind.Local).AddTicks(945));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 9, 5, 10, 40, 16, 178, DateTimeKind.Local).AddTicks(947));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2023, 9, 5, 10, 40, 16, 178, DateTimeKind.Local).AddTicks(949));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2023, 9, 5, 10, 40, 16, 178, DateTimeKind.Local).AddTicks(950));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2023, 9, 5, 10, 40, 16, 178, DateTimeKind.Local).AddTicks(952));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2023, 9, 5, 10, 40, 16, 178, DateTimeKind.Local).AddTicks(954));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2023, 9, 5, 10, 40, 16, 178, DateTimeKind.Local).AddTicks(955));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 9, 5, 10, 40, 16, 178, DateTimeKind.Local).AddTicks(2987));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 9, 5, 10, 40, 16, 178, DateTimeKind.Local).AddTicks(2989));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 9, 5, 10, 40, 16, 178, DateTimeKind.Local).AddTicks(2991));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 9, 5, 10, 40, 16, 178, DateTimeKind.Local).AddTicks(2993));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2023, 9, 5, 10, 40, 16, 178, DateTimeKind.Local).AddTicks(2994));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2023, 9, 5, 10, 40, 16, 178, DateTimeKind.Local).AddTicks(2996));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2023, 9, 5, 10, 40, 16, 178, DateTimeKind.Local).AddTicks(2997));
        }
    }
}
