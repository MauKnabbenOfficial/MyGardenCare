using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoTematico.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AjustesLogin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Senha",
                table: "Users",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Senha",
                table: "Users");
        }
    }
}
