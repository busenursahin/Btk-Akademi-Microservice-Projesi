using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BtkAkademi.Service.OrderAPI.Migrations
{
    /// <inheritdoc />
    public partial class CrediCartAddMonthAndYear : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ExpiryMonthYear",
                table: "OrderHeaders",
                newName: "ExpiryYear");

            migrationBuilder.AddColumn<string>(
                name: "ExpiryMonth",
                table: "OrderHeaders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExpiryMonth",
                table: "OrderHeaders");

            migrationBuilder.RenameColumn(
                name: "ExpiryYear",
                table: "OrderHeaders",
                newName: "ExpiryMonthYear");
        }
    }
}
