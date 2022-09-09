using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NoteBag.Migrations
{
    public partial class First : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Notes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Notes",
                columns: new[] { "Id", "Content", "Title" },
                values: new object[] { 1, "Lorem Lorem Lorem Lorem Lorem", "Lorem Ipsum" });

            migrationBuilder.InsertData(
                table: "Notes",
                columns: new[] { "Id", "Content", "Title" },
                values: new object[] { 2, "Lorem Lorem Lorem Lorem Lorem", "Dolor Sit" });

            migrationBuilder.InsertData(
                table: "Notes",
                columns: new[] { "Id", "Content", "Title" },
                values: new object[] { 3, "Lorem Lorem Lorem Lorem Lorem", "Amet " });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notes");
        }
    }
}
