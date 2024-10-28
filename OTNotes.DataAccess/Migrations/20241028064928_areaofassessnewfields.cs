using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OTNotes.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class areaofassessnewfields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ChildChalenges",
                table: "CHGeneral",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ChildIntrest",
                table: "CHGeneral",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ChildPastTherapy",
                table: "CHGeneral",
                type: "nvarchar(max)",
                maxLength: 5000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DiscribServiceOfOtherAgency",
                table: "CHGeneral",
                type: "nvarchar(max)",
                maxLength: 5000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LivingInHomeChild",
                table: "CHGeneral",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OtBeforDiscription",
                table: "CHGeneral",
                type: "nvarchar(max)",
                maxLength: 5000,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ChildChalenges",
                table: "CHGeneral");

            migrationBuilder.DropColumn(
                name: "ChildIntrest",
                table: "CHGeneral");

            migrationBuilder.DropColumn(
                name: "ChildPastTherapy",
                table: "CHGeneral");

            migrationBuilder.DropColumn(
                name: "DiscribServiceOfOtherAgency",
                table: "CHGeneral");

            migrationBuilder.DropColumn(
                name: "LivingInHomeChild",
                table: "CHGeneral");

            migrationBuilder.DropColumn(
                name: "OtBeforDiscription",
                table: "CHGeneral");
        }
    }
}
