using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class update_department_model : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Departments",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AddColumn<string>(
                name: "_key",
                table: "Departments",
                maxLength: 50,
                nullable: true);

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "_key",
                table: "Departments");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Departments",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(Guid));

        }
    }
}
