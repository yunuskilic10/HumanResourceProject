using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HumanResource.Infrastructure.Migrations
{
    public partial class mig11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "fe6db621-78b9-4fd5-9238-08f7e54230de");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "be2cd2ed-9836-432e-83cf-3b319fac4cdf");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "040bdfb9-8fd9-4153-9193-a42780166056");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 9, 1, 19, 55, 58, 900, DateTimeKind.Local).AddTicks(7937));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 9, 1, 19, 55, 58, 900, DateTimeKind.Local).AddTicks(7944));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 9, 1, 19, 55, 58, 900, DateTimeKind.Local).AddTicks(7950));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 9, 1, 19, 55, 58, 901, DateTimeKind.Local).AddTicks(5676));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 9, 1, 19, 55, 58, 901, DateTimeKind.Local).AddTicks(5685));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 9, 1, 19, 55, 58, 901, DateTimeKind.Local).AddTicks(5692));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 9, 1, 19, 55, 58, 901, DateTimeKind.Local).AddTicks(5699));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2023, 9, 1, 19, 55, 58, 901, DateTimeKind.Local).AddTicks(5705));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2023, 9, 1, 19, 55, 58, 901, DateTimeKind.Local).AddTicks(5712));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2023, 9, 1, 19, 55, 58, 901, DateTimeKind.Local).AddTicks(5718));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2023, 9, 1, 19, 55, 58, 901, DateTimeKind.Local).AddTicks(5724));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2023, 9, 1, 19, 55, 58, 901, DateTimeKind.Local).AddTicks(5731));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 9, 1, 19, 55, 58, 902, DateTimeKind.Local).AddTicks(3116));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 9, 1, 19, 55, 58, 902, DateTimeKind.Local).AddTicks(3123));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 9, 1, 19, 55, 58, 902, DateTimeKind.Local).AddTicks(3129));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 9, 1, 19, 55, 58, 902, DateTimeKind.Local).AddTicks(3135));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2023, 9, 1, 19, 55, 58, 902, DateTimeKind.Local).AddTicks(3141));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2023, 9, 1, 19, 55, 58, 902, DateTimeKind.Local).AddTicks(3147));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2023, 9, 1, 19, 55, 58, 902, DateTimeKind.Local).AddTicks(3153));
        }
    }
}
