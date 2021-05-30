using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CSharpGroup.Migrations
{
    public partial class Uinquecode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndTime",
                table: "Orders");

            migrationBuilder.AddColumn<int>(
                name: "UniqueCode",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UniqueCode",
                table: "Orders");

            migrationBuilder.AddColumn<DateTime>(
                name: "EndTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
