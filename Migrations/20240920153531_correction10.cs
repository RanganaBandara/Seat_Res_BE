using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Seat_Reservation.Migrations
{
    /// <inheritdoc />
    public partial class correction10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "User_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LoginDtos",
                table: "LoginDtos",
                column: "User_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LoginDtos",
                table: "LoginDtos");
        }
    }
}
