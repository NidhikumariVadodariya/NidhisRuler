using Microsoft.EntityFrameworkCore.Migrations;

namespace NidhisRuler.Data.Migrations
{
    public partial class InitialCreate20221015 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ruler",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(nullable: true),
                    Shape = table.Column<string>(nullable: true),
                    Material = table.Column<string>(nullable: true),
                    Measurement = table.Column<string>(nullable: true),
                    Color = table.Column<string>(nullable: true),
                    Use = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ruler", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ruler");
        }
    }
}
