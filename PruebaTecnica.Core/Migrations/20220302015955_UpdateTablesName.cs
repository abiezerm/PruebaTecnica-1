using Microsoft.EntityFrameworkCore.Migrations;

namespace PruebaTecnica.Core.Migrations
{
    public partial class UpdateTablesName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Direcciones_Municipio_MunicipioId",
                table: "Direcciones");

            migrationBuilder.DropForeignKey(
                name: "FK_Direcciones_Provincia_ProvinciaId",
                table: "Direcciones");

            migrationBuilder.DropForeignKey(
                name: "FK_Municipio_Provincia_ProvinciaId",
                table: "Municipio");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Provincia",
                table: "Provincia");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Municipio",
                table: "Municipio");

            migrationBuilder.RenameTable(
                name: "Provincia",
                newName: "Provincias");

            migrationBuilder.RenameTable(
                name: "Municipio",
                newName: "Municipios");

            migrationBuilder.RenameIndex(
                name: "IX_Municipio_ProvinciaId",
                table: "Municipios",
                newName: "IX_Municipios_ProvinciaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Provincias",
                table: "Provincias",
                column: "ProvinciaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Municipios",
                table: "Municipios",
                column: "MunicipioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Direcciones_Municipios_MunicipioId",
                table: "Direcciones",
                column: "MunicipioId",
                principalTable: "Municipios",
                principalColumn: "MunicipioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Direcciones_Provincias_ProvinciaId",
                table: "Direcciones",
                column: "ProvinciaId",
                principalTable: "Provincias",
                principalColumn: "ProvinciaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Municipios_Provincias_ProvinciaId",
                table: "Municipios",
                column: "ProvinciaId",
                principalTable: "Provincias",
                principalColumn: "ProvinciaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Direcciones_Municipios_MunicipioId",
                table: "Direcciones");

            migrationBuilder.DropForeignKey(
                name: "FK_Direcciones_Provincias_ProvinciaId",
                table: "Direcciones");

            migrationBuilder.DropForeignKey(
                name: "FK_Municipios_Provincias_ProvinciaId",
                table: "Municipios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Provincias",
                table: "Provincias");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Municipios",
                table: "Municipios");

            migrationBuilder.RenameTable(
                name: "Provincias",
                newName: "Provincia");

            migrationBuilder.RenameTable(
                name: "Municipios",
                newName: "Municipio");

            migrationBuilder.RenameIndex(
                name: "IX_Municipios_ProvinciaId",
                table: "Municipio",
                newName: "IX_Municipio_ProvinciaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Provincia",
                table: "Provincia",
                column: "ProvinciaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Municipio",
                table: "Municipio",
                column: "MunicipioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Direcciones_Municipio_MunicipioId",
                table: "Direcciones",
                column: "MunicipioId",
                principalTable: "Municipio",
                principalColumn: "MunicipioId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Direcciones_Provincia_ProvinciaId",
                table: "Direcciones",
                column: "ProvinciaId",
                principalTable: "Provincia",
                principalColumn: "ProvinciaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Municipio_Provincia_ProvinciaId",
                table: "Municipio",
                column: "ProvinciaId",
                principalTable: "Provincia",
                principalColumn: "ProvinciaId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
