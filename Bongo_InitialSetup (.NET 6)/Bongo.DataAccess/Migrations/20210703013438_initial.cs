using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Bongo.DataAccess.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StudyRoomBookings",
                columns: table => new
                {
                    BookingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudyRoomId = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudyRoomBookings", x => x.BookingId);
                });

            migrationBuilder.CreateTable(
                name: "StudyRooms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoomName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudyRooms", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "StudyRooms",
                columns: new[] { "Id", "RoomName", "RoomNumber" },
                values: new object[] { 1, "Everest", "A101" });

            migrationBuilder.InsertData(
                table: "StudyRooms",
                columns: new[] { "Id", "RoomName", "RoomNumber" },
                values: new object[] { 2, "Superior", "A201" });

            migrationBuilder.InsertData(
                table: "StudyRooms",
                columns: new[] { "Id", "RoomName", "RoomNumber" },
                values: new object[] { 3, "Victoria", "A301" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudyRoomBookings");

            migrationBuilder.DropTable(
                name: "StudyRooms");
        }
    }
}
