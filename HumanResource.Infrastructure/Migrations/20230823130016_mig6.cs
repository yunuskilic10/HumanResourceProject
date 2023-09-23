using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HumanResource.Infrastructure.Migrations
{
    public partial class mig6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ConfirmCode",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "ed4dfdff-f8a4-4317-aa4b-3cd97ee953d0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "eac4f257-eee7-42a7-b957-2701db36f803");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "e8e5c2e2-b3cf-460a-bc0c-9594a307c089");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 8, 23, 16, 0, 15, 862, DateTimeKind.Local).AddTicks(7471));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 8, 23, 16, 0, 15, 862, DateTimeKind.Local).AddTicks(7474));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 8, 23, 16, 0, 15, 862, DateTimeKind.Local).AddTicks(7476));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 8, 23, 16, 0, 15, 863, DateTimeKind.Local).AddTicks(43));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 8, 23, 16, 0, 15, 863, DateTimeKind.Local).AddTicks(47));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 8, 23, 16, 0, 15, 863, DateTimeKind.Local).AddTicks(49));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 8, 23, 16, 0, 15, 863, DateTimeKind.Local).AddTicks(51));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2023, 8, 23, 16, 0, 15, 863, DateTimeKind.Local).AddTicks(54));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2023, 8, 23, 16, 0, 15, 863, DateTimeKind.Local).AddTicks(55));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2023, 8, 23, 16, 0, 15, 863, DateTimeKind.Local).AddTicks(58));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2023, 8, 23, 16, 0, 15, 863, DateTimeKind.Local).AddTicks(60));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2023, 8, 23, 16, 0, 15, 863, DateTimeKind.Local).AddTicks(62));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 8, 23, 16, 0, 15, 863, DateTimeKind.Local).AddTicks(2572));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 8, 23, 16, 0, 15, 863, DateTimeKind.Local).AddTicks(2576));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 8, 23, 16, 0, 15, 863, DateTimeKind.Local).AddTicks(2578));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 8, 23, 16, 0, 15, 863, DateTimeKind.Local).AddTicks(2580));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2023, 8, 23, 16, 0, 15, 863, DateTimeKind.Local).AddTicks(2582));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2023, 8, 23, 16, 0, 15, 863, DateTimeKind.Local).AddTicks(2583));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2023, 8, 23, 16, 0, 15, 863, DateTimeKind.Local).AddTicks(2585));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConfirmCode",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "306f41d0-e60a-49d1-bb7e-56877e052dce");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "f33c3166-0e56-449d-ad47-3b8594404cd2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "cdabbcec-87cb-417f-898a-3205e7797346");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 8, 22, 18, 38, 59, 929, DateTimeKind.Local).AddTicks(2739));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 8, 22, 18, 38, 59, 929, DateTimeKind.Local).AddTicks(2743));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 8, 22, 18, 38, 59, 929, DateTimeKind.Local).AddTicks(2744));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 8, 22, 18, 38, 59, 929, DateTimeKind.Local).AddTicks(5325));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 8, 22, 18, 38, 59, 929, DateTimeKind.Local).AddTicks(5328));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 8, 22, 18, 38, 59, 929, DateTimeKind.Local).AddTicks(5330));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 8, 22, 18, 38, 59, 929, DateTimeKind.Local).AddTicks(5333));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2023, 8, 22, 18, 38, 59, 929, DateTimeKind.Local).AddTicks(5335));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2023, 8, 22, 18, 38, 59, 929, DateTimeKind.Local).AddTicks(5337));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2023, 8, 22, 18, 38, 59, 929, DateTimeKind.Local).AddTicks(5340));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2023, 8, 22, 18, 38, 59, 929, DateTimeKind.Local).AddTicks(5342));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2023, 8, 22, 18, 38, 59, 929, DateTimeKind.Local).AddTicks(5344));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 8, 22, 18, 38, 59, 929, DateTimeKind.Local).AddTicks(7735));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 8, 22, 18, 38, 59, 929, DateTimeKind.Local).AddTicks(7739));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 8, 22, 18, 38, 59, 929, DateTimeKind.Local).AddTicks(7741));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 8, 22, 18, 38, 59, 929, DateTimeKind.Local).AddTicks(7744));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2023, 8, 22, 18, 38, 59, 929, DateTimeKind.Local).AddTicks(7746));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2023, 8, 22, 18, 38, 59, 929, DateTimeKind.Local).AddTicks(7748));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2023, 8, 22, 18, 38, 59, 929, DateTimeKind.Local).AddTicks(7757));
        }
    }
}
