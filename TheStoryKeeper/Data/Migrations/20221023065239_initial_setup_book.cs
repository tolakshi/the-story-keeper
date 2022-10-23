using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheStoryKeeper.Data.Migrations
{
    public partial class initial_setup_book : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Book",
                columns: table => new
                {
                    AutoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookId = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    BookName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    BookAvailability = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book", x => x.AutoId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Book");
        }
    }
}
