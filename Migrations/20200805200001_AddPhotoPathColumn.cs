﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace NetCore01_2._1.Migrations
{
    public partial class AddPhotoPathColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Department",
                table: "Employees",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "PhotoPath",
                table: "Employees",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhotoPath",
                table: "Employees");

            migrationBuilder.AlterColumn<int>(
                name: "Department",
                table: "Employees",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}
