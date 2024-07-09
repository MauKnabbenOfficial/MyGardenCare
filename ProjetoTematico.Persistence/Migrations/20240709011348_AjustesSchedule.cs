using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoTematico.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AjustesSchedule : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CareId",
                table: "Works",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataRealizacao",
                table: "Works",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdUsuarioRealizador",
                table: "Works",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Realizada",
                table: "Works",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "PlantId",
                table: "Cares",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Works_CareId",
                table: "Works",
                column: "CareId");

            migrationBuilder.CreateIndex(
                name: "IX_Cares_PlantId",
                table: "Cares",
                column: "PlantId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cares_Plants_PlantId",
                table: "Cares",
                column: "PlantId",
                principalTable: "Plants",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Works_Cares_CareId",
                table: "Works",
                column: "CareId",
                principalTable: "Cares",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cares_Plants_PlantId",
                table: "Cares");

            migrationBuilder.DropForeignKey(
                name: "FK_Works_Cares_CareId",
                table: "Works");

            migrationBuilder.DropIndex(
                name: "IX_Works_CareId",
                table: "Works");

            migrationBuilder.DropIndex(
                name: "IX_Cares_PlantId",
                table: "Cares");

            migrationBuilder.DropColumn(
                name: "CareId",
                table: "Works");

            migrationBuilder.DropColumn(
                name: "DataRealizacao",
                table: "Works");

            migrationBuilder.DropColumn(
                name: "IdUsuarioRealizador",
                table: "Works");

            migrationBuilder.DropColumn(
                name: "Realizada",
                table: "Works");

            migrationBuilder.DropColumn(
                name: "PlantId",
                table: "Cares");
        }
    }
}
