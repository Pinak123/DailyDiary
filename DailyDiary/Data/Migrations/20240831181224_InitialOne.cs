using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DailyDiary.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialOne : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Diary",
                columns: table => new
                {
                    SrNo = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Diary_Content = table.Column<string>(type: "TEXT", nullable: false),
                    Diary_Entry_Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Author = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diary", x => x.SrNo);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Diary");
        }
    }
}
