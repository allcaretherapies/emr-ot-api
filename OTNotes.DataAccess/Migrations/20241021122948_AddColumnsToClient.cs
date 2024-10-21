using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OTNotes.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddColumnsToClient : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CurrentlyWorking",
                table: "CHGeneral",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExpectationFromTherepist",
                table: "CHGeneral",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "OtBeforeTaken",
                table: "CHGeneral",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TakingServiceByAgency",
                table: "CHGeneral",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "livingInHome",
                table: "CHGeneral",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CurrentlyWorking",
                table: "CHGeneral");

            migrationBuilder.DropColumn(
                name: "ExpectationFromTherepist",
                table: "CHGeneral");

            migrationBuilder.DropColumn(
                name: "OtBeforeTaken",
                table: "CHGeneral");

            migrationBuilder.DropColumn(
                name: "TakingServiceByAgency",
                table: "CHGeneral");

            migrationBuilder.DropColumn(
                name: "livingInHome",
                table: "CHGeneral");
        }
    }
}
