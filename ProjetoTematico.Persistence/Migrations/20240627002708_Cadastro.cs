using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoTematico.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Cadastro : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GardenId",
                table: "Users",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Local",
                table: "Gardens",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ManagerChiefId",
                table: "Gardens",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Gardens",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "PermissaoLevel",
                table: "AccessProfiles",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GardenId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Local",
                table: "Gardens");

            migrationBuilder.DropColumn(
                name: "ManagerChiefId",
                table: "Gardens");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Gardens");

            migrationBuilder.DropColumn(
                name: "PermissaoLevel",
                table: "AccessProfiles");
        }
    }
}
