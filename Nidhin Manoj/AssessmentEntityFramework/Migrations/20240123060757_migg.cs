using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AssessmentEntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class migg : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_stud",
                columns: table => new
                {
                    StudentId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Qualification = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Skill = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_stud", x => x.StudentId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_stud");
        }
    }
}
