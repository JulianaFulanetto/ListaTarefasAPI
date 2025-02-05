using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ListaTarefasAPI.Migrations
{
    /// <inheritdoc />
    public partial class tarefa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nome",
                table: "Tarefas");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Tarefas",
                newName: "TarefaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TarefaId",
                table: "Tarefas",
                newName: "Id");

            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "Tarefas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
