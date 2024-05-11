using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIViaCep.Migrations
{
    /// <inheritdoc />
    public partial class CriacaoInicial2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Bairro",
                table: "Enderecos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Cep",
                table: "Enderecos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Cidade",
                table: "Enderecos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Complemento",
                table: "Enderecos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Logradouro",
                table: "Enderecos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Numero",
                table: "Enderecos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Uf",
                table: "Enderecos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bairro",
                table: "Enderecos");

            migrationBuilder.DropColumn(
                name: "Cep",
                table: "Enderecos");

            migrationBuilder.DropColumn(
                name: "Cidade",
                table: "Enderecos");

            migrationBuilder.DropColumn(
                name: "Complemento",
                table: "Enderecos");

            migrationBuilder.DropColumn(
                name: "Logradouro",
                table: "Enderecos");

            migrationBuilder.DropColumn(
                name: "Numero",
                table: "Enderecos");

            migrationBuilder.DropColumn(
                name: "Uf",
                table: "Enderecos");
        }
    }
}
