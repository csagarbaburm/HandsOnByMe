using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFBookServiceAPI.Migrations
{
    /// <inheritdoc />
    public partial class mig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_book",
                columns: table => new
                {
                    BookId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BookName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Author = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Lang = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    ReleaseDate = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_book", x => x.BookId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_book");
        }
    }
}
