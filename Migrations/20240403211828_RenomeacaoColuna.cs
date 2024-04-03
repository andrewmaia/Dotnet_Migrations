using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dotnet_Migrations.Migrations
{
    /// <inheritdoc />
    public partial class RenomeacaoColuna : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DataCriacao",
                table: "Clientes",
                newName: "DataInsercao");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DataInsercao",
                table: "Clientes",
                newName: "DataCriacao");
        }
    }
}
