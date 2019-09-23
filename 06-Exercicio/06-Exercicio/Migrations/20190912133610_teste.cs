using Microsoft.EntityFrameworkCore.Migrations;

namespace _06_Exercicio.Migrations
{
    public partial class teste : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Condominios",
                table: "Condominios");

            migrationBuilder.RenameTable(
                name: "Condominios",
                newName: "TblCondominio");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "TblCondominio",
                maxLength: 40,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TblCondominio",
                table: "TblCondominio",
                column: "CondominioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TblCondominio",
                table: "TblCondominio");

            migrationBuilder.RenameTable(
                name: "TblCondominio",
                newName: "Condominios");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Condominios",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 40);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Condominios",
                table: "Condominios",
                column: "CondominioId");
        }
    }
}
