using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoTematico.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AjusteGarden : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AccessProfileId",
                table: "Plants",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Apelido",
                table: "Plants",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataPlantio",
                table: "Plants",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "Plants",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Observacoes",
                table: "Plants",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Descricao",
                table: "Gardens",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Endereco",
                table: "Gardens",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "Gardens",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "AccessProfileId",
                table: "Cares",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Descricao",
                table: "Cares",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "IndPeriodicidade",
                table: "Cares",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Observacao",
                table: "Cares",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccessProfileId",
                table: "Plants");

            migrationBuilder.DropColumn(
                name: "Apelido",
                table: "Plants");

            migrationBuilder.DropColumn(
                name: "DataPlantio",
                table: "Plants");

            migrationBuilder.DropColumn(
                name: "Nome",
                table: "Plants");

            migrationBuilder.DropColumn(
                name: "Observacoes",
                table: "Plants");

            migrationBuilder.DropColumn(
                name: "Descricao",
                table: "Gardens");

            migrationBuilder.DropColumn(
                name: "Endereco",
                table: "Gardens");

            migrationBuilder.DropColumn(
                name: "Nome",
                table: "Gardens");

            migrationBuilder.DropColumn(
                name: "AccessProfileId",
                table: "Cares");

            migrationBuilder.DropColumn(
                name: "Descricao",
                table: "Cares");

            migrationBuilder.DropColumn(
                name: "IndPeriodicidade",
                table: "Cares");

            migrationBuilder.DropColumn(
                name: "Observacao",
                table: "Cares");
        }
    }
}
