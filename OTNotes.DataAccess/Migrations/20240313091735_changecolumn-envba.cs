using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OTNotes.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class changecolumnenvba : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsEnvBarrier",
                table: "CHGeneral");

            migrationBuilder.AddColumn<string>(
                name: "EnvBarrier",
                table: "CHGeneral",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EnvBarrier",
                table: "CHGeneral");

            migrationBuilder.AddColumn<string>(
                name: "IsEnvBarrier",
                table: "CHGeneral",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: true);
        }
    }
}
