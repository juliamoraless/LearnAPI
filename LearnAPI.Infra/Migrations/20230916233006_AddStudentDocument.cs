using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LearnAPI.Infra.Migrations
{
    /// <inheritdoc />
    public partial class AddStudentDocument : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Document",
                table: "Students",
                type: "varchar(12)",
                maxLength: 12,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Document",
                table: "Students");
        }
    }
}
