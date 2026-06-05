using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppMVCTechCrew.Migrations
{
    /// <inheritdoc />
    public partial class aadhars : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "aadhar",
                columns: table => new
                {
                    AadharNo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dob = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_aadhar", x => x.AadharNo);
                });

            migrationBuilder.CreateTable(
                name: "pan",
                columns: table => new
                {
                    PanNo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PanUserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AadharRefNo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pan", x => x.PanNo);
                    table.ForeignKey(
                        name: "FK_pan_aadhar_AadharRefNo",
                        column: x => x.AadharRefNo,
                        principalTable: "aadhar",
                        principalColumn: "AadharNo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_pan_AadharRefNo",
                table: "pan",
                column: "AadharRefNo",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "pan");

            migrationBuilder.DropTable(
                name: "aadhar");
        }
    }
}
