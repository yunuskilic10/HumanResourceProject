using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HumanResource.Infrastructure.Migrations
{
    public partial class mig9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DemandPrice",
                table: "AspNetUsers",
                newName: "TotalAdvancePerYear");

            migrationBuilder.AddColumn<decimal>(
                name: "MaxAdvanceLimitPerYear",
                table: "AspNetUsers",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "NewSalary",
                table: "AspNetUsers",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "RaiseDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ResponseFirstAdvanceDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ResponseLastAdvanceDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "90548e4f-9978-4873-a108-f167509ba006");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "2b8e1701-68f2-47e9-854d-030421350f7e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "40cba75c-ad49-409e-878c-ceba5d603a84");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 9, 1, 11, 4, 0, 329, DateTimeKind.Local).AddTicks(9170));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 9, 1, 11, 4, 0, 329, DateTimeKind.Local).AddTicks(9172));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 9, 1, 11, 4, 0, 329, DateTimeKind.Local).AddTicks(9174));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 9, 1, 11, 4, 0, 330, DateTimeKind.Local).AddTicks(1524));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 9, 1, 11, 4, 0, 330, DateTimeKind.Local).AddTicks(1529));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 9, 1, 11, 4, 0, 330, DateTimeKind.Local).AddTicks(1530));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 9, 1, 11, 4, 0, 330, DateTimeKind.Local).AddTicks(1532));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2023, 9, 1, 11, 4, 0, 330, DateTimeKind.Local).AddTicks(1534));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2023, 9, 1, 11, 4, 0, 330, DateTimeKind.Local).AddTicks(1536));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2023, 9, 1, 11, 4, 0, 330, DateTimeKind.Local).AddTicks(1537));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2023, 9, 1, 11, 4, 0, 330, DateTimeKind.Local).AddTicks(1539));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2023, 9, 1, 11, 4, 0, 330, DateTimeKind.Local).AddTicks(1541));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 9, 1, 11, 4, 0, 330, DateTimeKind.Local).AddTicks(3715));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 9, 1, 11, 4, 0, 330, DateTimeKind.Local).AddTicks(3717));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 9, 1, 11, 4, 0, 330, DateTimeKind.Local).AddTicks(3719));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 9, 1, 11, 4, 0, 330, DateTimeKind.Local).AddTicks(3721));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2023, 9, 1, 11, 4, 0, 330, DateTimeKind.Local).AddTicks(3723));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2023, 9, 1, 11, 4, 0, 330, DateTimeKind.Local).AddTicks(3725));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2023, 9, 1, 11, 4, 0, 330, DateTimeKind.Local).AddTicks(3726));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MaxAdvanceLimitPerYear",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "NewSalary",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "RaiseDate",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ResponseFirstAdvanceDate",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ResponseLastAdvanceDate",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "TotalAdvancePerYear",
                table: "AspNetUsers",
                newName: "DemandPrice");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "13ab8fab-b344-4f84-ab59-11ca3e6d0742");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "b55f945d-4f56-47f3-ae5a-4372842e88dc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "9684e7aa-5667-4507-a5da-8f35c1b38dbf");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 8, 29, 19, 34, 27, 695, DateTimeKind.Local).AddTicks(4266));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 8, 29, 19, 34, 27, 695, DateTimeKind.Local).AddTicks(4268));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 8, 29, 19, 34, 27, 695, DateTimeKind.Local).AddTicks(4270));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 8, 29, 19, 34, 27, 695, DateTimeKind.Local).AddTicks(6389));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 8, 29, 19, 34, 27, 695, DateTimeKind.Local).AddTicks(6392));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 8, 29, 19, 34, 27, 695, DateTimeKind.Local).AddTicks(6394));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 8, 29, 19, 34, 27, 695, DateTimeKind.Local).AddTicks(6396));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2023, 8, 29, 19, 34, 27, 695, DateTimeKind.Local).AddTicks(6398));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2023, 8, 29, 19, 34, 27, 695, DateTimeKind.Local).AddTicks(6400));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2023, 8, 29, 19, 34, 27, 695, DateTimeKind.Local).AddTicks(6402));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2023, 8, 29, 19, 34, 27, 695, DateTimeKind.Local).AddTicks(6403));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2023, 8, 29, 19, 34, 27, 695, DateTimeKind.Local).AddTicks(6405));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 8, 29, 19, 34, 27, 695, DateTimeKind.Local).AddTicks(8533));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 8, 29, 19, 34, 27, 695, DateTimeKind.Local).AddTicks(8535));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 8, 29, 19, 34, 27, 695, DateTimeKind.Local).AddTicks(8537));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 8, 29, 19, 34, 27, 695, DateTimeKind.Local).AddTicks(8539));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2023, 8, 29, 19, 34, 27, 695, DateTimeKind.Local).AddTicks(8541));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2023, 8, 29, 19, 34, 27, 695, DateTimeKind.Local).AddTicks(8543));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2023, 8, 29, 19, 34, 27, 695, DateTimeKind.Local).AddTicks(8544));
        }
    }
}
