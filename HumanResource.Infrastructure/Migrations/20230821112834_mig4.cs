using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HumanResource.Infrastructure.Migrations
{
    public partial class mig4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Departmants_DepartmantId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Jobs_Departmants_DepartmantId",
                table: "Jobs");

            migrationBuilder.RenameColumn(
                name: "DepartmantId",
                table: "Jobs",
                newName: "DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Jobs_DepartmantId",
                table: "Jobs",
                newName: "IX_Jobs_DepartmentId");

            migrationBuilder.RenameColumn(
                name: "DepartmantId",
                table: "AspNetUsers",
                newName: "DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUsers_DepartmantId",
                table: "AspNetUsers",
                newName: "IX_AspNetUsers_DepartmentId");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "e8a228bb-6049-43b8-95bd-b94e4a1aeb3e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "1c0387ce-d1e8-4df3-b3c0-77e8866bdee1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "87151854-f31b-4f88-9ae2-9f89765b9c62");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 8, 21, 14, 28, 33, 721, DateTimeKind.Local).AddTicks(1052));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 8, 21, 14, 28, 33, 721, DateTimeKind.Local).AddTicks(1055));

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 8, 21, 14, 28, 33, 721, DateTimeKind.Local).AddTicks(1057));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 8, 21, 14, 28, 33, 721, DateTimeKind.Local).AddTicks(4524));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 8, 21, 14, 28, 33, 721, DateTimeKind.Local).AddTicks(4527));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 8, 21, 14, 28, 33, 721, DateTimeKind.Local).AddTicks(4529));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 8, 21, 14, 28, 33, 721, DateTimeKind.Local).AddTicks(4531));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2023, 8, 21, 14, 28, 33, 721, DateTimeKind.Local).AddTicks(4533));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2023, 8, 21, 14, 28, 33, 721, DateTimeKind.Local).AddTicks(4535));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2023, 8, 21, 14, 28, 33, 721, DateTimeKind.Local).AddTicks(4537));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2023, 8, 21, 14, 28, 33, 721, DateTimeKind.Local).AddTicks(4538));

            migrationBuilder.UpdateData(
                table: "Departmants",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2023, 8, 21, 14, 28, 33, 721, DateTimeKind.Local).AddTicks(4540));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 8, 21, 14, 28, 33, 721, DateTimeKind.Local).AddTicks(7081));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 8, 21, 14, 28, 33, 721, DateTimeKind.Local).AddTicks(7084));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 8, 21, 14, 28, 33, 721, DateTimeKind.Local).AddTicks(7086));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 8, 21, 14, 28, 33, 721, DateTimeKind.Local).AddTicks(7088));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2023, 8, 21, 14, 28, 33, 721, DateTimeKind.Local).AddTicks(7090));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2023, 8, 21, 14, 28, 33, 721, DateTimeKind.Local).AddTicks(7092));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2023, 8, 21, 14, 28, 33, 721, DateTimeKind.Local).AddTicks(7094));

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Departmants_DepartmentId",
                table: "AspNetUsers",
                column: "DepartmentId",
                principalTable: "Departmants",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Jobs_Departmants_DepartmentId",
                table: "Jobs",
                column: "DepartmentId",
                principalTable: "Departmants",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Departmants_DepartmentId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Jobs_Departmants_DepartmentId",
                table: "Jobs");

            migrationBuilder.RenameColumn(
                name: "DepartmentId",
                table: "Jobs",
                newName: "DepartmantId");

            migrationBuilder.RenameIndex(
                name: "IX_Jobs_DepartmentId",
                table: "Jobs",
                newName: "IX_Jobs_DepartmantId");

            migrationBuilder.RenameColumn(
                name: "DepartmentId",
                table: "AspNetUsers",
                newName: "DepartmantId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUsers_DepartmentId",
                table: "AspNetUsers",
                newName: "IX_AspNetUsers_DepartmantId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Departmants_DepartmantId",
                table: "AspNetUsers",
                column: "DepartmantId",
                principalTable: "Departmants",
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
    }
}
