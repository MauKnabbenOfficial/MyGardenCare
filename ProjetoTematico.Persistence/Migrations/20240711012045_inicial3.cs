using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoTematico.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class inicial3 : Migration
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CareId",
                table: "Works");

            migrationBuilder.DropColumn(
                name: "IdUsuarioRealizador",
                table: "Works");

            migrationBuilder.DropColumn(
                name: "Realizada",
                table: "Works");
        }
    }
}
