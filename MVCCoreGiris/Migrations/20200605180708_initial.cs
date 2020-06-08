using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCCoreGiris.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kisiler",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KisiAd = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kisiler", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Kisiler",
                columns: new[] { "Id", "KisiAd" },
                values: new object[] { 1, "Ali" });

            migrationBuilder.InsertData(
                table: "Kisiler",
                columns: new[] { "Id", "KisiAd" },
                values: new object[] { 2, "Aliye" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kisiler");
        }
    }
}
