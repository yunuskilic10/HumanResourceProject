using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HumanResource.Infrastructure.Migrations
{
    public partial class mig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Jobs",
                type: "int",
                nullable: true,
                defaultValue: 2);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Departmants",
                type: "int",
                nullable: true,
                defaultValue: 2);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Companies",
                type: "int",
                nullable: true,
                defaultValue: 2);

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "AspNetUsers",
                type: "int",
                nullable: true,
                defaultValue: 2,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "IdentityNumber",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "ce41f529-2965-42e1-8b33-02c8354c4785");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "d986f893-096e-4a48-9d19-dcbddf1cce7c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "5cb1d4be-cd49-4563-ae87-870675071f0b");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 8, 18, 17, 56, 13, 297, DateTimeKind.Local).AddTicks(7223));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 8, 18, 17, 56, 13, 297, DateTimeKind.Local).AddTicks(7225));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 8, 18, 17, 56, 13, 297, DateTimeKind.Local).AddTicks(7227));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 8, 18, 17, 56, 13, 297, DateTimeKind.Local).AddTicks(9461));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 8, 18, 17, 56, 13, 297, DateTimeKind.Local).AddTicks(9463));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 8, 18, 17, 56, 13, 297, DateTimeKind.Local).AddTicks(9465));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 8, 18, 17, 56, 13, 297, DateTimeKind.Local).AddTicks(9467));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2023, 8, 18, 17, 56, 13, 297, DateTimeKind.Local).AddTicks(9469));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2023, 8, 18, 17, 56, 13, 297, DateTimeKind.Local).AddTicks(9471));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2023, 8, 18, 17, 56, 13, 297, DateTimeKind.Local).AddTicks(9472));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2023, 8, 18, 17, 56, 13, 297, DateTimeKind.Local).AddTicks(9474));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2023, 8, 18, 17, 56, 13, 297, DateTimeKind.Local).AddTicks(9476));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 8, 18, 17, 56, 13, 298, DateTimeKind.Local).AddTicks(1486));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 8, 18, 17, 56, 13, 298, DateTimeKind.Local).AddTicks(1489));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 8, 18, 17, 56, 13, 298, DateTimeKind.Local).AddTicks(1490));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 8, 18, 17, 56, 13, 298, DateTimeKind.Local).AddTicks(1492));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2023, 8, 18, 17, 56, 13, 298, DateTimeKind.Local).AddTicks(1494));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2023, 8, 18, 17, 56, 13, 298, DateTimeKind.Local).AddTicks(1495));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2023, 8, 18, 17, 56, 13, 298, DateTimeKind.Local).AddTicks(1497));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Departmants");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Companies");

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValue: 2);

            migrationBuilder.AlterColumn<int>(
                name: "IdentityNumber",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "169f2ddd-b6cb-43f4-8c85-72e12472069e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "13b00cee-edbf-4b94-b40e-0f77eb1a8dd3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "47df9f86-f79b-4aa2-b565-3defb6ddab6a");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 8, 18, 15, 21, 18, 436, DateTimeKind.Local).AddTicks(1121));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 8, 18, 15, 21, 18, 436, DateTimeKind.Local).AddTicks(1123));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 8, 18, 15, 21, 18, 436, DateTimeKind.Local).AddTicks(1125));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 8, 18, 15, 21, 18, 436, DateTimeKind.Local).AddTicks(6074));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 8, 18, 15, 21, 18, 436, DateTimeKind.Local).AddTicks(6078));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 8, 18, 15, 21, 18, 436, DateTimeKind.Local).AddTicks(6080));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 8, 18, 15, 21, 18, 436, DateTimeKind.Local).AddTicks(6082));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2023, 8, 18, 15, 21, 18, 436, DateTimeKind.Local).AddTicks(6085));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2023, 8, 18, 15, 21, 18, 436, DateTimeKind.Local).AddTicks(6088));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2023, 8, 18, 15, 21, 18, 436, DateTimeKind.Local).AddTicks(6091));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2023, 8, 18, 15, 21, 18, 436, DateTimeKind.Local).AddTicks(6093));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2023, 8, 18, 15, 21, 18, 436, DateTimeKind.Local).AddTicks(6095));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 8, 18, 15, 21, 18, 436, DateTimeKind.Local).AddTicks(8886));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 8, 18, 15, 21, 18, 436, DateTimeKind.Local).AddTicks(8891));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 8, 18, 15, 21, 18, 436, DateTimeKind.Local).AddTicks(8894));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 8, 18, 15, 21, 18, 436, DateTimeKind.Local).AddTicks(8898));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2023, 8, 18, 15, 21, 18, 436, DateTimeKind.Local).AddTicks(8901));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2023, 8, 18, 15, 21, 18, 436, DateTimeKind.Local).AddTicks(8905));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2023, 8, 18, 15, 21, 18, 436, DateTimeKind.Local).AddTicks(8909));
        }
    }
}
