using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HumanResource.Infrastructure.Migrations
{
    public partial class migBuk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "SalaryRequests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ResponseDate",
                table: "SalaryRequests",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Gender",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "AdvanceDemand",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ResponseDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Currency = table.Column<int>(type: "int", nullable: false),
                    AdvanceType = table.Column<int>(type: "int", nullable: false),
                    AppUserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdvanceDemand", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdvanceDemand_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PermissionDemand",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MalePermissionType = table.Column<int>(type: "int", nullable: true),
                    FemalePermissionType = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BeginingDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FinishDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ResponseDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AppUserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PermissionDemand", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PermissionDemand_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "ad169c03-6373-4450-9f0f-271fe7788e38");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "e6e813a5-efbe-4664-8e56-6f2949652c8a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "d8d6ca5a-a48f-4e50-87ba-f3afcec75921");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 8, 29, 15, 14, 56, 139, DateTimeKind.Local).AddTicks(6133));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 8, 29, 15, 14, 56, 139, DateTimeKind.Local).AddTicks(6138));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 8, 29, 15, 14, 56, 139, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 8, 29, 15, 14, 56, 140, DateTimeKind.Local).AddTicks(1515));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 8, 29, 15, 14, 56, 140, DateTimeKind.Local).AddTicks(1524));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 8, 29, 15, 14, 56, 140, DateTimeKind.Local).AddTicks(1533));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 8, 29, 15, 14, 56, 140, DateTimeKind.Local).AddTicks(1537));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2023, 8, 29, 15, 14, 56, 140, DateTimeKind.Local).AddTicks(1540));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2023, 8, 29, 15, 14, 56, 140, DateTimeKind.Local).AddTicks(1544));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2023, 8, 29, 15, 14, 56, 140, DateTimeKind.Local).AddTicks(1556));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2023, 8, 29, 15, 14, 56, 140, DateTimeKind.Local).AddTicks(1560));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2023, 8, 29, 15, 14, 56, 140, DateTimeKind.Local).AddTicks(1564));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 8, 29, 15, 14, 56, 140, DateTimeKind.Local).AddTicks(8796));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 8, 29, 15, 14, 56, 140, DateTimeKind.Local).AddTicks(8803));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 8, 29, 15, 14, 56, 140, DateTimeKind.Local).AddTicks(8809));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 8, 29, 15, 14, 56, 140, DateTimeKind.Local).AddTicks(8815));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2023, 8, 29, 15, 14, 56, 140, DateTimeKind.Local).AddTicks(8821));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2023, 8, 29, 15, 14, 56, 140, DateTimeKind.Local).AddTicks(8827));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2023, 8, 29, 15, 14, 56, 140, DateTimeKind.Local).AddTicks(8833));

            migrationBuilder.CreateIndex(
                name: "IX_AdvanceDemand_AppUserId",
                table: "AdvanceDemand",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PermissionDemand_AppUserId",
                table: "PermissionDemand",
                column: "AppUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdvanceDemand");

            migrationBuilder.DropTable(
                name: "PermissionDemand");

            migrationBuilder.DropColumn(
                name: "ResponseDate",
                table: "SalaryRequests");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "SalaryRequests",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "273e0e2b-d694-459d-af13-8a0d3a1970f8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "9b9a7182-8a72-4d1d-98fb-2df7f6620ec8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "04a9e13b-12c5-443f-acfd-abdb33369120");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 8, 29, 11, 56, 55, 144, DateTimeKind.Local).AddTicks(8183));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 8, 29, 11, 56, 55, 144, DateTimeKind.Local).AddTicks(8186));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 8, 29, 11, 56, 55, 144, DateTimeKind.Local).AddTicks(8188));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 8, 29, 11, 56, 55, 145, DateTimeKind.Local).AddTicks(564));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 8, 29, 11, 56, 55, 145, DateTimeKind.Local).AddTicks(567));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 8, 29, 11, 56, 55, 145, DateTimeKind.Local).AddTicks(569));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 8, 29, 11, 56, 55, 145, DateTimeKind.Local).AddTicks(571));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2023, 8, 29, 11, 56, 55, 145, DateTimeKind.Local).AddTicks(573));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2023, 8, 29, 11, 56, 55, 145, DateTimeKind.Local).AddTicks(575));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2023, 8, 29, 11, 56, 55, 145, DateTimeKind.Local).AddTicks(577));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2023, 8, 29, 11, 56, 55, 145, DateTimeKind.Local).AddTicks(579));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2023, 8, 29, 11, 56, 55, 145, DateTimeKind.Local).AddTicks(581));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 8, 29, 11, 56, 55, 145, DateTimeKind.Local).AddTicks(3116));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 8, 29, 11, 56, 55, 145, DateTimeKind.Local).AddTicks(3119));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 8, 29, 11, 56, 55, 145, DateTimeKind.Local).AddTicks(3121));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 8, 29, 11, 56, 55, 145, DateTimeKind.Local).AddTicks(3123));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2023, 8, 29, 11, 56, 55, 145, DateTimeKind.Local).AddTicks(3125));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2023, 8, 29, 11, 56, 55, 145, DateTimeKind.Local).AddTicks(3127));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2023, 8, 29, 11, 56, 55, 145, DateTimeKind.Local).AddTicks(3129));
        }
    }
}
