using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PruebaTecnica.Core.Migrations
{
    public partial class AddFechaCreacionAndModificicacion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "FechaCreacion",
                table: "Direcciones",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaModificacion",
                table: "Direcciones",
                type: "datetime2",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "Direcciones");

            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "Direcciones");
        }
    }
}
