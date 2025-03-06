using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentManagment.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FinalStructure : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<char>(
                name: "LetterGrade",
                table: "Grades",
                type: "TEXT",
                nullable: false,
                defaultValue: '\0',
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LetterGrade",
                table: "Grades",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(char),
                oldType: "TEXT");
        }
    }
}
