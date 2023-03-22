using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Coursera.Migrations
{
    /// <inheritdoc />
    public partial class StudentMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StudentsET",
                columns: table => new
                {
                    Studentid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentFirstname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentLastname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentAge = table.Column<int>(type: "int", nullable: false),
                    StudentPhone = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentsET", x => x.Studentid);
                });

            migrationBuilder.InsertData(
                table: "StudentsET",
                columns: new[] { "Studentid", "Gender", "Password", "StudentAge", "StudentEmail", "StudentFirstname", "StudentLastname", "StudentPhone" },
                values: new object[,]
                {
                    { 1, "Male", "01227007298", 21, "mahmoudmatar49@gmail.com", "mahmoud", "Matar", "01128673348" },
                    { 2, "Male", "01111614941", 20, "Ziad12@yahoo.com", "Ziad", "ElSadany", "01003246344" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentsET");
        }
    }
}
