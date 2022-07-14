using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TestRSD.Migrations
{
    public partial class AddOpTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accepts",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Attach = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Datamatrex = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumBand = table.Column<int>(type: "int", nullable: false),
                    NumTaslsl = table.Column<int>(type: "int", nullable: false),
                    NumDofaa = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accepts", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accepts");
        }
    }
}
