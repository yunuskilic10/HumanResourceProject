using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HumanResource.Infrastructure.Migrations
{
    public partial class mig13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PrivateMail",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "63794580-6e54-4523-8e14-4f1ef79d2987");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "1a22431a-ba99-466c-9859-28c29cfd3aac");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "04dc4a7a-7f5f-4eb5-b364-e6ca94f2cb28");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 9, 6, 11, 45, 3, 829, DateTimeKind.Local).AddTicks(2460));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 9, 6, 11, 45, 3, 829, DateTimeKind.Local).AddTicks(2463));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 9, 6, 11, 45, 3, 829, DateTimeKind.Local).AddTicks(2465));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 9, 6, 11, 45, 3, 829, DateTimeKind.Local).AddTicks(5312));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 9, 6, 11, 45, 3, 829, DateTimeKind.Local).AddTicks(5319));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 9, 6, 11, 45, 3, 829, DateTimeKind.Local).AddTicks(5321));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 9, 6, 11, 45, 3, 829, DateTimeKind.Local).AddTicks(5323));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2023, 9, 6, 11, 45, 3, 829, DateTimeKind.Local).AddTicks(5324));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2023, 9, 6, 11, 45, 3, 829, DateTimeKind.Local).AddTicks(5326));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2023, 9, 6, 11, 45, 3, 829, DateTimeKind.Local).AddTicks(5331));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2023, 9, 6, 11, 45, 3, 829, DateTimeKind.Local).AddTicks(5333));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2023, 9, 6, 11, 45, 3, 829, DateTimeKind.Local).AddTicks(5335));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 9, 6, 11, 45, 3, 829, DateTimeKind.Local).AddTicks(7473));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 9, 6, 11, 45, 3, 829, DateTimeKind.Local).AddTicks(7476));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 9, 6, 11, 45, 3, 829, DateTimeKind.Local).AddTicks(7478));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 9, 6, 11, 45, 3, 829, DateTimeKind.Local).AddTicks(7480));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2023, 9, 6, 11, 45, 3, 829, DateTimeKind.Local).AddTicks(7482));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2023, 9, 6, 11, 45, 3, 829, DateTimeKind.Local).AddTicks(7490));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2023, 9, 6, 11, 45, 3, 829, DateTimeKind.Local).AddTicks(7491));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PrivateMail",
                table: "AspNetUsers");

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
                column: "CreateDate",
                value: new DateTime(2023, 9, 5, 13, 26, 3, 645, DateTimeKind.Local).AddTicks(7945));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 9, 5, 13, 26, 3, 645, DateTimeKind.Local).AddTicks(7949));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 9, 5, 13, 26, 3, 645, DateTimeKind.Local).AddTicks(7951));

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
    }
}
