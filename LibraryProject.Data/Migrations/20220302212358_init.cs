using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryProject.Data.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BookReservation",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    BookId = table.Column<int>(nullable: false),
                    ReservedUserName = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    IdentityNumber = table.Column<string>(nullable: true),
                    ReserveStartDate = table.Column<DateTime>(nullable: false),
                    ReserveEndDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookReservation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BookReservationHistory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    BookId = table.Column<int>(nullable: false),
                    ReservedUserName = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    IdentityNumber = table.Column<string>(nullable: true),
                    ReserveStartDate = table.Column<DateTime>(nullable: false),
                    ReserveEndDate = table.Column<DateTime>(nullable: false),
                    ReservationStatus = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookReservationHistory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    BookName = table.Column<string>(nullable: true),
                    Auther = table.Column<string>(nullable: true),
                    ISBN = table.Column<string>(nullable: true),
                    BookPublishYear = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Status = table.Column<int>(nullable: false),
                    ControllerUserName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Auther", "BookName", "BookPublishYear", "ControllerUserName", "CreatedDate", "ISBN", "Price", "Status" },
                values: new object[] { 1, "Levis Corrol", "Alis Harikalar Diyarında", 2022, "Admin User", new DateTime(2022, 3, 3, 0, 23, 58, 562, DateTimeKind.Local).AddTicks(3538), "975-17-1627-6", 20m, 3 });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Auther", "BookName", "BookPublishYear", "ControllerUserName", "CreatedDate", "ISBN", "Price", "Status" },
                values: new object[] { 2, "Andersen", "Andersen Masalları", 2005, "Admin User", new DateTime(2022, 3, 3, 0, 23, 58, 564, DateTimeKind.Local).AddTicks(364), "975-17-1627-6", 20m, 3 });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Auther", "BookName", "BookPublishYear", "ControllerUserName", "CreatedDate", "ISBN", "Price", "Status" },
                values: new object[] { 3, "Aisopos", "Ezop Masalları", 1995, "Admin User", new DateTime(2022, 3, 3, 0, 23, 58, 564, DateTimeKind.Local).AddTicks(431), "975-17-1627-6", 20m, 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookReservation");

            migrationBuilder.DropTable(
                name: "BookReservationHistory");

            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
