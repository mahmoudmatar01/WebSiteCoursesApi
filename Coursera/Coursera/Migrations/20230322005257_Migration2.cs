using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Coursera.Migrations
{
    /// <inheritdoc />
    public partial class Migration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TeacherET",
                columns: table => new
                {
                    Teacherid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeacherEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TeacherPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TeacherGender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Teacherphone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TeacherAge = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherET", x => x.Teacherid);
                });

            migrationBuilder.CreateTable(
                name: "CourseET",
                columns: table => new
                {
                    CourseID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CourseCapacity = table.Column<int>(type: "int", nullable: false),
                    CourseDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CourseTeacher = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Course_TeacherTeacherid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseET", x => x.CourseID);
                    table.ForeignKey(
                        name: "FK_CourseET_TeacherET_Course_TeacherTeacherid",
                        column: x => x.Course_TeacherTeacherid,
                        principalTable: "TeacherET",
                        principalColumn: "Teacherid");
                });

            migrationBuilder.CreateTable(
                name: "Student_Courses",
                columns: table => new
                {
                    CourseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Course_idCourseID = table.Column<int>(type: "int", nullable: true),
                    Studentid = table.Column<int>(type: "int", nullable: false),
                    Student_idStudentid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student_Courses", x => x.CourseId);
                    table.ForeignKey(
                        name: "FK_Student_Courses_CourseET_Course_idCourseID",
                        column: x => x.Course_idCourseID,
                        principalTable: "CourseET",
                        principalColumn: "CourseID");
                    table.ForeignKey(
                        name: "FK_Student_Courses_StudentsET_Student_idStudentid",
                        column: x => x.Student_idStudentid,
                        principalTable: "StudentsET",
                        principalColumn: "Studentid");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CourseET_Course_TeacherTeacherid",
                table: "CourseET",
                column: "Course_TeacherTeacherid");

            migrationBuilder.CreateIndex(
                name: "IX_Student_Courses_Course_idCourseID",
                table: "Student_Courses",
                column: "Course_idCourseID");

            migrationBuilder.CreateIndex(
                name: "IX_Student_Courses_Student_idStudentid",
                table: "Student_Courses",
                column: "Student_idStudentid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Student_Courses");

            migrationBuilder.DropTable(
                name: "CourseET");

            migrationBuilder.DropTable(
                name: "TeacherET");
        }
    }
}
