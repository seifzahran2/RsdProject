using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TestRSD.Migrations
{
    public partial class AddTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "deactivateUnits",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TReson = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Explain = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Attach = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Datamatrex = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumBand = table.Column<int>(type: "int", nullable: false),
                    NumTaslsl = table.Column<int>(type: "int", nullable: false),
                    NumDofaa = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_deactivateUnits", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "deactivationCancels",
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
                    table.PrimaryKey("PK_deactivationCancels", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "drugSellCancles",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GlobalNum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeSall = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WasfaNum = table.Column<int>(type: "int", nullable: false),
                    Attach = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Datamatrex = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumBand = table.Column<int>(type: "int", nullable: false),
                    NumTaslsl = table.Column<int>(type: "int", nullable: false),
                    NumDofaa = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_drugSellCancles", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "drugSells",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WasfaNum = table.Column<int>(type: "int", nullable: false),
                    TypeSall = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Doctor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pationat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Attach = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Datamatrex = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumBand = table.Column<int>(type: "int", nullable: false),
                    NumTaslsl = table.Column<int>(type: "int", nullable: false),
                    NumDofaa = table.Column<int>(type: "int", nullable: false),
                    Date2 = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_drugSells", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "returns",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GlobalNum = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Attach = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Datamatrex = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumBand = table.Column<int>(type: "int", nullable: false),
                    NumTaslsl = table.Column<int>(type: "int", nullable: false),
                    NumDofaa = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_returns", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "transferCancles",
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
                    table.PrimaryKey("PK_transferCancles", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "transfers",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GlobalNum = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Attach = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Datamatrex = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumBand = table.Column<int>(type: "int", nullable: false),
                    NumTaslsl = table.Column<int>(type: "int", nullable: false),
                    NumDofaa = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_transfers", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "deactivateUnits");

            migrationBuilder.DropTable(
                name: "deactivationCancels");

            migrationBuilder.DropTable(
                name: "drugSellCancles");

            migrationBuilder.DropTable(
                name: "drugSells");

            migrationBuilder.DropTable(
                name: "returns");

            migrationBuilder.DropTable(
                name: "transferCancles");

            migrationBuilder.DropTable(
                name: "transfers");
        }
    }
}
