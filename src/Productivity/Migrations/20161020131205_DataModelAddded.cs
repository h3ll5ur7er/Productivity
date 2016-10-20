using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Productivity.Migrations
{
    public partial class DataModelAddded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Personen",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Autoincrement", true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personen", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Neubau",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Autoincrement", true),
                    EmployeeId = table.Column<int>(nullable: false),
                    FaktorMontageArt = table.Column<double>(nullable: false),
                    FaktorStockwerk = table.Column<double>(nullable: false),
                    FaktorSystem = table.Column<double>(nullable: false),
                    FaktorZugang = table.Column<double>(nullable: false),
                    KW = table.Column<int>(nullable: false),
                    Produktivitaet = table.Column<double>(nullable: false),
                    Wirtschaftlichkeit = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Neubau", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Neubau_Personen_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Personen",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Umbau",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Autoincrement", true),
                    EmployeeId = table.Column<int>(nullable: false),
                    FaktorMontageArt = table.Column<double>(nullable: false),
                    FaktorStockwerk = table.Column<double>(nullable: false),
                    FaktorSystem = table.Column<double>(nullable: false),
                    FaktorZugang = table.Column<double>(nullable: false),
                    KW = table.Column<int>(nullable: false),
                    Produktivitaet = table.Column<double>(nullable: false),
                    Wirtschaftlichkeit = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Umbau", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Umbau_Personen_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Personen",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Neubau_EmployeeId",
                table: "Neubau",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Umbau_EmployeeId",
                table: "Umbau",
                column: "EmployeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Neubau");

            migrationBuilder.DropTable(
                name: "Umbau");

            migrationBuilder.DropTable(
                name: "Personen");
        }
    }
}
