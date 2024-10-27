using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class MigForTColors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TemporanyColors",
                columns: table => new
                {
                    TemporanyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TemporanyColorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TemporanyColorCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TemporanyColorIsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TemporanyColors", x => x.TemporanyId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TemporanyColors");
        }
    }
}
